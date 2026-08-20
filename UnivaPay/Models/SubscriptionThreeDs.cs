// <copyright file="SubscriptionThreeDs.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// SubscriptionThreeDs.
    /// </summary>
    public class SubscriptionThreeDs
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

        private Models.SubscriptionThreeDsMode? mode;
        private string redirectEndpoint;
        private Guid? redirectId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mode", false },
            { "redirect_endpoint", false },
            { "redirect_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionThreeDs"/> class.
        /// </summary>
        public SubscriptionThreeDs()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionThreeDs"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="redirectEndpoint">redirect_endpoint.</param>
        /// <param name="redirectId">redirect_id.</param>
        public SubscriptionThreeDs(
            Models.SubscriptionThreeDsMode? mode = null,
            string redirectEndpoint = null,
            Guid? redirectId = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();

            if (mode != null)
            {
                this.Mode = mode;
            }

            if (redirectEndpoint != null)
            {
                this.RedirectEndpoint = redirectEndpoint;
            }

            if (redirectId != null)
            {
                this.RedirectId = redirectId;
            }
        }

        /// <summary>
        /// 3-D Secure authentication mode applied to the subscription's payments. `if_available` enforces 3DS only if credentials are available for the recurring token and it has not already completed 3DS. `provided` indicates externally supplied MPI authentication data was used.
        /// </summary>
        [JsonProperty("mode")]
        public Models.SubscriptionThreeDsMode? Mode
        {
            get
            {
                return this.mode;
            }

            set
            {
                this.shouldSerialize["mode"] = true;
                this.mode = value;
            }
        }

        /// <summary>
        /// URL the customer is redirected to for 3-D Secure authentication.
        /// </summary>
        [JsonProperty("redirect_endpoint")]
        public string RedirectEndpoint
        {
            get
            {
                return this.redirectEndpoint;
            }

            set
            {
                this.shouldSerialize["redirect_endpoint"] = true;
                this.redirectEndpoint = value;
            }
        }

        /// <summary>
        /// Identifier of the 3-D Secure redirect.
        /// </summary>
        [JsonProperty("redirect_id")]
        public Guid? RedirectId
        {
            get
            {
                return this.redirectId;
            }

            set
            {
                this.shouldSerialize["redirect_id"] = true;
                this.redirectId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionThreeDs : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMode()
        {
            this.shouldSerialize["mode"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRedirectEndpoint()
        {
            this.shouldSerialize["redirect_endpoint"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRedirectId()
        {
            this.shouldSerialize["redirect_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMode()
        {
            return this.shouldSerialize["mode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectEndpoint()
        {
            return this.shouldSerialize["redirect_endpoint"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirectId()
        {
            return this.shouldSerialize["redirect_id"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"RedirectEndpoint = {this.RedirectEndpoint ?? "null"}");
            toStringOutput.Add($"RedirectId = {(this.RedirectId == null ? "null" : this.RedirectId.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}