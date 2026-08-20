// <copyright file="TokenResponsePaidyData.cs" company="APIMatic">
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
    /// TokenResponsePaidyData.
    /// </summary>
    public class TokenResponsePaidyData
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

        private string phoneNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "phone_number", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponsePaidyData"/> class.
        /// </summary>
        public TokenResponsePaidyData()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponsePaidyData"/> class.
        /// </summary>
        /// <param name="paidyToken">paidy_token.</param>
        /// <param name="phoneNumber">phone_number.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        public TokenResponsePaidyData(
            string paidyToken,
            string phoneNumber = null,
            Models.TokenResponsePaidyDataShippingAddress shippingAddress = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PaidyToken = paidyToken;

            if (phoneNumber != null)
            {
                this.PhoneNumber = phoneNumber;
            }
            this.ShippingAddress = shippingAddress;
        }

        /// <summary>
        /// One-time token issued by the Paidy SDK/widget on the client side.
        /// </summary>
        [JsonProperty("paidy_token")]
        public string PaidyToken { get; set; }

        /// <summary>
        /// Consumer phone number in Japanese format.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.shouldSerialize["phone_number"] = true;
                this.phoneNumber = value;
            }
        }

        /// <summary>
        /// Shipping address returned for a Paidy token.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenResponsePaidyDataShippingAddress ShippingAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TokenResponsePaidyData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPhoneNumber()
        {
            this.shouldSerialize["phone_number"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePhoneNumber()
        {
            return this.shouldSerialize["phone_number"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PaidyToken = {this.PaidyToken ?? "null"}");
            toStringOutput.Add($"PhoneNumber = {this.PhoneNumber ?? "null"}");
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}