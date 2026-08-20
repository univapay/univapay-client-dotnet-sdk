// <copyright file="Extensions.cs" company="Univapay">
// Hand-authored SDK extensions kept OUTSIDE the generated files.
//
// APIMatic regenerates the Api classes on every build, so any customization
// injected into those files risks a merge conflict whenever the spec changes
// nearby. The generated Api classes are not declared `partial`, so these
// helpers are C# extension methods living in a file APIMatic never generates —
// regeneration can never conflict with them.
//
// The helpers mirror the equivalent methods in the other UnivaPay SDKs
// (pollCharge / poll_charge in TypeScript, Python, Java, PHP and Ruby):
// re-issue the resource GET with polling=true until the resource leaves its
// initial state, up to a bounded number of attempts.
//
// Note there is deliberately no delay between attempts. Each request carries
// polling=true, which makes the server hold it open for up to 3 seconds, so
// the loop is already self-throttling (roughly one request per 3s against an
// exact-URL burst of 10 that refills at 2/s). Adding a delay would diverge
// from the other SDKs; dropping polling=true would turn this into the
// high-frequency polling loop the API documentation warns against.
// </copyright>
using System;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// Polling helpers that re-issue a resource request with
    /// <c>polling=true</c> until the resource leaves its initial state.
    /// </summary>
    public static class PollingExtensions
    {
        /// <summary>
        /// Number of polling attempts used when the caller does not specify one.
        /// Matches the default in the other UnivaPay SDKs.
        /// </summary>
        public const int DefaultPollAttempts = 10;

        /// <summary>
        /// Polls a charge with <c>polling=true</c> until it transitions out of
        /// its current status, or until <paramref name="maxAttempts"/> is
        /// exhausted.
        /// </summary>
        /// <remarks>
        /// Transition-aware: polling a <c>pending</c> charge stops on any other
        /// status, polling an <c>awaiting</c> charge (e.g. after a 3DS redirect)
        /// waits for <c>authorized</c>/<c>successful</c>/<c>failed</c>/
        /// <c>error</c>/<c>canceled</c>, and polling an <c>authorized</c> charge
        /// waits for its capture outcome. A charge already in a final status is
        /// returned immediately.
        /// A charge that has not transitioned when the attempts run out is
        /// returned as-is: that is a poll timeout, not a failure, and the caller
        /// should fall back to the webhook rather than treating the payment as
        /// failed. Errors from the underlying request propagate immediately;
        /// retrying transient gateway errors (502, 503, 504) is left to the
        /// caller. A <paramref name="maxAttempts"/> of zero or less skips the
        /// loop and fetches once (without holding).
        /// </remarks>
        public static async Task<ApiResponse<Models.Charge>> PollChargeAsync(
                this ChargesApi api,
                Guid storeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // Instant read (no hold) to key the transition map off the charge's
            // current status; a held first read could observe a transition and
            // re-key the map one state too far.
            var response = await api.GetChargeAsync(storeId, id, null, cancellationToken)
                .ConfigureAwait(false);
            var baseline = response.Data?.Status ?? Models.ChargeStatus.Pending;
            var targets = ChargeTargets(baseline);
            if (targets == null)
            {
                // Already in a final status polling cannot leave.
                return response;
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                response = await api.GetChargeAsync(storeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null
                    && Array.IndexOf(targets, response.Data.Status.Value) >= 0)
                {
                    return response;
                }
            }

            // Attempts exhausted: a poll timeout, not a failure.
            return response;
        }

        /// <summary>
        /// Polls a refund with <c>polling=true</c> until it reaches a final
        /// state, or until <paramref name="maxAttempts"/> is exhausted.
        /// See <see cref="PollChargeAsync"/> for timeout and error semantics.
        /// </summary>
        public static async Task<ApiResponse<Models.Refund>> PollRefundAsync(
                this RefundsApi api,
                Guid storeId,
                Guid chargeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetRefundAsync(storeId, chargeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null && IsTerminal(response.Data.Status.Value))
                {
                    return response;
                }
            }

            return await api.GetRefundAsync(storeId, chargeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Polls a cancel with <c>polling=true</c> until it reaches a final
        /// state, or until <paramref name="maxAttempts"/> is exhausted.
        /// See <see cref="PollChargeAsync"/> for timeout and error semantics.
        /// </summary>
        public static async Task<ApiResponse<Models.Cancel>> PollCancelAsync(
                this CancelsApi api,
                Guid storeId,
                Guid chargeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetCancelAsync(storeId, chargeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null && IsTerminal(response.Data.Status.Value))
                {
                    return response;
                }
            }

            return await api.GetCancelAsync(storeId, chargeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Polls a subscription with <c>polling=true</c> until it leaves
        /// <c>unverified</c>, or until <paramref name="maxAttempts"/> is
        /// exhausted. See <see cref="PollChargeAsync"/> for timeout and error
        /// semantics.
        /// </summary>
        /// <remarks>
        /// Expressed as "any status other than unverified" rather than a list of
        /// final states, matching the other UnivaPay SDKs: a subscription's poll
        /// ends on the first transition, and new statuses must not silently
        /// change that.
        /// </remarks>
        public static async Task<ApiResponse<Models.Subscription>> PollSubscriptionAsync(
                this SubscriptionsApi api,
                Guid storeId,
                Guid id,
                int maxAttempts = DefaultPollAttempts,
                CancellationToken cancellationToken = default)
        {
            if (api == null)
            {
                throw new ArgumentNullException(nameof(api));
            }

            // maxAttempts is honoured as given; zero or less means "fetch once".
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                var response = await api.GetSubscriptionAsync(storeId, id, true, cancellationToken)
                    .ConfigureAwait(false);
                if (response.Data?.Status != null
                    && response.Data.Status.Value != Models.SubscriptionStatus.Unverified)
                {
                    return response;
                }
            }

            return await api.GetSubscriptionAsync(storeId, id, true, cancellationToken)
                .ConfigureAwait(false);
        }


        /// <summary>
        /// Reports whether a charge has left <c>pending</c>. Wider than the four
        /// final states on purpose: the internal poll ends as soon as any
        /// transition out of <c>pending</c> occurs.
        /// </summary>
        /// <summary>
        /// Returns the statuses that end a poll started from the given status —
        /// the valid transitions out of each non-final charge status. Polling
        /// stops only when the charge reaches a status reachable from where it
        /// started. Null means the status is already final and there is nothing
        /// to poll for.
        /// </summary>
        private static Models.ChargeStatus[] ChargeTargets(Models.ChargeStatus status)
        {
            switch (status)
            {
                case Models.ChargeStatus.Pending:
                    return new[]
                    {
                        Models.ChargeStatus.Awaiting,
                        Models.ChargeStatus.Authorized,
                        Models.ChargeStatus.Successful,
                        Models.ChargeStatus.Failed,
                        Models.ChargeStatus.Error,
                        Models.ChargeStatus.Canceled,
                    };
                case Models.ChargeStatus.Awaiting:
                    return new[]
                    {
                        Models.ChargeStatus.Authorized,
                        Models.ChargeStatus.Successful,
                        Models.ChargeStatus.Failed,
                        Models.ChargeStatus.Error,
                        Models.ChargeStatus.Canceled,
                    };
                case Models.ChargeStatus.Authorized:
                    return new[]
                    {
                        Models.ChargeStatus.Successful,
                        Models.ChargeStatus.Failed,
                        Models.ChargeStatus.Error,
                        Models.ChargeStatus.Canceled,
                    };
                default:
                    return null;
            }
        }

        /// <summary>Reports whether a refund has reached a final state.</summary>
        private static bool IsTerminal(Models.RefundStatus status)
        {
            switch (status)
            {
                case Models.RefundStatus.Successful:
                case Models.RefundStatus.Failed:
                case Models.RefundStatus.Error:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>Reports whether a cancel has reached a final state.</summary>
        private static bool IsTerminal(Models.CancelStatus status)
        {
            switch (status)
            {
                case Models.CancelStatus.Successful:
                case Models.CancelStatus.Failed:
                case Models.CancelStatus.Error:
                    return true;
                default:
                    return false;
            }
        }
    }
}

namespace UnivaPay
{
    using System.Text.RegularExpressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Reads the context a UnivaPay app token was issued for out of its JWT.
    /// </summary>
    /// <remarks>
    /// A store-level app token carries both a <c>merchant_id</c> and a
    /// <c>store_id</c> claim; a merchant-level token carries only
    /// <c>merchant_id</c>.
    /// <para>
    /// Decoding only reads the payload segment — it does <b>not</b> verify the
    /// signature, which is deliberate. The value is the caller's own credential,
    /// already trusted by virtue of being configured on the client; nothing here
    /// is an authorization decision. Never use these values to authenticate a
    /// third party's token.
    /// </para>
    /// <para>
    /// These are extension methods rather than members of the generated client
    /// because <see cref="UnivapayClientSdkClient"/> is sealed and regenerated on
    /// every build; living in a file APIMatic never generates means regeneration
    /// can never conflict with them.
    /// </para>
    /// </remarks>
    public static class AppJwtExtensions
    {
        /// <summary>
        /// Matches the canonical 8-4-4-4-12 hexadecimal UUID form.
        /// </summary>
        /// <remarks>
        /// <c>Guid.TryParse</c> is considerably more lenient — it also accepts
        /// braced and undashed forms — so a claim is pattern-checked before being
        /// parsed, keeping every SDK's behaviour identical.
        /// <para>
        /// Anchored with <c>\A</c> and <c>\z</c> rather than <c>^</c> and <c>$</c>:
        /// in .NET <c>$</c> also matches immediately before a trailing newline, and
        /// <c>^</c> would match at every line start if anyone ever added
        /// <c>RegexOptions.Multiline</c>. These two anchors mean the whole string
        /// must be the UUID, whatever options are set.
        /// </para>
        /// </remarks>
        private static readonly Regex UuidPattern = new Regex(
            @"\A[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}\z",
            RegexOptions.Compiled);

        /// <summary>
        /// Gets the merchant this client's app token was issued for, decoded from
        /// the configured JWT.
        /// </summary>
        /// <remarks>
        /// Both merchant-level and store-level app tokens carry a merchant, so
        /// this is set for either kind of token.
        /// </remarks>
        /// <param name="client">The client whose JWT is read.</param>
        /// <returns>
        /// The merchant id, or null if no JWT is configured or its
        /// <c>merchant_id</c> claim is absent or not a UUID.
        /// </returns>
        public static Guid? GetCurrentMerchantId(this UnivapayClientSdkClient client)
        {
            return ReadUuidClaim(JwtTokenOrNull(client), "merchant_id");
        }

        /// <summary>
        /// Gets the store this client's app token was issued for, decoded from the
        /// configured JWT.
        /// </summary>
        /// <remarks>
        /// Only store-level app tokens are scoped to a store. A merchant-level
        /// token carries no <c>store_id</c> claim, so this returns null for one —
        /// use <c>client.StoresApi</c> to list the merchant's stores instead.
        /// </remarks>
        /// <param name="client">The client whose JWT is read.</param>
        /// <returns>
        /// The store id, or null if no JWT is configured or its <c>store_id</c>
        /// claim is absent or not a UUID.
        /// </returns>
        public static Guid? GetCurrentStoreId(this UnivapayClientSdkClient client)
        {
            return ReadUuidClaim(JwtTokenOrNull(client), "store_id");
        }

        /// <summary>The configured JWT, or null when no credentials are set.</summary>
        private static string JwtTokenOrNull(UnivapayClientSdkClient client)
        {
            return client?.BearerAuthCredentials?.JwtToken;
        }

        /// <summary>
        /// Decodes the payload segment of a JWT without verifying its signature.
        /// </summary>
        /// <returns>
        /// The payload claims, or null unless the token is a well-formed
        /// three-segment JWT whose payload segment is base64url-encoded JSON
        /// describing an object.
        /// </returns>
        private static JObject DecodePayload(string jwtToken)
        {
            if (string.IsNullOrEmpty(jwtToken))
            {
                return null;
            }

            var segments = jwtToken.Split('.');
            if (segments.Length != 3)
            {
                return null;
            }

            // Convert.FromBase64String needs standard base64 with padding, so
            // translate base64url and pad first.
            var base64 = segments[1].Replace('-', '+').Replace('_', '/');
            base64 = base64.PadRight(base64.Length + ((4 - (base64.Length % 4)) % 4), '=');

            string json;
            try
            {
                json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64));
            }
            catch (FormatException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }

            try
            {
                return JObject.Parse(json);
            }
            catch (Newtonsoft.Json.JsonException)
            {
                return null;
            }
        }

        /// <summary>
        /// Reads a claim from a JWT payload and returns it only if it is a UUID.
        /// </summary>
        /// <remarks>
        /// Anything else — claim absent, null, not a string, or a string that is
        /// not a canonical UUID — yields null, so a caller never has to
        /// distinguish "not set" from "could not decode".
        /// </remarks>
        private static Guid? ReadUuidClaim(string jwtToken, string claim)
        {
            var payload = DecodePayload(jwtToken);
            if (payload == null)
            {
                return null;
            }

            if (!(payload[claim] is JValue value) || value.Type != JTokenType.String)
            {
                return null;
            }

            var text = value.Value<string>();
            if (text == null || !UuidPattern.IsMatch(text))
            {
                return null;
            }

            return Guid.TryParse(text, out var parsed) ? parsed : (Guid?)null;
        }

        /// <summary>
        /// Retrieves a charge without being given a store id.
        /// </summary>
        /// <remarks>
        /// <c>/stores/{storeId}/charges/{id}</c> needs a store, which callers
        /// would otherwise have to persist alongside every charge id — but a
        /// store-level app token already carries one, so this reads it from the
        /// configured token and then behaves exactly like
        /// <c>client.ChargesApi.GetCharge</c>.
        /// </remarks>
        /// <param name="client">The client whose token supplies the store.</param>
        /// <param name="chargeId">The unique identifier of the charge.</param>
        /// <param name="polling">
        /// If true, instructs the API to internally poll the charge status until
        /// it leaves 'pending'.
        /// </param>
        /// <returns>The controller's response, untouched.</returns>
        /// <exception cref="InvalidOperationException">
        /// When the configured token carries no <c>store_id</c> claim — a
        /// merchant-level token, or none at all. Thrown before any request is
        /// built. Resolve the store yourself (see <c>client.StoresApi</c>) and
        /// call <c>client.ChargesApi.GetCharge</c> with it.
        /// </exception>
        public static ApiResponse<Models.Charge> GetCharge(
            this UnivapayClientSdkClient client,
            Guid chargeId,
            bool? polling = null)
        {
            // Guard first, controller second: C# evaluates the receiver before
            // the arguments, so the inline form would touch ChargesApi even on
            // the failure path.
            var storeId = RequireStoreId(client);
            return client.ChargesApi.GetCharge(storeId, chargeId, polling);
        }

        /// <summary>
        /// Retrieves a charge without being given a store id, asynchronously.
        /// </summary>
        /// <param name="client">The client whose token supplies the store.</param>
        /// <param name="chargeId">The unique identifier of the charge.</param>
        /// <param name="polling">
        /// If true, instructs the API to internally poll the charge status until
        /// it leaves 'pending'.
        /// </param>
        /// <param name="cancellationToken">cancellationToken.</param>
        /// <returns>The controller's response, untouched.</returns>
        /// <exception cref="InvalidOperationException">
        /// When the configured token carries no <c>store_id</c> claim. Thrown
        /// synchronously, before anything is scheduled.
        /// </exception>
        public static Task<ApiResponse<Models.Charge>> GetChargeAsync(
            this UnivapayClientSdkClient client,
            Guid chargeId,
            bool? polling = null,
            CancellationToken cancellationToken = default)
        {
            var storeId = RequireStoreId(client);
            return client.ChargesApi.GetChargeAsync(
                storeId, chargeId, polling, cancellationToken);
        }

        /// <summary>
        /// Asserts that a store id was resolvable from the configured app token.
        /// </summary>
        /// <remarks>
        /// The message deliberately says nothing about the token itself: the
        /// credential and its claims must never reach an exception message or a
        /// log. A merchant-level token arriving here is not a broken token — it
        /// is simply not scoped to a store.
        /// </remarks>
        private static Guid RequireStoreId(UnivapayClientSdkClient client)
        {
            var storeId = client.GetCurrentStoreId();
            if (storeId == null)
            {
                throw new InvalidOperationException(
                    "GetCharge(chargeId) requires a store-level App Token: the configured " +
                    "token carries no usable \"store_id\" claim. Use a store-level App Token, " +
                    "or call GetCharge(storeId, chargeId) on ChargesApi with an explicit " +
                    "store id.");
            }

            return storeId.Value;
        }
    }
}
