// <copyright file="CheckoutApiTest.cs" company="APIMatic">
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
    /// CheckoutApiTest.
    /// </summary>
    [TestFixture]
    public class CheckoutApiTest : ApiTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CheckoutApi controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CheckoutApi;
        }

        /// <summary>
        /// Returns the merchant's checkout configuration: enabled payment methods and their limits, installment/subscription plan settings, convenience-store and bank-transfer settings, widget theme, and per-brand feature support. Resolved entirely from the bearer credential — takes no parameters..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCheckoutInfo()
        {
            // Perform API call
            ApiResponse<Models.CheckoutInfo> result = null;
            try
            {
                result = await this.controller.GetCheckoutInfoAsync();
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
                    "{\"mode\":\"test\",\"recurring_token_privilege\":\"none\",\"name\":\"Test store\",\"card_configuration\":{\"enabled\":true,\"debit_enabled\":true,\"prepaid_enabled\":true,\"debit_authorization_enabled\":false,\"prepaid_authorization_enabled\":false,\"only_direct_currency\":false,\"forbidden_card_brands\":null,\"allowed_countries_by_ip\":null,\"foreign_cards_allowed\":true,\"fail_on_new_email\":null,\"card_limit\":null,\"allow_empty_cvv\":null,\"allow_direct_token_creation\":true,\"three_ds_required\":false,\"three_ds_address_required\":false,\"three_ds_skip_enabled\":false,\"three_ds_phone_number_required\":true},\"subscription_configuration\":{\"enabled\":true},\"installments_configuration\":{\"enabled\":true,\"card_processor\":{\"revolving\":true,\"fixed_cycle\":true},\"supported_payment_types\":[\"card\"],\"min_charge_amount\":{\"amount\":1000,\"amount_formatted\":1000,\"currency\":\"JPY\"},\"max_payout_period\":\"P2Y\",\"only_with_processor\":true},\"subscription_plan_configuration\":{\"enabled\":true,\"fixed_cycle\":true,\"fixed_cycle_amount\":true,\"supported_payment_types\":[\"card\"],\"min_charge_amount\":null,\"max_payout_period\":null},\"checkout_configuration\":{\"ec_email\":{\"enabled\":false},\"ec_products\":{\"enabled\":false}},\"qr_scan_configuration\":{\"enabled\":true,\"forbidden_qr_scan_gateways\":null},\"convenience_configuration\":{\"enabled\":true,\"expiration\":\"PT720H\",\"expiration_time_shift\":{\"enabled\":false}},\"paidy_configuration\":{\"enabled\":true},\"paidy_public_key\":null,\"logo_image\":null,\"theme\":{\"colors\":{\"main_background\":\"#FFFFFF\",\"secondary_background\":\"#F5F8FC\",\"main_color\":\"#4C5F85\",\"main_text\":\"#FFFFFF\",\"primary_text\":\"#4C5F85\",\"secondary_text\":\"#4C5F85\",\"base_text\":\"#4C5F85\",\"body_background\":\"#FFFFFF\"}},\"recurring_card_charge_cvv_confirmation\":{\"enabled\":false,\"threshold\":null},\"online_configuration\":{\"enabled\":true},\"bank_transfer_configuration\":{\"enabled\":true,\"match_amount\":\"disabled\",\"expiration\":\"PT72H\",\"expiration_time_shift\":{\"enabled\":false},\"virtual_bank_accounts_threshold\":5,\"virtual_bank_accounts_fetch_count\":10,\"default_extension_period\":\"PT168H\",\"maximum_extension_period\":\"PT168H\",\"automatic_extension_enabled\":false,\"charge_request_notification_enabled\":false,\"charge_request_canceled_notification_enabled\":false,\"charge_expired_notification_enabled\":false,\"deposit_received_notification_enabled\":false,\"deposit_insufficient_notification_enabled\":false,\"deposit_exceeded_notification_enabled\":false,\"extension_notification_enabled\":false,\"remind_notification_period\":\"PT168H\",\"remind_notification_enabled\":false},\"supported_brands\":[{\"payment_type\":\"card\",\"brand\":\"visa\",\"card_brand\":\"visa\",\"dynamic_info\":false,\"support_auth_capture\":true,\"requires_full_name\":false,\"requires_cvv\":true,\"countries_allowed\":null,\"supported_currencies\":null,\"cvv_auth\":false,\"installment_capable\":true,\"mcp_capable\":false,\"mcp_only\":false},{\"payment_type\":\"qr_merchant\",\"brand\":\"alipay_merchant_qr\",\"qr_brand\":\"alipay_merchant_qr\",\"dynamic_info\":false,\"support_auth_capture\":false,\"requires_full_name\":false,\"requires_cvv\":false,\"countries_allowed\":null,\"supported_currencies\":null,\"cvv_auth\":false,\"installment_capable\":false,\"mcp_capable\":false,\"mcp_only\":false}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}