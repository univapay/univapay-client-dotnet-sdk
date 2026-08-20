// <copyright file="CheckoutSupportedBrand.cs" company="APIMatic">
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
    /// CheckoutSupportedBrand.
    /// </summary>
    public class CheckoutSupportedBrand
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

        private List<string> countriesAllowed;
        private List<string> supportedCurrencies;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "countries_allowed", false },
            { "supported_currencies", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSupportedBrand"/> class.
        /// </summary>
        public CheckoutSupportedBrand()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSupportedBrand"/> class.
        /// </summary>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="brand">brand.</param>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="qrBrand">qr_brand.</param>
        /// <param name="onlineBrand">online_brand.</param>
        /// <param name="dynamicInfo">dynamic_info.</param>
        /// <param name="supportAuthCapture">support_auth_capture.</param>
        /// <param name="requiresFullName">requires_full_name.</param>
        /// <param name="requiresCvv">requires_cvv.</param>
        /// <param name="countriesAllowed">countries_allowed.</param>
        /// <param name="supportedCurrencies">supported_currencies.</param>
        /// <param name="cvvAuth">cvv_auth.</param>
        /// <param name="installmentCapable">installment_capable.</param>
        /// <param name="mcpCapable">mcp_capable.</param>
        /// <param name="mcpOnly">mcp_only.</param>
        public CheckoutSupportedBrand(
            Models.CheckoutPaymentType? paymentType = null,
            string brand = null,
            string cardBrand = null,
            string qrBrand = null,
            string onlineBrand = null,
            bool? dynamicInfo = null,
            bool? supportAuthCapture = null,
            bool? requiresFullName = null,
            bool? requiresCvv = null,
            List<string> countriesAllowed = null,
            List<string> supportedCurrencies = null,
            bool? cvvAuth = null,
            bool? installmentCapable = null,
            bool? mcpCapable = null,
            bool? mcpOnly = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PaymentType = paymentType;
            this.Brand = brand;
            this.CardBrand = cardBrand;
            this.QrBrand = qrBrand;
            this.OnlineBrand = onlineBrand;
            this.DynamicInfo = dynamicInfo;
            this.SupportAuthCapture = supportAuthCapture;
            this.RequiresFullName = requiresFullName;
            this.RequiresCvv = requiresCvv;

            if (countriesAllowed != null)
            {
                this.CountriesAllowed = countriesAllowed;
            }

            if (supportedCurrencies != null)
            {
                this.SupportedCurrencies = supportedCurrencies;
            }
            this.CvvAuth = cvvAuth;
            this.InstallmentCapable = installmentCapable;
            this.McpCapable = mcpCapable;
            this.McpOnly = mcpOnly;
        }

        /// <summary>
        /// Payment type identifier used throughout the checkout configuration.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutPaymentType? PaymentType { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Brand identifier for `payment_type`. For `card` and `apple_pay`, one of the common `CardBrand` values (`visa`, `mastercard`, `american_express`, `maestro`, `discover`, `jcb`, `diners_club`, `private_label`, `unionpay`) or an `unmapped_<raw value>` fallback. For `qr_scan`, a QR-CPM brand (e.g. `pay_pay`, `we_chat`, `qq`, `line_pay`, `au_pay`, `alipay_china`). For `qr_merchant`, a QR-MPM brand (e.g. `rakuten_pay_merchant`, `alipay_merchant_qr`, `pay_pay_merchant`, `d_barai_mpm`, `we_chat_mpm`). For `online`, an online-redirect brand (e.g. `alipay_online`, `pay_pay_online`, `we_chat_online`, `d_barai_online`, `kakaopay`). For `konbini`, a convenience-store brand (e.g. `seven_eleven`, `family_mart`, `lawson`). For `paidy` and `bank_transfer`, the payment type's own identifier. The full brand catalogue is large and gateway-dependent — treat this as an open string, not a fixed set.
        /// ]]>
        /// </summary>
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>
        /// Legacy alias of `brand`. Present only when `payment_type` is `card` or `apple_pay`.
        /// </summary>
        [JsonProperty("card_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Legacy alias of `brand`. Present only when `payment_type` is `qr_merchant`.
        /// </summary>
        [JsonProperty("qr_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string QrBrand { get; set; }

        /// <summary>
        /// Legacy alias of `brand`. Present only when `payment_type` is `online`.
        /// </summary>
        [JsonProperty("online_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string OnlineBrand { get; set; }

        /// <summary>
        /// Whether the brand's supported feature set is resolved dynamically.
        /// </summary>
        [JsonProperty("dynamic_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicInfo { get; set; }

        /// <summary>
        /// Whether the brand supports separate authorization and capture.
        /// </summary>
        [JsonProperty("support_auth_capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAuthCapture { get; set; }

        /// <summary>
        /// Whether the brand requires the cardholder's full name.
        /// </summary>
        [JsonProperty("requires_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiresFullName { get; set; }

        /// <summary>
        /// Whether the brand requires a CVV.
        /// </summary>
        [JsonProperty("requires_cvv", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequiresCvv { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country codes allowed for this brand. `null` when unrestricted.
        /// </summary>
        [JsonProperty("countries_allowed")]
        public List<string> CountriesAllowed
        {
            get
            {
                return this.countriesAllowed;
            }

            set
            {
                this.shouldSerialize["countries_allowed"] = true;
                this.countriesAllowed = value;
            }
        }

        /// <summary>
        /// ISO-4217 currency codes supported by this brand. `null` when unrestricted.
        /// </summary>
        [JsonProperty("supported_currencies")]
        public List<string> SupportedCurrencies
        {
            get
            {
                return this.supportedCurrencies;
            }

            set
            {
                this.shouldSerialize["supported_currencies"] = true;
                this.supportedCurrencies = value;
            }
        }

        /// <summary>
        /// Whether this brand supports CVV-only authorization.
        /// </summary>
        [JsonProperty("cvv_auth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CvvAuth { get; set; }

        /// <summary>
        /// Whether this brand supports installment plans.
        /// </summary>
        [JsonProperty("installment_capable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstallmentCapable { get; set; }

        /// <summary>
        /// Whether this brand supports multi-currency pricing.
        /// </summary>
        [JsonProperty("mcp_capable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? McpCapable { get; set; }

        /// <summary>
        /// Whether this brand is only available through multi-currency pricing.
        /// </summary>
        [JsonProperty("mcp_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? McpOnly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutSupportedBrand : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCountriesAllowed()
        {
            this.shouldSerialize["countries_allowed"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSupportedCurrencies()
        {
            this.shouldSerialize["supported_currencies"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountriesAllowed()
        {
            return this.shouldSerialize["countries_allowed"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSupportedCurrencies()
        {
            return this.shouldSerialize["supported_currencies"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"CardBrand = {this.CardBrand ?? "null"}");
            toStringOutput.Add($"QrBrand = {this.QrBrand ?? "null"}");
            toStringOutput.Add($"OnlineBrand = {this.OnlineBrand ?? "null"}");
            toStringOutput.Add($"DynamicInfo = {(this.DynamicInfo == null ? "null" : this.DynamicInfo.ToString())}");
            toStringOutput.Add($"SupportAuthCapture = {(this.SupportAuthCapture == null ? "null" : this.SupportAuthCapture.ToString())}");
            toStringOutput.Add($"RequiresFullName = {(this.RequiresFullName == null ? "null" : this.RequiresFullName.ToString())}");
            toStringOutput.Add($"RequiresCvv = {(this.RequiresCvv == null ? "null" : this.RequiresCvv.ToString())}");
            toStringOutput.Add($"CountriesAllowed = {(this.CountriesAllowed == null ? "null" : $"[{string.Join(", ", this.CountriesAllowed)} ]")}");
            toStringOutput.Add($"SupportedCurrencies = {(this.SupportedCurrencies == null ? "null" : $"[{string.Join(", ", this.SupportedCurrencies)} ]")}");
            toStringOutput.Add($"CvvAuth = {(this.CvvAuth == null ? "null" : this.CvvAuth.ToString())}");
            toStringOutput.Add($"InstallmentCapable = {(this.InstallmentCapable == null ? "null" : this.InstallmentCapable.ToString())}");
            toStringOutput.Add($"McpCapable = {(this.McpCapable == null ? "null" : this.McpCapable.ToString())}");
            toStringOutput.Add($"McpOnly = {(this.McpOnly == null ? "null" : this.McpOnly.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}