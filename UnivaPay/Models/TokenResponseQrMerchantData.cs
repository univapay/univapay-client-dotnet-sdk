// <copyright file="TokenResponseQrMerchantData.cs" company="APIMatic">
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
    /// TokenResponseQrMerchantData.
    /// </summary>
    public class TokenResponseQrMerchantData
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

        private string brand;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "brand", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseQrMerchantData"/> class.
        /// </summary>
        public TokenResponseQrMerchantData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseQrMerchantData"/> class.
        /// </summary>
        /// <param name="qrImageUrl">qr_image_url.</param>
        /// <param name="brand">brand.</param>
        public TokenResponseQrMerchantData(
            string qrImageUrl = null,
            string brand = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.QrImageUrl = qrImageUrl;

            if (brand != null)
            {
                this.Brand = brand;
            }
        }

        /// <summary>
        /// QR code payload to be rendered by the consumer (content varies by brand — may be a URL or an opaque code). Some brands return an image URL; others (e.g. convenience-store QR brands) return an opaque numeric code with no URL structure. Populated asynchronously shortly after token/charge creation — `null` until then.
        /// </summary>
        [JsonProperty("qr_image_url", NullValueHandling = NullValueHandling.Include)]
        public string QrImageUrl { get; set; }

        /// <summary>
        /// The QR-MPM brand this code was generated for.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponseQrMerchantData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBrand()
        {
            this.shouldSerialize["brand"] = false;
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
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"QrImageUrl = {this.QrImageUrl ?? "null"}");
            toStringOutput.Add($"Brand = {this.Brand ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}