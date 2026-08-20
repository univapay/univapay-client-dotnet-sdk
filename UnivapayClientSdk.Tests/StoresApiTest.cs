// <copyright file="StoresApiTest.cs" company="APIMatic">
// UnivapayClientSdk.Tests
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using NUnit.Framework;
using Newtonsoft.Json.Converters;
using UnivaPay;
using UnivaPay.Apis;
using UnivaPay.Exceptions;
using UnivaPay.Http.Client;
using UnivaPay.Http.Response;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

namespace UnivaPay
{
    /// <summary>
    /// StoresApiTest.
    /// </summary>
    [TestFixture]
    public class StoresApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private StoresApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.StoresApi;
        }

        /// <summary>
        /// Returns stores visible to the current merchant credential. Supports cursor pagination plus `short_id` and free-text `search` filters..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListStores()
        {
            // Parameters for the API call
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string shortId = "st_01hxy9p8zw4d";
            string search = "tokyo";

            // Perform API call
            ApiResponse<Models.StoreList> result = null;
            try
            {
                result = await this.controller.ListStoresAsync(limit, cursor, cursorDirection, shortId, search);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"items\":[{\"id\":\"11ef0000-0000-4000-8000-000000000022\",\"name\":\"Tokyo Store\",\"merchant_name\":\"Example Merchant\",\"created_on\":\"2026-04-09T07:35:50.000000Z\"},{\"id\":\"11ef0000-0000-4000-8000-000000000023\",\"name\":\"Osaka Store\",\"merchant_name\":\"Example Merchant\",\"created_on\":\"2026-04-10T09:12:30.000000Z\"},{\"id\":\"11ef0000-0000-4000-8000-000000000024\",\"name\":\"Online Store\",\"merchant_name\":\"Example Merchant\",\"created_on\":\"2026-04-12T14:45:05.000000Z\"}],\"has_more\":false,\"total_hits\":3}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Returns a single store plus its resolved configuration snapshot for the current merchant context..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetStore()
        {
            // Parameters for the API call
            Guid id = Guid.Parse("c4e87129-cad4-47fb-8ded-b4c0a4ae0dd4");

            // Perform API call
            ApiResponse<Models.Store> result = null;
            try
            {
                result = await this.controller.GetStoreAsync(id);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"id\":\"11ef0000-0000-4000-8000-000000000022\",\"name\":\"Tokyo Store\",\"created_on\":\"2026-04-09T07:35:50.000000Z\",\"configuration\":{\"percent_fee\":3.6,\"country\":\"JP\",\"language\":\"ja\",\"minimum_charge_amounts\":[{\"amount\":100,\"currency\":\"JPY\"}],\"maximum_charge_amounts\":[{\"amount\":100000,\"currency\":\"JPY\"}],\"user_transactions_configuration\":{\"enabled\":true,\"notify_customer\":true,\"notify_on_webhook_failure\":true},\"card_configuration\":{\"enabled\":true,\"debit_enabled\":true,\"prepaid_enabled\":false,\"three_ds_required\":true},\"online_configuration\":{\"enabled\":true},\"bank_transfer_configuration\":{\"enabled\":true,\"match_amount\":true,\"expiration\":\"P7D\"},\"qr_scan_configuration\":{\"enabled\":true,\"forbidden_qr_scan_gateways\":[\"wechat\"]},\"convenience_configuration\":{\"enabled\":true,\"expiration\":\"P3D\"},\"paidy_configuration\":{\"enabled\":false},\"recurring_token_configuration\":{\"recurring_type\":\"infinite\",\"charge_wait_period\":\"P7D\",\"card_charge_cvv_confirmation\":{\"enabled\":false}},\"security_configuration\":{\"card_charge_cooldown\":\"PT5M\",\"subscription_cooldown\":\"PT10M\",\"restrict_ip_after_failed_charge\":{\"enabled\":true,\"count\":5,\"cooldown\":\"PT1H\"},\"refund_percent_limit\":100,\"confirmation_required\":false,\"min_refund_threshold\":100,\"limit_refund_by_sales\":{\"enabled\":true,\"period\":\"monthly\",\"rolling_window\":true}},\"installments_configuration\":{\"enabled\":true,\"card_processor\":{\"revolving\":true,\"fixed_cycle\":true},\"supported_payment_types\":[\"card\"],\"min_charge_amount\":{\"amount\":3000,\"currency\":\"JPY\"},\"max_payout_period\":\"P12M\",\"only_with_processor\":true},\"card_brand_percent_fees\":{\"visa\":3.6,\"mastercard\":3.6,\"jcb\":3.8}}}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Derives a deterministic, store-scoped UUID from a local customer identifier supplied by the merchant. Calling this endpoint again with the same `customer_id` for the same store always returns the same UUID — the operation has no side effects (nothing is persisted), so it is safe to call repeatedly and does not require an `Idempotency-Key`. App Token Secret is required..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateCustomerId()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Models.CreateCustomerIdRequest body = ApiHelper.JsonDeserialize<Models.CreateCustomerIdRequest>("{\"customer_id\":\"local-customer-1902\"}");

            // Perform API call
            ApiResponse<Models.CreateCustomerIdResponse> result = null;
            try
            {
                result = await this.controller.CreateCustomerIdAsync(storeId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"customer_id\":\"8a3f1b8e-2c1a-4b7a-9c2e-6f6b6f6e2b10\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}