// <copyright file="CheckoutQrScanConfiguration.cs" company="APIMatic">
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
    /// CheckoutQrScanConfiguration.
    /// </summary>
    public class CheckoutQrScanConfiguration
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

        private List<string> forbiddenQrScanGateways;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "forbidden_qr_scan_gateways", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutQrScanConfiguration"/> class.
        /// </summary>
        public CheckoutQrScanConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutQrScanConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="forbiddenQrScanGateways">forbidden_qr_scan_gateways.</param>
        public CheckoutQrScanConfiguration(
            bool? enabled = null,
            List<string> forbiddenQrScanGateways = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Enabled = enabled;

            if (forbiddenQrScanGateways != null)
            {
                this.ForbiddenQrScanGateways = forbiddenQrScanGateways;
            }
        }

        /// <summary>
        /// Whether QR-scan payments are enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// QR-scan gateways disabled for the merchant. Common values include `alipay`, `alipay_plus`, `pay_pay`, `we_chat`, `univapay`, and `test`. `null` when no gateway is forbidden.
        /// </summary>
        [JsonProperty("forbidden_qr_scan_gateways")]
        public List<string> ForbiddenQrScanGateways
        {
            get
            {
                return this.forbiddenQrScanGateways;
            }

            set
            {
                this.shouldSerialize["forbidden_qr_scan_gateways"] = true;
                this.forbiddenQrScanGateways = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutQrScanConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetForbiddenQrScanGateways()
        {
            this.shouldSerialize["forbidden_qr_scan_gateways"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeForbiddenQrScanGateways()
        {
            return this.shouldSerialize["forbidden_qr_scan_gateways"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"ForbiddenQrScanGateways = {(this.ForbiddenQrScanGateways == null ? "null" : $"[{string.Join(", ", this.ForbiddenQrScanGateways)} ]")}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}