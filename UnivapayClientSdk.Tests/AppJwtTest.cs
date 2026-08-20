// <copyright file="AppJwtTest.cs" company="APIMatic">
// UnivapayClientSdk.Tests
// </copyright>
//
// Custom test (not auto-generated): pins the App Token claim-decoding contract
// behind GetCurrentMerchantId() / GetCurrentStoreId().
//
// This contract is implemented seven times -- once per SDK -- and has already
// drifted twice: the Python SDK accepted non-canonical UUIDs that the others
// rejected, and the TypeScript SDK rejected a payload segment carrying '='
// padding that the others accepted. Neither was caught by a test, because none
// existed.
//
// So the cases below are deliberately a *shared table*: keep them identical in
// all seven SDKs. The failure being guarded against is the languages disagreeing
// with each other, which no single-language suite can see.
//
// Everything here is synthetic and offline -- no network, no environment, no
// real credential. It must pass in CI, where no token is configured.

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;
using UnivaPay.Authentication;

namespace UnivaPay
{
    [TestFixture]
    public class AppJwtTest
    {
        private const string MerchantId = "11ec8e24-0ecf-2c5a-923c-331b915dc311";
        private const string StoreId = "11ec8e24-b133-6c68-b54d-971717202e9b";

        private static string Base64Url(string value, bool padded = false)
        {
            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(value))
                .Replace('+', '-')
                .Replace('/', '_');

            return padded ? encoded : encoded.TrimEnd('=');
        }

        /// <summary>Builds a JWT carrying claims. Header and signature are inert.</summary>
        private static string Jwt(object claims, bool padded = false)
        {
            var header = Base64Url("{\"alg\":\"HS256\",\"typ\":\"JWT\"}");

            return header + "." + Base64Url(JsonConvert.SerializeObject(claims), padded) + ".c2ln";
        }

        /// <summary>Builds a JWT whose payload segment is payload, base64url-encoded.</summary>
        private static string RawJwt(string payload)
        {
            return "aGRy." + Base64Url(payload) + ".c2ln";
        }

        private static UnivapayClientSdkClient ClientWith(string jwtToken)
        {
            return new UnivapayClientSdkClient.Builder()
                .BearerAuthCredentials(
                    new BearerAuthModel.Builder("not-a-real-secret", jwtToken).Build())
                .Build();
        }

        [Test]
        public void ReadsBothIdsFromStoreLevelToken()
        {
            var client = ClientWith(Jwt(new { merchant_id = MerchantId, store_id = StoreId }));

            Assert.AreEqual(Guid.Parse(MerchantId), client.GetCurrentMerchantId());
            Assert.AreEqual(Guid.Parse(StoreId), client.GetCurrentStoreId());
        }

        [Test]
        public void ReadsMerchantFromMerchantLevelTokenAndReportsNoStore()
        {
            // A merchant-level token carries no store_id claim at all. Null here
            // is the correct answer, not a decoding failure.
            var client = ClientWith(Jwt(new { merchant_id = MerchantId }));

            Assert.AreEqual(Guid.Parse(MerchantId), client.GetCurrentMerchantId());
            Assert.IsNull(client.GetCurrentStoreId());
        }

        [Test]
        public void AcceptsPayloadSegmentThatCarriesPadding()
        {
            // The TypeScript SDK once rejected exactly this, making it the only
            // one of the seven to return null for a padded -- but valid -- token.
            var client = ClientWith(Jwt(new { merchant_id = MerchantId, store_id = StoreId }, true));

            Assert.AreEqual(Guid.Parse(MerchantId), client.GetCurrentMerchantId());
            Assert.AreEqual(Guid.Parse(StoreId), client.GetCurrentStoreId());
        }

        [TestCaseSource(nameof(UnusableInput))]
        public void ReturnsNullNeverThrowsForUnusableInput(string token)
        {
            Assert.IsNull(ClientWith(token).GetCurrentStoreId());
        }

        public static IEnumerable<TestCaseData> UnusableInput()
        {
            yield return Case("a claim that is JSON null", Jwt(new { store_id = (string)null }));
            yield return Case("a claim that is not a string", Jwt(new { store_id = 42 }));
            yield return Case("an undashed 32-character UUID", Jwt(new { store_id = StoreId.Replace("-", string.Empty) }));
            yield return Case("a braced UUID", Jwt(new { store_id = "{" + StoreId + "}" }));
            yield return Case("a urn-uuid prefixed UUID", Jwt(new { store_id = "urn:uuid:" + StoreId }));
            yield return Case("short hex groups 1-1-1-1-1", Jwt(new { store_id = "1-1-1-1-1" }));
            yield return Case("a UUID with a trailing newline", Jwt(new { store_id = StoreId + "\n" }));
            yield return Case("a UUID padded with spaces", Jwt(new { store_id = " " + StoreId + " " }));
            yield return Case("a two-segment token", "aGRy.c2ln");
            yield return Case("a payload that is not base64url", "aGRy.!!!!.c2ln");
            yield return Case("a payload that is a JSON array", RawJwt("[1,2]"));
            yield return Case("a payload that is not JSON", RawJwt("definitely not json"));
            yield return Case("an empty string", string.Empty);

            // The Authorization header value is secret.jwt -- four segments once
            // split. Pasting that whole value into the jwtToken field is the
            // mistake the guide warns about, and it must degrade to null, not to
            // a wrong id.
            yield return Case("the combined secret.jwt header value", "c2VjcmV0." + Jwt(new { store_id = StoreId }));
        }

        private static TestCaseData Case(string name, string token)
        {
            return new TestCaseData(token).SetName(name);
        }

        [Test]
        public void ReturnsNullWhenNoCredentialsConfigured()
        {
            var client = new UnivapayClientSdkClient.Builder().Build();

            Assert.IsNull(client.GetCurrentMerchantId());
            Assert.IsNull(client.GetCurrentStoreId());
        }
    }
}
