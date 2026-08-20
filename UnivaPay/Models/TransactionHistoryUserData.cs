// <copyright file="TransactionHistoryUserData.cs" company="APIMatic">
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
    /// TransactionHistoryUserData.
    /// </summary>
    public class TransactionHistoryUserData
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

        private string cardholderEmailAddress;
        private string cardholderPhoneNumber;
        private string brand;
        private string gateway;
        private Models.TransactionHistoryServiceProvider? serviceProvider;
        private Models.TransactionHistoryRefundReason? reason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cardholder_email_address", false },
            { "cardholder_phone_number", false },
            { "brand", false },
            { "gateway", false },
            { "service_provider", false },
            { "reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryUserData"/> class.
        /// </summary>
        public TransactionHistoryUserData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryUserData"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="cardholderName">cardholder_name.</param>
        /// <param name="cardholderEmailAddress">cardholder_email_address.</param>
        /// <param name="cardholderPhoneNumber">cardholder_phone_number.</param>
        /// <param name="customerName">customer_name.</param>
        /// <param name="convenienceStore">convenience_store.</param>
        /// <param name="brand">brand.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="serviceProvider">service_provider.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="reason">reason.</param>
        public TransactionHistoryUserData(
            Models.TransactionHistoryType? type = null,
            string cardholderName = null,
            string cardholderEmailAddress = null,
            string cardholderPhoneNumber = null,
            string customerName = null,
            string convenienceStore = null,
            string brand = null,
            string gateway = null,
            Models.TransactionHistoryServiceProvider? serviceProvider = null,
            List<Models.TransactionHistoryRefund> refunds = null,
            Models.TransactionHistoryRefundReason? reason = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Type = type;
            this.CardholderName = cardholderName;

            if (cardholderEmailAddress != null)
            {
                this.CardholderEmailAddress = cardholderEmailAddress;
            }

            if (cardholderPhoneNumber != null)
            {
                this.CardholderPhoneNumber = cardholderPhoneNumber;
            }
            this.CustomerName = customerName;
            this.ConvenienceStore = convenienceStore;

            if (brand != null)
            {
                this.Brand = brand;
            }

            if (gateway != null)
            {
                this.Gateway = gateway;
            }

            if (serviceProvider != null)
            {
                this.ServiceProvider = serviceProvider;
            }
            this.Refunds = refunds;

            if (reason != null)
            {
                this.Reason = reason;
            }
        }

        /// <summary>
        /// Whether this row represents a charge or a refund.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryType? Type { get; set; }

        /// <summary>
        /// Cardholder name. Present for `card` and `apple_pay` rows only.
        /// </summary>
        [JsonProperty("cardholder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Cardholder/customer email address. Present for every payment type except `konbini`'s legacy alias fields; always non-null for `bank_transfer` rows, nullable for every other type.
        /// </summary>
        [JsonProperty("cardholder_email_address")]
        public string CardholderEmailAddress
        {
            get
            {
                return this.cardholderEmailAddress;
            }

            set
            {
                this.shouldSerialize["cardholder_email_address"] = true;
                this.cardholderEmailAddress = value;
            }
        }

        /// <summary>
        /// Cardholder phone number. Present for `paidy` rows only.
        /// </summary>
        [JsonProperty("cardholder_phone_number")]
        public string CardholderPhoneNumber
        {
            get
            {
                return this.cardholderPhoneNumber;
            }

            set
            {
                this.shouldSerialize["cardholder_phone_number"] = true;
                this.cardholderPhoneNumber = value;
            }
        }

        /// <summary>
        /// Customer name as entered at checkout. Present for `konbini` rows only (empty string when not provided).
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Legacy duplicate of `brand`. Present for `konbini` rows only.
        /// </summary>
        [JsonProperty("convenience_store", NullValueHandling = NullValueHandling.Ignore)]
        public string ConvenienceStore { get; set; }

        /// <summary>
        /// Raw brand identifier for the payment method. Present for every payment type; the value set is payment-type-specific (e.g. card brands for `card`/`apple_pay`, QR brands for `qr_scan`/`qr_merchant`, online-wallet brands for `online`, convenience-store brands for `konbini`, `paidy` for `paidy` rows). Nullable for `qr_scan`, `qr_merchant`, and `online`; always non-null for the other types.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.shouldSerialize["brand"] = true;
                this.brand = value;
            }
        }

        /// <summary>
        /// Raw gateway identifier that processed the payment. Present for every payment type.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway
        {
            get
            {
                return this.gateway;
            }

            set
            {
                this.shouldSerialize["gateway"] = true;
                this.gateway = value;
            }
        }

        /// <summary>
        /// Service provider, or `null` when not reported.
        /// </summary>
        [JsonProperty("service_provider")]
        public Models.TransactionHistoryServiceProvider? ServiceProvider
        {
            get
            {
                return this.serviceProvider;
            }

            set
            {
                this.shouldSerialize["service_provider"] = true;
                this.serviceProvider = value;
            }
        }

        /// <summary>
        /// Refunds issued against this charge. Present for charge rows only (`type: charge`); absent for refund rows.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TransactionHistoryRefund> Refunds { get; set; }

        /// <summary>
        /// Refund reason, or `null` when unset.
        /// </summary>
        [JsonProperty("reason")]
        public Models.TransactionHistoryRefundReason? Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                this.shouldSerialize["reason"] = true;
                this.reason = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionHistoryUserData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardholderEmailAddress()
        {
            this.shouldSerialize["cardholder_email_address"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardholderPhoneNumber()
        {
            this.shouldSerialize["cardholder_phone_number"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrand()
        {
            this.shouldSerialize["brand"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGateway()
        {
            this.shouldSerialize["gateway"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetServiceProvider()
        {
            this.shouldSerialize["service_provider"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReason()
        {
            this.shouldSerialize["reason"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardholderEmailAddress()
        {
            return this.shouldSerialize["cardholder_email_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardholderPhoneNumber()
        {
            return this.shouldSerialize["cardholder_phone_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBrand()
        {
            return this.shouldSerialize["brand"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGateway()
        {
            return this.shouldSerialize["gateway"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeServiceProvider()
        {
            return this.shouldSerialize["service_provider"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReason()
        {
            return this.shouldSerialize["reason"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"CardholderName = {this.CardholderName ?? "null"}");
            toStringOutput.Add($"CardholderEmailAddress = {this.CardholderEmailAddress ?? "null"}");
            toStringOutput.Add($"CardholderPhoneNumber = {this.CardholderPhoneNumber ?? "null"}");
            toStringOutput.Add($"CustomerName = {this.CustomerName ?? "null"}");
            toStringOutput.Add($"ConvenienceStore = {this.ConvenienceStore ?? "null"}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");
            toStringOutput.Add($"Gateway = {this.Gateway ?? "null"}");
            toStringOutput.Add($"ServiceProvider = {(this.ServiceProvider == null ? "null" : this.ServiceProvider.ToString())}");
            toStringOutput.Add($"Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
            toStringOutput.Add($"Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}