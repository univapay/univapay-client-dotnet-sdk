// Custom test (not auto-generated): pins GetCharge(chargeId) — the store-scoped
// convenience call that reads the store id from the configured App Token instead
// of making the caller pass (and persist) one.
//
// Two things are guarded here.
//
// First the *guard*: when the configured token carries no usable store_id, the
// call must fail before a request is built. Interpolating a missing id would
// send GET /stores//charges/{id} — a confusing 4xx instead of a clear
// client-side failure — so the failure cases assert not just the throw but that
// no request was ever issued. Those cases are fully offline.
//
// Second the *delegation*: on the happy path this must behave exactly like
// client.ChargesApi.GetCharge(storeId, chargeId, polling), with the store id
// taken from the token. There is no mocking library here and the client is
// sealed, so the seam is the SDK's own HttpCallback — the same hook ApiTestBase
// uses — to capture the URL actually built. Those cases need the mock server and
// are ignored (not failed) when BASE_URL is unset.
//
// Note the SDK test harness injects JWT_TOKEN=test-jwt, which is not a JWT at
// all, so a test resting on the env-built client would silently exercise only
// the failure path. Hence the locally built clients.
//
// Seven SDKs are expected to share this contract; keep the case table aligned
// when porting.

using System;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;
using UnivaPay.Authentication;
using UnivaPay.Http.Client;
using UnivaPay.Http.Request;

namespace UnivaPay
{
    [TestFixture]
    public class ClientGetChargeTest
    {
        private const string MerchantId = "11ec8e24-0ecf-2c5a-923c-331b915dc311";
        private const string StoreId = "11ec8e24-b133-6c68-b54d-971717202e9b";
        private const string ChargeIdText = "11ec8e24-c5f5-6f2e-b9b0-1f4d3c6a9e10";

        private static Guid ChargeId => Guid.Parse(ChargeIdText);

        /// <summary>Captures the URL of every request built, before it is sent.</summary>
        private sealed class UrlCatcher : HttpCallback
        {
            public string Url { get; private set; }

            public override void OnBeforeRequest(HttpRequest request)
            {
                Url = request.QueryUrl;
            }
        }

        private static string Base64Url(string value)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(value))
                .Replace('+', '-')
                .Replace('/', '_')
                .TrimEnd('=');
        }

        /// <summary>Builds a JWT carrying claims. Header and signature are inert.</summary>
        private static string Jwt(object claims)
        {
            return Base64Url("{\"alg\":\"HS256\",\"typ\":\"JWT\"}")
                + "." + Base64Url(JsonConvert.SerializeObject(claims)) + ".c2ln";
        }

        private static string StoreToken =>
            Jwt(new { merchant_id = MerchantId, store_id = StoreId });

        private static string MerchantToken => Jwt(new { merchant_id = MerchantId });

        private static UnivapayClientSdkClient ClientWith(string jwtToken, HttpCallback callback)
        {
            var builder = new UnivapayClientSdkClient.Builder();
            if (jwtToken != null)
            {
                builder.BearerAuthCredentials(
                    new BearerAuthModel.Builder("not-a-real-secret", jwtToken).Build());
            }

            if (callback != null)
            {
                builder.HttpCallback(callback);
            }

            var baseUrl = System.Environment.GetEnvironmentVariable("BASE_URL");
            if (baseUrl != null)
            {
                builder.BaseUrl(baseUrl);
            }

            return builder.Build();
        }

        // ── The guard: no usable store_id ────────────────────────────────────

        [TestCase("a merchant-level token")]
        [TestCase("no configured credentials")]
        [TestCase("a malformed token")]
        [TestCase("a store_id that is not a UUID")]
        public void ThrowsAndIssuesNoRequest(string label)
        {
            string jwtToken;
            switch (label)
            {
                case "a merchant-level token":
                    jwtToken = MerchantToken;
                    break;
                case "no configured credentials":
                    jwtToken = null;
                    break;
                case "a malformed token":
                    jwtToken = "not.a-jwt";
                    break;
                default:
                    jwtToken = Jwt(new { merchant_id = MerchantId, store_id = "store-1" });
                    break;
            }

            var catcher = new UrlCatcher();
            var client = ClientWith(jwtToken, catcher);

            Assert.That(client.GetCurrentStoreId(), Is.Null, "precondition: no store id");

            var sync = Assert.Throws<InvalidOperationException>(
                () => client.GetCharge(ChargeId));
            Assert.That(sync.Message, Does.Contain("store-level App Token"));

            var async = Assert.Throws<InvalidOperationException>(
                () => client.GetChargeAsync(ChargeId));
            Assert.That(async.Message, Does.Contain("store-level App Token"));

            Assert.That(catcher.Url, Is.Null,
                "no request may be built when the store id is missing");
        }

        [Test]
        public void NeverPutsTheCredentialInTheMessage()
        {
            var client = ClientWith(MerchantToken, null);

            var error = Assert.Throws<InvalidOperationException>(
                () => client.GetCharge(ChargeId));

            Assert.That(error.Message, Does.Contain("GetCharge(storeId, chargeId)"));
            Assert.That(error.Message, Does.Not.Contain(MerchantToken));
            Assert.That(error.Message, Does.Not.Contain(MerchantId));
            Assert.That(error.Message, Does.Not.Contain(StoreId));
        }

        // ── The delegation: store id taken from the token ─────────────────────

        [Test]
        public void DelegatesWithTheStoreIdFromTheToken()
        {
            RequireMockServer();
            var catcher = new UrlCatcher();
            var client = ClientWith(StoreToken, catcher);

            var response = client.GetCharge(ChargeId);

            Assert.That(response, Is.Not.Null);
            Assert.That(response.StatusCode, Is.EqualTo(200));
            Assert.That(catcher.Url,
                Does.Contain("/stores/" + StoreId + "/charges/" + ChargeIdText));
        }

        [Test]
        public void ForwardsThePollingFlag()
        {
            RequireMockServer();
            var catcher = new UrlCatcher();

            ClientWith(StoreToken, catcher).GetCharge(ChargeId, true);

            Assert.That(catcher.Url, Does.Contain("polling=true"));
        }

        [Test]
        public void AsyncFormDelegatesToo()
        {
            RequireMockServer();
            var catcher = new UrlCatcher();
            var client = ClientWith(StoreToken, catcher);

            var response = client.GetChargeAsync(ChargeId).GetAwaiter().GetResult();

            Assert.That(response, Is.Not.Null);
            Assert.That(catcher.Url,
                Does.Contain("/stores/" + StoreId + "/charges/" + ChargeIdText));
        }

        [Test]
        public void ReusesOneControllerAcrossCalls()
        {
            var client = ClientWith(StoreToken, null);

            Assert.That(client.ChargesApi, Is.SameAs(client.ChargesApi));
        }

        private static void RequireMockServer()
        {
            if (System.Environment.GetEnvironmentVariable("BASE_URL") == null)
            {
                Assert.Ignore("needs the mock server; BASE_URL is unset");
            }
        }
    }
}
