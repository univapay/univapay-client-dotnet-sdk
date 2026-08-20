// <copyright file="CheckoutCardConfiguration.cs" company="APIMatic">
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
    /// CheckoutCardConfiguration.
    /// </summary>
    public class CheckoutCardConfiguration
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

        private List<string> forbiddenCardBrands;
        private List<string> allowedCountriesByIp;
        private bool? failOnNewEmail;
        private Models.CardLimit cardLimit;
        private bool? allowEmptyCvv;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "forbidden_card_brands", false },
            { "allowed_countries_by_ip", false },
            { "fail_on_new_email", false },
            { "card_limit", false },
            { "allow_empty_cvv", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCardConfiguration"/> class.
        /// </summary>
        public CheckoutCardConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutCardConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="debitEnabled">debit_enabled.</param>
        /// <param name="prepaidEnabled">prepaid_enabled.</param>
        /// <param name="debitAuthorizationEnabled">debit_authorization_enabled.</param>
        /// <param name="prepaidAuthorizationEnabled">prepaid_authorization_enabled.</param>
        /// <param name="onlyDirectCurrency">only_direct_currency.</param>
        /// <param name="forbiddenCardBrands">forbidden_card_brands.</param>
        /// <param name="allowedCountriesByIp">allowed_countries_by_ip.</param>
        /// <param name="foreignCardsAllowed">foreign_cards_allowed.</param>
        /// <param name="failOnNewEmail">fail_on_new_email.</param>
        /// <param name="cardLimit">card_limit.</param>
        /// <param name="allowEmptyCvv">allow_empty_cvv.</param>
        /// <param name="allowDirectTokenCreation">allow_direct_token_creation.</param>
        /// <param name="threeDsRequired">three_ds_required.</param>
        /// <param name="threeDsAddressRequired">three_ds_address_required.</param>
        /// <param name="threeDsSkipEnabled">three_ds_skip_enabled.</param>
        /// <param name="threeDsPhoneNumberRequired">three_ds_phone_number_required.</param>
        public CheckoutCardConfiguration(
            bool? enabled = null,
            bool? debitEnabled = null,
            bool? prepaidEnabled = null,
            bool? debitAuthorizationEnabled = null,
            bool? prepaidAuthorizationEnabled = null,
            bool? onlyDirectCurrency = null,
            List<string> forbiddenCardBrands = null,
            List<string> allowedCountriesByIp = null,
            bool? foreignCardsAllowed = null,
            bool? failOnNewEmail = null,
            Models.CardLimit cardLimit = null,
            bool? allowEmptyCvv = null,
            bool? allowDirectTokenCreation = null,
            bool? threeDsRequired = null,
            bool? threeDsAddressRequired = null,
            bool? threeDsSkipEnabled = null,
            bool? threeDsPhoneNumberRequired = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Enabled = enabled;
            this.DebitEnabled = debitEnabled;
            this.PrepaidEnabled = prepaidEnabled;
            this.DebitAuthorizationEnabled = debitAuthorizationEnabled;
            this.PrepaidAuthorizationEnabled = prepaidAuthorizationEnabled;
            this.OnlyDirectCurrency = onlyDirectCurrency;

            if (forbiddenCardBrands != null)
            {
                this.ForbiddenCardBrands = forbiddenCardBrands;
            }

            if (allowedCountriesByIp != null)
            {
                this.AllowedCountriesByIp = allowedCountriesByIp;
            }
            this.ForeignCardsAllowed = foreignCardsAllowed;

            if (failOnNewEmail != null)
            {
                this.FailOnNewEmail = failOnNewEmail;
            }

            if (cardLimit != null)
            {
                this.CardLimit = cardLimit;
            }

            if (allowEmptyCvv != null)
            {
                this.AllowEmptyCvv = allowEmptyCvv;
            }
            this.AllowDirectTokenCreation = allowDirectTokenCreation;
            this.ThreeDsRequired = threeDsRequired;
            this.ThreeDsAddressRequired = threeDsAddressRequired;
            this.ThreeDsSkipEnabled = threeDsSkipEnabled;
            this.ThreeDsPhoneNumberRequired = threeDsPhoneNumberRequired;
        }

        /// <summary>
        /// Whether card payments are enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether debit cards are allowed.
        /// </summary>
        [JsonProperty("debit_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DebitEnabled { get; set; }

        /// <summary>
        /// Whether prepaid cards are allowed.
        /// </summary>
        [JsonProperty("prepaid_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrepaidEnabled { get; set; }

        /// <summary>
        /// Whether authorization-only flows are allowed for debit cards.
        /// </summary>
        [JsonProperty("debit_authorization_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DebitAuthorizationEnabled { get; set; }

        /// <summary>
        /// Whether authorization-only flows are allowed for prepaid cards.
        /// </summary>
        [JsonProperty("prepaid_authorization_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrepaidAuthorizationEnabled { get; set; }

        /// <summary>
        /// Whether card processing is restricted to direct-settlement currencies.
        /// </summary>
        [JsonProperty("only_direct_currency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDirectCurrency { get; set; }

        /// <summary>
        /// <![CDATA[
        /// Card brands rejected by merchant policy. Common values include `visa`, `mastercard`, `american_express`, `maestro`, `discover`, `jcb`, `diners_club`, `private_label`, and `unionpay`; gateway-specific brands the platform cannot map appear as `unmapped_<raw value>`. `null` when no brand is forbidden.
        /// ]]>
        /// </summary>
        [JsonProperty("forbidden_card_brands")]
        public List<string> ForbiddenCardBrands
        {
            get
            {
                return this.forbiddenCardBrands;
            }

            set
            {
                this.shouldSerialize["forbidden_card_brands"] = true;
                this.forbiddenCardBrands = value;
            }
        }

        /// <summary>
        /// ISO 3166-1 alpha-2 country codes allowed to originate card payments by IP geolocation. `null` when unrestricted.
        /// </summary>
        [JsonProperty("allowed_countries_by_ip")]
        public List<string> AllowedCountriesByIp
        {
            get
            {
                return this.allowedCountriesByIp;
            }

            set
            {
                this.shouldSerialize["allowed_countries_by_ip"] = true;
                this.allowedCountriesByIp = value;
            }
        }

        /// <summary>
        /// Whether cards issued outside the primary operating country are allowed.
        /// </summary>
        [JsonProperty("foreign_cards_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForeignCardsAllowed { get; set; }

        /// <summary>
        /// Whether to reject card charges from previously unseen customer email addresses. `null` when not configured.
        /// </summary>
        [JsonProperty("fail_on_new_email")]
        public bool? FailOnNewEmail
        {
            get
            {
                return this.failOnNewEmail;
            }

            set
            {
                this.shouldSerialize["fail_on_new_email"] = true;
                this.failOnNewEmail = value;
            }
        }

        /// <summary>
        /// Per-card spending limit. `null` when no limit is configured.
        /// </summary>
        [JsonProperty("card_limit")]
        public Models.CardLimit CardLimit
        {
            get
            {
                return this.cardLimit;
            }

            set
            {
                this.shouldSerialize["card_limit"] = true;
                this.cardLimit = value;
            }
        }

        /// <summary>
        /// Whether card flows may proceed without a CVV. `null` when not configured.
        /// </summary>
        [JsonProperty("allow_empty_cvv")]
        public bool? AllowEmptyCvv
        {
            get
            {
                return this.allowEmptyCvv;
            }

            set
            {
                this.shouldSerialize["allow_empty_cvv"] = true;
                this.allowEmptyCvv = value;
            }
        }

        /// <summary>
        /// Whether direct card token creation is allowed without a hosted capture flow.
        /// </summary>
        [JsonProperty("allow_direct_token_creation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowDirectTokenCreation { get; set; }

        /// <summary>
        /// Whether 3-D Secure is required for eligible card flows.
        /// </summary>
        [JsonProperty("three_ds_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDsRequired { get; set; }

        /// <summary>
        /// Whether billing address data is required when running 3-D Secure.
        /// </summary>
        [JsonProperty("three_ds_address_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDsAddressRequired { get; set; }

        /// <summary>
        /// Whether privileged callers may request a 3-D Secure skip.
        /// </summary>
        [JsonProperty("three_ds_skip_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDsSkipEnabled { get; set; }

        /// <summary>
        /// Whether a phone number is required when running 3-D Secure.
        /// </summary>
        [JsonProperty("three_ds_phone_number_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreeDsPhoneNumberRequired { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutCardConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetForbiddenCardBrands()
        {
            this.shouldSerialize["forbidden_card_brands"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowedCountriesByIp()
        {
            this.shouldSerialize["allowed_countries_by_ip"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFailOnNewEmail()
        {
            this.shouldSerialize["fail_on_new_email"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardLimit()
        {
            this.shouldSerialize["card_limit"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowEmptyCvv()
        {
            this.shouldSerialize["allow_empty_cvv"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeForbiddenCardBrands()
        {
            return this.shouldSerialize["forbidden_card_brands"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowedCountriesByIp()
        {
            return this.shouldSerialize["allowed_countries_by_ip"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFailOnNewEmail()
        {
            return this.shouldSerialize["fail_on_new_email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardLimit()
        {
            return this.shouldSerialize["card_limit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowEmptyCvv()
        {
            return this.shouldSerialize["allow_empty_cvv"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"DebitEnabled = {(this.DebitEnabled == null ? "null" : this.DebitEnabled.ToString())}");
            toStringOutput.Add($"PrepaidEnabled = {(this.PrepaidEnabled == null ? "null" : this.PrepaidEnabled.ToString())}");
            toStringOutput.Add($"DebitAuthorizationEnabled = {(this.DebitAuthorizationEnabled == null ? "null" : this.DebitAuthorizationEnabled.ToString())}");
            toStringOutput.Add($"PrepaidAuthorizationEnabled = {(this.PrepaidAuthorizationEnabled == null ? "null" : this.PrepaidAuthorizationEnabled.ToString())}");
            toStringOutput.Add($"OnlyDirectCurrency = {(this.OnlyDirectCurrency == null ? "null" : this.OnlyDirectCurrency.ToString())}");
            toStringOutput.Add($"ForbiddenCardBrands = {(this.ForbiddenCardBrands == null ? "null" : $"[{string.Join(", ", this.ForbiddenCardBrands)} ]")}");
            toStringOutput.Add($"AllowedCountriesByIp = {(this.AllowedCountriesByIp == null ? "null" : $"[{string.Join(", ", this.AllowedCountriesByIp)} ]")}");
            toStringOutput.Add($"ForeignCardsAllowed = {(this.ForeignCardsAllowed == null ? "null" : this.ForeignCardsAllowed.ToString())}");
            toStringOutput.Add($"FailOnNewEmail = {(this.FailOnNewEmail == null ? "null" : this.FailOnNewEmail.ToString())}");
            toStringOutput.Add($"CardLimit = {(this.CardLimit == null ? "null" : this.CardLimit.ToString())}");
            toStringOutput.Add($"AllowEmptyCvv = {(this.AllowEmptyCvv == null ? "null" : this.AllowEmptyCvv.ToString())}");
            toStringOutput.Add($"AllowDirectTokenCreation = {(this.AllowDirectTokenCreation == null ? "null" : this.AllowDirectTokenCreation.ToString())}");
            toStringOutput.Add($"ThreeDsRequired = {(this.ThreeDsRequired == null ? "null" : this.ThreeDsRequired.ToString())}");
            toStringOutput.Add($"ThreeDsAddressRequired = {(this.ThreeDsAddressRequired == null ? "null" : this.ThreeDsAddressRequired.ToString())}");
            toStringOutput.Add($"ThreeDsSkipEnabled = {(this.ThreeDsSkipEnabled == null ? "null" : this.ThreeDsSkipEnabled.ToString())}");
            toStringOutput.Add($"ThreeDsPhoneNumberRequired = {(this.ThreeDsPhoneNumberRequired == null ? "null" : this.ThreeDsPhoneNumberRequired.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}