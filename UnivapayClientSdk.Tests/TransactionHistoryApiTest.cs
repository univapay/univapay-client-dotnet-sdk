// <copyright file="TransactionHistoryApiTest.cs" company="APIMatic">
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
    /// TransactionHistoryApiTest.
    /// </summary>
    [TestFixture]
    public class TransactionHistoryApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private TransactionHistoryApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TransactionHistoryApi;
        }

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds across all of the merchant's stores, combining both resource types into a single unified row shape..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListTransactionHistory()
        {
            // Parameters for the API call
            Models.TransactionHistoryMode mode = ApiHelper.JsonDeserialize<Models.TransactionHistoryMode>("\"test\"");
            string shortId = "8bfc29";
            string from = "2026-04-01T00:00:00Z";
            string to = "2026-04-30T23:59:59.999Z";
            Models.TransactionHistoryStatus status = ApiHelper.JsonDeserialize<Models.TransactionHistoryStatus>("\"successful\"");
            Models.TransactionHistoryType type = ApiHelper.JsonDeserialize<Models.TransactionHistoryType>("\"charge\"");
            string search = "Taro Yamada";
            string email = "user@example.com";
            Guid? id = Guid.Parse("11ef0000-0000-4000-8000-000000000070");
            string metadata = "order_id: 12345";
            string cardExp = "2026-04";
            string cardLastFour = "4242";
            string cardholder = "TARO YAMADA";
            List<string> cardBrand = ApiHelper.JsonDeserialize<List<string>>("[\"visa\"]");
            List<string> brand = ApiHelper.JsonDeserialize<List<string>>("[\"visa\"]");
            List<string> brands = ApiHelper.JsonDeserialize<List<string>>("[\"visa\",\"jcb\"]");
            string currency = "JPY";
            Models.TransactionHistoryServiceProvider serviceProvider = ApiHelper.JsonDeserialize<Models.TransactionHistoryServiceProvider>("\"credit\"");
            List<Models.TransactionHistoryServiceProvider> serviceProviders = ApiHelper.JsonDeserialize<List<Models.TransactionHistoryServiceProvider>>("[\"credit\",\"paidy\"]");
            string gatewayTransactionId = "gw-txn-00123456";
            List<Models.BankTransferPaymentStatus> bankTransferPaymentStatuses = ApiHelper.JsonDeserialize<List<Models.BankTransferPaymentStatus>>("[\"exact\"]");
            string bankTransferLatestDepositDateFrom = "2026-04-01T00:00:00Z";
            string bankTransferLatestDepositDateTo = "2026-04-30T23:59:59.999Z";
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.TransactionHistoryList> result = null;
            try
            {
                result = await this.controller.ListTransactionHistoryAsync(mode, shortId, from, to, status, type, search, email, id, metadata, cardExp, cardLastFour, cardholder, cardBrand, brand, brands, currency, serviceProvider, serviceProviders, gatewayTransactionId, bankTransferPaymentStatuses, bankTransferLatestDepositDateFrom, bankTransferLatestDepositDateTo, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"resource_id\":\"11ef0000-0000-4000-8000-000000000070\",\"charge_id\":null,\"amount\":1000,\"currency\":\"JPY\",\"amount_formatted\":1000,\"type\":\"charge\",\"status\":\"successful\",\"metadata\":{},\"created_on\":\"2024-05-01T12:34:56.789Z\",\"mode\":\"test\",\"merchant_name\":\"Test merchant\",\"store_name\":\"Test store\",\"payment_type\":\"card\",\"user_data\":{\"type\":\"charge\",\"cardholder_name\":\"Some Guy\",\"cardholder_email_address\":\"test4@univapay.com\",\"brand\":\"visa\",\"gateway\":\"test\",\"service_provider\":\"credit\",\"refunds\":[{\"refund_id\":\"11ef0000-0000-4000-8000-000000000010\",\"amount\":500,\"currency\":\"JPY\",\"amount_formatted\":500,\"status\":\"successful\"}]},\"bank_transfer_payment_status\":null,\"bank_transfer_latest_deposit_date\":null,\"mcp_token_id\":null,\"charge_type\":\"normal\"},{\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"resource_id\":\"11ef0000-0000-4000-8000-000000000010\",\"charge_id\":\"11ef0000-0000-4000-8000-000000000070\",\"amount\":500,\"currency\":\"JPY\",\"amount_formatted\":500,\"type\":\"refund\",\"status\":\"successful\",\"metadata\":{},\"created_on\":\"2024-05-01T13:00:00.000000Z\",\"mode\":\"test\",\"merchant_name\":\"Test merchant\",\"store_name\":\"Test store\",\"payment_type\":\"card\",\"user_data\":{\"type\":\"refund\",\"reason\":\"customer_request\"},\"bank_transfer_payment_status\":null,\"bank_transfer_latest_deposit_date\":null,\"mcp_token_id\":null,\"charge_type\":null}],\"has_more\":false,\"total_hits\":2}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds for a single store, combining both resource types into a single unified row shape..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListStoreTransactionHistory()
        {
            // Parameters for the API call
            Guid storeId = Guid.Parse("0cab399b-5621-425b-993b-f8507eba1e78");
            Models.TransactionHistoryMode mode = ApiHelper.JsonDeserialize<Models.TransactionHistoryMode>("\"test\"");
            string shortId = "8bfc29";
            string from = "2026-04-01T00:00:00Z";
            string to = "2026-04-30T23:59:59.999Z";
            Models.TransactionHistoryStatus status = ApiHelper.JsonDeserialize<Models.TransactionHistoryStatus>("\"successful\"");
            Models.TransactionHistoryType type = ApiHelper.JsonDeserialize<Models.TransactionHistoryType>("\"charge\"");
            string search = "Taro Yamada";
            string email = "user@example.com";
            Guid? id = Guid.Parse("11ef0000-0000-4000-8000-000000000070");
            string metadata = "order_id: 12345";
            string cardExp = "2026-04";
            string cardLastFour = "4242";
            string cardholder = "TARO YAMADA";
            List<string> cardBrand = ApiHelper.JsonDeserialize<List<string>>("[\"visa\"]");
            List<string> brand = ApiHelper.JsonDeserialize<List<string>>("[\"visa\"]");
            List<string> brands = ApiHelper.JsonDeserialize<List<string>>("[\"visa\",\"jcb\"]");
            string currency = "JPY";
            Models.TransactionHistoryServiceProvider serviceProvider = ApiHelper.JsonDeserialize<Models.TransactionHistoryServiceProvider>("\"credit\"");
            List<Models.TransactionHistoryServiceProvider> serviceProviders = ApiHelper.JsonDeserialize<List<Models.TransactionHistoryServiceProvider>>("[\"credit\",\"paidy\"]");
            string gatewayTransactionId = "gw-txn-00123456";
            List<Models.BankTransferPaymentStatus> bankTransferPaymentStatuses = ApiHelper.JsonDeserialize<List<Models.BankTransferPaymentStatus>>("[\"exact\"]");
            string bankTransferLatestDepositDateFrom = "2026-04-01T00:00:00Z";
            string bankTransferLatestDepositDateTo = "2026-04-30T23:59:59.999Z";
            int? limit = 10;
            Guid? cursor = Guid.Parse("3541d4fa-596d-428e-8a36-f274e1b3d505");
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");

            // Perform API call
            ApiResponse<Models.TransactionHistoryList> result = null;
            try
            {
                result = await this.controller.ListStoreTransactionHistoryAsync(storeId, mode, shortId, from, to, status, type, search, email, id, metadata, cardExp, cardLastFour, cardholder, cardBrand, brand, brands, currency, serviceProvider, serviceProviders, gatewayTransactionId, bankTransferPaymentStatuses, bankTransferLatestDepositDateFrom, bankTransferLatestDepositDateTo, limit, cursor, cursorDirection);
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
                    "{\"items\":[{\"store_id\":\"11edf541-c42d-653c-8c3d-dfe0a55f95c0\",\"resource_id\":\"11ef0000-0000-4000-8000-000000000072\",\"charge_id\":null,\"amount\":2500,\"currency\":\"JPY\",\"amount_formatted\":2500,\"type\":\"charge\",\"status\":\"awaiting\",\"metadata\":{},\"created_on\":\"2024-05-03T10:00:00.000000Z\",\"mode\":\"live\",\"merchant_name\":\"Test merchant\",\"store_name\":\"Test store\",\"payment_type\":\"bank_transfer\",\"user_data\":{\"type\":\"charge\",\"cardholder_email_address\":\"test_bank_transfer@test.com\",\"brand\":\"aozora_bank\",\"gateway\":\"aozora_bank\",\"service_provider\":\"bank_transfer\",\"refunds\":[]},\"bank_transfer_payment_status\":\"unpaid\",\"bank_transfer_latest_deposit_date\":null,\"mcp_token_id\":null,\"charge_type\":\"normal\"}],\"has_more\":false,\"total_hits\":1}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}