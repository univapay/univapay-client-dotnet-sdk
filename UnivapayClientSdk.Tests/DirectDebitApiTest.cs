// <copyright file="DirectDebitApiTest.cs" company="APIMatic">
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
    /// DirectDebitApiTest.
    /// </summary>
    [TestFixture]
    public class DirectDebitApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private DirectDebitApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.DirectDebitApi;
        }

        /// <summary>
        /// Retrieves the merchant's direct debit configuration — whether direct debit is enabled and which monthly debit cycle applies..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDirectDebitConfiguration()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");

            // Perform API call
            ApiResponse<Models.DirectDebitMerchantConfiguration> result = null;
            try
            {
                result = await this.controller.GetDirectDebitConfigurationAsync(merchantId);
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
                    "{\"legacy_id\":\"1283794\",\"enabled\":true,\"debit_date\":\"fourteen\",\"consignor_code\":\"135456\",\"classifier\":\"99\",\"signature\":\"モモサン\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves which direct debit email notifications the merchant has opted into..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDirectDebitNotificationConfiguration()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");

            // Perform API call
            ApiResponse<Models.DirectDebitNotificationConfiguration> result = null;
            try
            {
                result = await this.controller.GetDirectDebitNotificationConfigurationAsync(merchantId);
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
                    "{\"notify_deadline_mailing\":true,\"notify_deadline_debit\":true,\"notify_debit_update\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves the key dates for the debit cycle currently in progress, based on the merchant's configured cycle. Compare `merchant_bank_transfer_upload_deadline` against today to decide whether transfers can still be registered or edited this month..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDirectDebitCurrentSchedule()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");

            // Perform API call
            ApiResponse<Models.DirectDebitSchedule> result = null;
            try
            {
                result = await this.controller.GetDirectDebitCurrentScheduleAsync(merchantId);
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
                    "{\"merchant_bank_account_transfer_date\":\"2026-03-14\",\"merchant_bank_account_registration_deadline\":\"2026-02-20\",\"merchant_bank_transfer_upload_deadline\":\"2026-03-04\",\"platform_result_registration_date\":\"2026-03-24\",\"platform_scheduled_payout\":\"2026-03-31\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists the consumer bank accounts registered for direct debit under this merchant..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListDirectDebitBankAccounts()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            int? limit = 10;
            string cursor = "1098116";
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string userNumber = "SD02688328";
            string bankAccountId = "1098116";
            string bankCode = "0012";
            string bankName = "ﾗｸﾃﾝｷﾞﾝｺｳ";
            string branchCode = "120";
            Models.DirectDebitBankAccountType bankAccountType = ApiHelper.JsonDeserialize<Models.DirectDebitBankAccountType>("\"regular\"");
            string bankAccountNumber = "1234567";
            string bankAccountName = "ﾀﾅｶﾕﾐｺ";
            Models.DirectDebitRegistrationOrigin registrationOrigin = ApiHelper.JsonDeserialize<Models.DirectDebitRegistrationOrigin>("\"merchant_console\"");
            Models.DirectDebitBankAccountStatus bankAccountStatus = ApiHelper.JsonDeserialize<Models.DirectDebitBankAccountStatus>("\"active\"");
            string from = "2026-04-01T00:00:00.000Z";
            string to = "2026-04-30T23:59:59.999Z";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccountList> result = null;
            try
            {
                result = await this.controller.ListDirectDebitBankAccountsAsync(merchantId, limit, cursor, cursorDirection, userNumber, bankAccountId, bankCode, bankName, branchCode, bankAccountType, bankAccountNumber, bankAccountName, registrationOrigin, bankAccountStatus, from, to);
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
                    "{\"items\":[{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"active\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"},{\"id\":\"1098117\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688329\",\"bank_code\":\"0009\",\"bank_name\":\"ﾐﾂｲｽﾐﾄﾓ\",\"branch_code\":\"221\",\"bank_account_type\":\"current\",\"bank_account_name\":\"ｽｽﾞｷﾀﾛｳ\",\"bank_account_number\":\"7654321\",\"registration_origin\":\"anywhere\",\"status\":\"inactive\",\"created_on\":\"2026-04-10T09:12:04.000Z\",\"updated_on\":\"2026-04-12T11:03:41.000Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Registers a consumer bank account for direct debit. The account is created and then verified against the bank, so it starts out unusable — poll its `status` until it becomes `active` (or `registration_failed`) before scheduling transfers against it..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateDirectDebitBankAccount()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            Models.DirectDebitBankAccountCreateRequest body = ApiHelper.JsonDeserialize<Models.DirectDebitBankAccountCreateRequest>("{\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccount> result = null;
            try
            {
                result = await this.controller.CreateDirectDebitBankAccountAsync(merchantId, body, idempotencyKey);
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
                    "{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"active\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a single registered bank account, including its current verification status..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDirectDebitBankAccount()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankAccountId = "1098116";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccount> result = null;
            try
            {
                result = await this.controller.GetDirectDebitBankAccountAsync(merchantId, bankAccountId);
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
                    "{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"active\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Updates a registered bank account. Changing bank details re-triggers verification with the bank. Transfers already registered keep the details they were created with..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateDirectDebitBankAccount()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankAccountId = "1098116";
            Models.DirectDebitBankAccountUpdateRequest body = ApiHelper.JsonDeserialize<Models.DirectDebitBankAccountUpdateRequest>("{\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\"}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccount> result = null;
            try
            {
                result = await this.controller.UpdateDirectDebitBankAccountAsync(merchantId, bankAccountId, body, idempotencyKey);
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
                    "{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"active\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Deactivates a bank account so no further transfers can be registered against it. The record is retained (status becomes `inactive`) rather than deleted, and can be re-enabled later..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeactivateDirectDebitBankAccount()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankAccountId = "1098116";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccount> result = null;
            try
            {
                result = await this.controller.DeactivateDirectDebitBankAccountAsync(merchantId, bankAccountId);
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
                    "{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"inactive\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-14T02:11:07.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Returns a deactivated bank account to `active` so transfers can be registered against it again. The account must currently be `inactive`..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestReenableDirectDebitBankAccount()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankAccountId = "1098116";
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.DirectDebitBankAccount> result = null;
            try
            {
                result = await this.controller.ReenableDirectDebitBankAccountAsync(merchantId, bankAccountId, idempotencyKey);
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
                    "{\"id\":\"1098116\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"registration_origin\":\"merchant_console\",\"status\":\"active\",\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Schedules a pull of funds from an active bank account. The transfer is queued for the merchant's next debit cycle and stays editable until that cycle's upload deadline passes..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateDirectDebitBankTransfer()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankAccountId = "1098116";
            Models.DirectDebitBankTransferCreateRequest body = ApiHelper.JsonDeserialize<Models.DirectDebitBankTransferCreateRequest>("{\"amount\":1000}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.DirectDebitBankTransfer> result = null;
            try
            {
                result = await this.controller.CreateDirectDebitBankTransferAsync(merchantId, bankAccountId, body, idempotencyKey);
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
                    "{\"id\":\"2594976\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"bank_account_id\":\"1098116\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"amount\":1000,\"debit_date\":\"fourteen\",\"calculated_debit_date\":\"2026-03-14\",\"lock\":\"unlocked\",\"status\":\"awaiting\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Lists the direct debit transfers registered under this merchant, across all bank accounts..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestListDirectDebitBankTransfers()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            int? limit = 10;
            string cursor = "1098116";
            Models.CursorDirectionQuery cursorDirection = ApiHelper.JsonDeserialize<Models.CursorDirectionQuery>("\"desc\"");
            string bankTransferId = "2594976";
            string bankTransferStart = "2026-01";
            string bankTransferEnd = "2026-03";
            Models.DirectDebitDebitDate debitDate = ApiHelper.JsonDeserialize<Models.DirectDebitDebitDate>("\"fourteen\"");
            string userNumber = "SD02688328";
            string bankAccountNumber = "1234567";
            string bankAccountName = "ﾀﾅｶﾕﾐｺ";
            Models.DirectDebitBankTransferLock lockStatus = ApiHelper.JsonDeserialize<Models.DirectDebitBankTransferLock>("\"unlocked\"");
            Models.DirectDebitBankTransferStatus bankTransferStatus = ApiHelper.JsonDeserialize<Models.DirectDebitBankTransferStatus>("\"awaiting\"");

            // Perform API call
            ApiResponse<Models.DirectDebitBankTransferList> result = null;
            try
            {
                result = await this.controller.ListDirectDebitBankTransfersAsync(merchantId, limit, cursor, cursorDirection, bankTransferId, bankTransferStart, bankTransferEnd, debitDate, userNumber, bankAccountNumber, bankAccountName, lockStatus, bankTransferStatus);
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
                    "{\"items\":[{\"id\":\"2594976\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"bank_account_id\":\"1098116\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"amount\":1000,\"debit_date\":\"fourteen\",\"calculated_debit_date\":\"2026-03-14\",\"lock\":\"unlocked\",\"status\":\"awaiting\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"},{\"id\":\"2594977\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"bank_account_id\":\"1098117\",\"user_number\":\"SD02688329\",\"bank_code\":\"0009\",\"bank_name\":\"ﾐﾂｲｽﾐﾄﾓ\",\"branch_code\":\"221\",\"bank_account_type\":\"current\",\"bank_account_name\":\"ｽｽﾞｷﾀﾛｳ\",\"bank_account_number\":\"7654321\",\"amount\":1850,\"debit_date\":\"twenty_seven\",\"calculated_debit_date\":\"2026-03-27\",\"lock\":\"locked\",\"status\":\"failed\",\"error\":\"insufficient_funds\",\"created_on\":\"2026-04-10T09:12:04.000Z\",\"updated_on\":\"2026-04-12T11:03:41.000Z\"}],\"has_more\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Retrieves a single transfer. Poll this after the cycle's result registration date to pick up the outcome and, on failure, the bank's reason..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDirectDebitBankTransfer()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankTransferId = "2594976";

            // Perform API call
            ApiResponse<Models.DirectDebitBankTransfer> result = null;
            try
            {
                result = await this.controller.GetDirectDebitBankTransferAsync(merchantId, bankTransferId);
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
                    "{\"id\":\"2594976\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"bank_account_id\":\"1098116\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"amount\":1000,\"debit_date\":\"fourteen\",\"calculated_debit_date\":\"2026-03-14\",\"lock\":\"unlocked\",\"status\":\"awaiting\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Changes a scheduled transfer's amount. Only permitted while the transfer is `unlocked` — once its cycle's upload deadline passes the amount is fixed..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateDirectDebitBankTransfer()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankTransferId = "2594976";
            Models.DirectDebitBankTransferPatchRequest body = ApiHelper.JsonDeserialize<Models.DirectDebitBankTransferPatchRequest>("{\"amount\":1850}");
            string idempotencyKey = "f64be872-353d-4c3c-84cb-3dc617fe89f7";

            // Perform API call
            ApiResponse<Models.DirectDebitBankTransfer> result = null;
            try
            {
                result = await this.controller.UpdateDirectDebitBankTransferAsync(merchantId, bankTransferId, body, idempotencyKey);
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
                    "{\"id\":\"2594976\",\"legacy_store_id\":\"1283794\",\"merchant_id\":\"01234567-89ab-cdef-0123-456789abcdef\",\"bank_account_id\":\"1098116\",\"user_number\":\"SD02688328\",\"bank_code\":\"0012\",\"bank_name\":\"ﾗｸﾃﾝｷﾞﾝｺｳ\",\"branch_code\":\"120\",\"bank_account_type\":\"regular\",\"bank_account_name\":\"ﾀﾅｶﾕﾐｺ\",\"bank_account_number\":\"1234567\",\"amount\":1000,\"debit_date\":\"fourteen\",\"calculated_debit_date\":\"2026-03-14\",\"lock\":\"unlocked\",\"status\":\"awaiting\",\"error\":null,\"created_on\":\"2026-04-09T07:35:50.000Z\",\"updated_on\":\"2026-04-09T07:35:50.000Z\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Cancels a scheduled transfer so it is not sent to the bank. Only permitted while the transfer is `unlocked`..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteDirectDebitBankTransfer()
        {
            // Parameters for the API call
            Guid merchantId = Guid.Parse("01234567-89ab-cdef-0123-456789abcdef");
            string bankTransferId = "2594976";

            // Perform API call
            try
            {
                await this.controller.DeleteDirectDebitBankTransferAsync(merchantId, bankTransferId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");
        }
    }
}