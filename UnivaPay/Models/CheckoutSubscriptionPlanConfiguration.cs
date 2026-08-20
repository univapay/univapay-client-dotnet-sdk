// <copyright file="CheckoutSubscriptionPlanConfiguration.cs" company="APIMatic">
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
    /// CheckoutSubscriptionPlanConfiguration.
    /// </summary>
    public class CheckoutSubscriptionPlanConfiguration
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

        private Models.CheckoutMoneyAmount minChargeAmount;
        private string maxPayoutPeriod;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "min_charge_amount", false },
            { "max_payout_period", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSubscriptionPlanConfiguration"/> class.
        /// </summary>
        public CheckoutSubscriptionPlanConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSubscriptionPlanConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="fixedCycle">fixed_cycle.</param>
        /// <param name="fixedCycleAmount">fixed_cycle_amount.</param>
        /// <param name="supportedPaymentTypes">supported_payment_types.</param>
        /// <param name="minChargeAmount">min_charge_amount.</param>
        /// <param name="maxPayoutPeriod">max_payout_period.</param>
        public CheckoutSubscriptionPlanConfiguration(
            bool? enabled = null,
            bool? fixedCycle = null,
            bool? fixedCycleAmount = null,
            List<Models.CheckoutPaymentType> supportedPaymentTypes = null,
            Models.CheckoutMoneyAmount minChargeAmount = null,
            string maxPayoutPeriod = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Enabled = enabled;
            this.FixedCycle = fixedCycle;
            this.FixedCycleAmount = fixedCycleAmount;
            this.SupportedPaymentTypes = supportedPaymentTypes;

            if (minChargeAmount != null)
            {
                this.MinChargeAmount = minChargeAmount;
            }

            if (maxPayoutPeriod != null)
            {
                this.MaxPayoutPeriod = maxPayoutPeriod;
            }
        }

        /// <summary>
        /// Whether subscription plans are enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether fixed-cycle subscription plans are allowed.
        /// </summary>
        [JsonProperty("fixed_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixedCycle { get; set; }

        /// <summary>
        /// Whether fixed-cycle-amount subscription plans are allowed.
        /// </summary>
        [JsonProperty("fixed_cycle_amount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixedCycleAmount { get; set; }

        /// <summary>
        /// Payment types eligible for subscription plans.
        /// </summary>
        [JsonProperty("supported_payment_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CheckoutPaymentType> SupportedPaymentTypes { get; set; }

        /// <summary>
        /// Minimum charge amount eligible for subscription plans. `null` when unrestricted.
        /// </summary>
        [JsonProperty("min_charge_amount")]
        public Models.CheckoutMoneyAmount MinChargeAmount
        {
            get
            {
                return this.minChargeAmount;
            }

            set
            {
                this.shouldSerialize["min_charge_amount"] = true;
                this.minChargeAmount = value;
            }
        }

        /// <summary>
        /// ISO-8601 period bounding the maximum payout delay for subscription settlements. `null` when unrestricted.
        /// </summary>
        [JsonProperty("max_payout_period")]
        public string MaxPayoutPeriod
        {
            get
            {
                return this.maxPayoutPeriod;
            }

            set
            {
                this.shouldSerialize["max_payout_period"] = true;
                this.maxPayoutPeriod = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutSubscriptionPlanConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMinChargeAmount()
        {
            this.shouldSerialize["min_charge_amount"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMaxPayoutPeriod()
        {
            this.shouldSerialize["max_payout_period"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMinChargeAmount()
        {
            return this.shouldSerialize["min_charge_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxPayoutPeriod()
        {
            return this.shouldSerialize["max_payout_period"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"FixedCycle = {(this.FixedCycle == null ? "null" : this.FixedCycle.ToString())}");
            toStringOutput.Add($"FixedCycleAmount = {(this.FixedCycleAmount == null ? "null" : this.FixedCycleAmount.ToString())}");
            toStringOutput.Add($"SupportedPaymentTypes = {(this.SupportedPaymentTypes == null ? "null" : $"[{string.Join(", ", this.SupportedPaymentTypes)} ]")}");
            toStringOutput.Add($"MinChargeAmount = {(this.MinChargeAmount == null ? "null" : this.MinChargeAmount.ToString())}");
            toStringOutput.Add($"MaxPayoutPeriod = {this.MaxPayoutPeriod ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}