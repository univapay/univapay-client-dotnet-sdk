// <copyright file="SubscriptionInstallmentPlanResponse.cs" company="APIMatic">
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
    /// SubscriptionInstallmentPlanResponse.
    /// </summary>
    public class SubscriptionInstallmentPlanResponse
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

        private Models.CombinedInstallmentFixedCycles? fixedCycles;
        private int? fixedCyclesAmount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "fixed_cycles", false },
            { "fixed_cycles_amount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInstallmentPlanResponse"/> class.
        /// </summary>
        public SubscriptionInstallmentPlanResponse()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInstallmentPlanResponse"/> class.
        /// </summary>
        /// <param name="planType">plan_type.</param>
        /// <param name="fixedCycles">fixed_cycles.</param>
        /// <param name="fixedCyclesAmount">fixed_cycles_amount.</param>
        public SubscriptionInstallmentPlanResponse(
            Models.CombinedPlanType? planType = null,
            Models.CombinedInstallmentFixedCycles? fixedCycles = null,
            int? fixedCyclesAmount = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PlanType = planType;

            if (fixedCycles != null)
            {
                this.FixedCycles = fixedCycles;
            }

            if (fixedCyclesAmount != null)
            {
                this.FixedCyclesAmount = fixedCyclesAmount;
            }
        }

        /// <summary>
        /// Plan type selector.
        /// </summary>
        [JsonProperty("plan_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CombinedPlanType? PlanType { get; set; }

        /// <summary>
        /// Number of installment cycles. Present when plan_type is fixed_cycles.
        /// </summary>
        [JsonProperty("fixed_cycles")]
        public Models.CombinedInstallmentFixedCycles? FixedCycles
        {
            get
            {
                return this.fixedCycles;
            }

            set
            {
                this.shouldSerialize["fixed_cycles"] = true;
                this.fixedCycles = value;
            }
        }

        /// <summary>
        /// Total target amount for the fixed_cycle_amount plan type, in the smallest currency unit. Present when plan_type is fixed_cycle_amount. Note the plural `fixed_cycles_amount` key differs from `subscription_plan`'s singular `fixed_cycle_amount`.
        /// </summary>
        [JsonProperty("fixed_cycles_amount")]
        public int? FixedCyclesAmount
        {
            get
            {
                return this.fixedCyclesAmount;
            }

            set
            {
                this.shouldSerialize["fixed_cycles_amount"] = true;
                this.fixedCyclesAmount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionInstallmentPlanResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFixedCycles()
        {
            this.shouldSerialize["fixed_cycles"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFixedCyclesAmount()
        {
            this.shouldSerialize["fixed_cycles_amount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFixedCycles()
        {
            return this.shouldSerialize["fixed_cycles"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFixedCyclesAmount()
        {
            return this.shouldSerialize["fixed_cycles_amount"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlanType = {(this.PlanType == null ? "null" : this.PlanType.ToString())}");
            toStringOutput.Add($"FixedCycles = {(this.FixedCycles == null ? "null" : this.FixedCycles.ToString())}");
            toStringOutput.Add($"FixedCyclesAmount = {(this.FixedCyclesAmount == null ? "null" : this.FixedCyclesAmount.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}