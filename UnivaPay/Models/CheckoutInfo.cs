// <copyright file="CheckoutInfo.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// CheckoutInfo.
    /// </summary>
    public class CheckoutInfo
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        private string paidyPublicKey;
        private string logoImage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "paidy_public_key", false },
            { "logo_image", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutInfo"/> class.
        /// </summary>
        public CheckoutInfo()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutInfo"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="recurringTokenPrivilege">recurring_token_privilege.</param>
        /// <param name="name">name.</param>
        /// <param name="cardConfiguration">card_configuration.</param>
        /// <param name="subscriptionConfiguration">subscription_configuration.</param>
        /// <param name="installmentsConfiguration">installments_configuration.</param>
        /// <param name="subscriptionPlanConfiguration">subscription_plan_configuration.</param>
        /// <param name="checkoutConfiguration">checkout_configuration.</param>
        /// <param name="qrScanConfiguration">qr_scan_configuration.</param>
        /// <param name="convenienceConfiguration">convenience_configuration.</param>
        /// <param name="paidyConfiguration">paidy_configuration.</param>
        /// <param name="paidyPublicKey">paidy_public_key.</param>
        /// <param name="logoImage">logo_image.</param>
        /// <param name="theme">theme.</param>
        /// <param name="recurringCardChargeCvvConfirmation">recurring_card_charge_cvv_confirmation.</param>
        /// <param name="onlineConfiguration">online_configuration.</param>
        /// <param name="bankTransferConfiguration">bank_transfer_configuration.</param>
        /// <param name="supportedBrands">supported_brands.</param>
        public CheckoutInfo(
            Models.CheckoutMode? mode = null,
            Models.CheckoutRecurringTokenPrivilege? recurringTokenPrivilege = null,
            string name = null,
            Models.CheckoutCardConfiguration cardConfiguration = null,
            Models.CheckoutSubscriptionConfiguration subscriptionConfiguration = null,
            Models.CheckoutInstallmentsConfiguration installmentsConfiguration = null,
            Models.CheckoutSubscriptionPlanConfiguration subscriptionPlanConfiguration = null,
            Models.CheckoutEcConfiguration checkoutConfiguration = null,
            Models.CheckoutQrScanConfiguration qrScanConfiguration = null,
            Models.CheckoutConvenienceConfiguration convenienceConfiguration = null,
            Models.CheckoutPaidyConfiguration paidyConfiguration = null,
            string paidyPublicKey = null,
            string logoImage = null,
            Models.CheckoutTheme theme = null,
            Models.RecurringCvvConfirmation recurringCardChargeCvvConfirmation = null,
            Models.CheckoutOnlineConfiguration onlineConfiguration = null,
            Models.CheckoutBankTransferConfiguration bankTransferConfiguration = null,
            List<Models.CheckoutSupportedBrand> supportedBrands = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Mode = mode;
            this.RecurringTokenPrivilege = recurringTokenPrivilege;
            this.Name = name;
            this.CardConfiguration = cardConfiguration;
            this.SubscriptionConfiguration = subscriptionConfiguration;
            this.InstallmentsConfiguration = installmentsConfiguration;
            this.SubscriptionPlanConfiguration = subscriptionPlanConfiguration;
            this.CheckoutConfiguration = checkoutConfiguration;
            this.QrScanConfiguration = qrScanConfiguration;
            this.ConvenienceConfiguration = convenienceConfiguration;
            this.PaidyConfiguration = paidyConfiguration;

            if (paidyPublicKey != null)
            {
                this.PaidyPublicKey = paidyPublicKey;
            }

            if (logoImage != null)
            {
                this.LogoImage = logoImage;
            }
            this.Theme = theme;
            this.RecurringCardChargeCvvConfirmation = recurringCardChargeCvvConfirmation;
            this.OnlineConfiguration = onlineConfiguration;
            this.BankTransferConfiguration = bankTransferConfiguration;
            this.SupportedBrands = supportedBrands;
        }

        /// <summary>
        /// Store processing mode reflected in the checkout configuration: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutMode? Mode { get; set; }

        /// <summary>
        /// Level of recurring-charge privilege granted to transaction tokens created under this store: `none` disallows recurring use, `bounded` allows a limited number of recurring charges, and `infinite` allows unlimited recurring charges.
        /// </summary>
        [JsonProperty("recurring_token_privilege", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutRecurringTokenPrivilege? RecurringTokenPrivilege { get; set; }

        /// <summary>
        /// Store display name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Card payment settings applied to checkout.
        /// </summary>
        [JsonProperty("card_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutCardConfiguration CardConfiguration { get; set; }

        /// <summary>
        /// Univapay-hosted subscription feature toggle.
        /// </summary>
        [JsonProperty("subscription_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutSubscriptionConfiguration SubscriptionConfiguration { get; set; }

        /// <summary>
        /// Installment plan configuration applied to checkout.
        /// </summary>
        [JsonProperty("installments_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutInstallmentsConfiguration InstallmentsConfiguration { get; set; }

        /// <summary>
        /// Univapay-side subscription plan configuration applied to checkout.
        /// </summary>
        [JsonProperty("subscription_plan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutSubscriptionPlanConfiguration SubscriptionPlanConfiguration { get; set; }

        /// <summary>
        /// EC checkout feature toggles for hosted email receipts and product line items.
        /// </summary>
        [JsonProperty("checkout_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutEcConfiguration CheckoutConfiguration { get; set; }

        /// <summary>
        /// QR-scan (CPM) payment settings applied to checkout.
        /// </summary>
        [JsonProperty("qr_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutQrScanConfiguration QrScanConfiguration { get; set; }

        /// <summary>
        /// Convenience-store (konbini) payment settings applied to checkout.
        /// </summary>
        [JsonProperty("convenience_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutConvenienceConfiguration ConvenienceConfiguration { get; set; }

        /// <summary>
        /// Paidy payment feature toggle.
        /// </summary>
        [JsonProperty("paidy_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutPaidyConfiguration PaidyConfiguration { get; set; }

        /// <summary>
        /// Public key used to initialize the Paidy widget. `null` when Paidy is not configured for this store.
        /// </summary>
        [JsonProperty("paidy_public_key")]
        public string PaidyPublicKey
        {
            get
            {
                return this.paidyPublicKey;
            }

            set
            {
                this.shouldSerialize["paidy_public_key"] = true;
                this.paidyPublicKey = value;
            }
        }

        /// <summary>
        /// URL of the store's checkout logo image. `null` when no logo is configured. Note: this response field is `logo_image`, but the corresponding store-configuration update field is `logo_url` — the two names do not round-trip automatically.
        /// </summary>
        [JsonProperty("logo_image")]
        public string LogoImage
        {
            get
            {
                return this.logoImage;
            }

            set
            {
                this.shouldSerialize["logo_image"] = true;
                this.logoImage = value;
            }
        }

        /// <summary>
        /// Widget theme applied to checkout.
        /// </summary>
        [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutTheme Theme { get; set; }

        /// <summary>
        /// CVV re-confirmation policy applied to recurring card charges (subscriptions and tokens with recurring privilege).
        /// </summary>
        [JsonProperty("recurring_card_charge_cvv_confirmation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringCvvConfirmation RecurringCardChargeCvvConfirmation { get; set; }

        /// <summary>
        /// Online redirect/wallet payment feature toggle.
        /// </summary>
        [JsonProperty("online_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutOnlineConfiguration OnlineConfiguration { get; set; }

        /// <summary>
        /// Bank transfer (振込) payment settings applied to checkout.
        /// </summary>
        [JsonProperty("bank_transfer_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutBankTransferConfiguration BankTransferConfiguration { get; set; }

        /// <summary>
        /// Feature support and capability flags for every payment-type / brand combination the store can accept.
        /// </summary>
        [JsonProperty("supported_brands", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CheckoutSupportedBrand> SupportedBrands { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutInfo : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPaidyPublicKey()
        {
            this.shouldSerialize["paidy_public_key"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetLogoImage()
        {
            this.shouldSerialize["logo_image"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidyPublicKey()
        {
            return this.shouldSerialize["paidy_public_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLogoImage()
        {
            return this.shouldSerialize["logo_image"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"RecurringTokenPrivilege = {(this.RecurringTokenPrivilege == null ? "null" : this.RecurringTokenPrivilege.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"CardConfiguration = {(this.CardConfiguration == null ? "null" : this.CardConfiguration.ToString())}");
            toStringOutput.Add($"SubscriptionConfiguration = {(this.SubscriptionConfiguration == null ? "null" : this.SubscriptionConfiguration.ToString())}");
            toStringOutput.Add($"InstallmentsConfiguration = {(this.InstallmentsConfiguration == null ? "null" : this.InstallmentsConfiguration.ToString())}");
            toStringOutput.Add($"SubscriptionPlanConfiguration = {(this.SubscriptionPlanConfiguration == null ? "null" : this.SubscriptionPlanConfiguration.ToString())}");
            toStringOutput.Add($"CheckoutConfiguration = {(this.CheckoutConfiguration == null ? "null" : this.CheckoutConfiguration.ToString())}");
            toStringOutput.Add($"QrScanConfiguration = {(this.QrScanConfiguration == null ? "null" : this.QrScanConfiguration.ToString())}");
            toStringOutput.Add($"ConvenienceConfiguration = {(this.ConvenienceConfiguration == null ? "null" : this.ConvenienceConfiguration.ToString())}");
            toStringOutput.Add($"PaidyConfiguration = {(this.PaidyConfiguration == null ? "null" : this.PaidyConfiguration.ToString())}");
            toStringOutput.Add($"PaidyPublicKey = {this.PaidyPublicKey ?? "null"}");
            toStringOutput.Add($"LogoImage = {this.LogoImage ?? "null"}");
            toStringOutput.Add($"Theme = {(this.Theme == null ? "null" : this.Theme.ToString())}");
            toStringOutput.Add($"RecurringCardChargeCvvConfirmation = {(this.RecurringCardChargeCvvConfirmation == null ? "null" : this.RecurringCardChargeCvvConfirmation.ToString())}");
            toStringOutput.Add($"OnlineConfiguration = {(this.OnlineConfiguration == null ? "null" : this.OnlineConfiguration.ToString())}");
            toStringOutput.Add($"BankTransferConfiguration = {(this.BankTransferConfiguration == null ? "null" : this.BankTransferConfiguration.ToString())}");
            toStringOutput.Add($"SupportedBrands = {(this.SupportedBrands == null ? "null" : $"[{string.Join(", ", this.SupportedBrands)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}