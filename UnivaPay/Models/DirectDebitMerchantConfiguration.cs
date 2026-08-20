// <copyright file="DirectDebitMerchantConfiguration.cs" company="APIMatic">
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
    /// DirectDebitMerchantConfiguration.
    /// </summary>
    public class DirectDebitMerchantConfiguration
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

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitMerchantConfiguration"/> class.
        /// </summary>
        public DirectDebitMerchantConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitMerchantConfiguration"/> class.
        /// </summary>
        /// <param name="legacyId">legacy_id.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="debitDate">debit_date.</param>
        /// <param name="consignorCode">consignor_code.</param>
        /// <param name="classifier">classifier.</param>
        /// <param name="signature">signature.</param>
        public DirectDebitMerchantConfiguration(
            string legacyId = null,
            bool? enabled = null,
            Models.DirectDebitDebitDate? debitDate = null,
            string consignorCode = null,
            string classifier = null,
            string signature = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.LegacyId = legacyId;
            this.Enabled = enabled;
            this.DebitDate = debitDate;
            this.ConsignorCode = consignorCode;
            this.Classifier = classifier;
            this.Signature = signature;
        }

        /// <summary>
        /// Identifier of the merchant in the legacy direct debit system.
        /// </summary>
        [JsonProperty("legacy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LegacyId { get; set; }

        /// <summary>
        /// Whether direct debit is enabled for this merchant.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Monthly debit cycle — funds are pulled on either the 14th or the 27th.
        /// </summary>
        [JsonProperty("debit_date", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDebitDate? DebitDate { get; set; }

        /// <summary>
        /// Consignor code (委託者コード) assigned by the collecting bank.
        /// </summary>
        [JsonProperty("consignor_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsignorCode { get; set; }

        /// <summary>
        /// Transfer classification code (区分) agreed with the collecting bank.
        /// </summary>
        [JsonProperty("classifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Classifier { get; set; }

        /// <summary>
        /// Name printed on the consumer's bank statement (印字名), in half-width katakana.
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DirectDebitMerchantConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LegacyId = {this.LegacyId ?? "null"}");
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"DebitDate = {(this.DebitDate == null ? "null" : this.DebitDate.ToString())}");
            toStringOutput.Add($"ConsignorCode = {this.ConsignorCode ?? "null"}");
            toStringOutput.Add($"Classifier = {this.Classifier ?? "null"}");
            toStringOutput.Add($"Signature = {this.Signature ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}