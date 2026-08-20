// <copyright file="SubscriptionSimulationRequest.cs" company="APIMatic">
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
    /// SubscriptionSimulationRequest.
    /// </summary>
    public class SubscriptionSimulationRequest
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
        /// Initializes a new instance of the <see cref="SubscriptionSimulationRequest"/> class.
        /// </summary>
        public SubscriptionSimulationRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSimulationRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="scheduleSettings">schedule_settings.</param>
        /// <param name="initialAmount">initial_amount.</param>
        /// <param name="period">period.</param>
        /// <param name="cyclicalPeriod">cyclical_period.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        /// <param name="subscriptionPlan">subscription_plan.</param>
        /// <param name="onlyDirectCurrency">only_direct_currency.</param>
        public SubscriptionSimulationRequest(
            int amount,
            string currency,
            Models.TransactionTokenPaymentType paymentType,
            Models.SubscriptionScheduleSettings scheduleSettings,
            int? initialAmount = null,
            Models.SubscriptionSimulationPeriod? period = null,
            string cyclicalPeriod = null,
            Models.SubscriptionSimulationPlanSettings installmentPlan = null,
            Models.SubscriptionSimulationPlanSettings subscriptionPlan = null,
            bool? onlyDirectCurrency = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Amount = amount;
            this.Currency = currency;
            this.PaymentType = paymentType;
            this.InitialAmount = initialAmount;
            this.Period = period;
            this.CyclicalPeriod = cyclicalPeriod;
            this.ScheduleSettings = scheduleSettings;
            this.InstallmentPlan = installmentPlan;
            this.SubscriptionPlan = subscriptionPlan;
            this.OnlyDirectCurrency = onlyDirectCurrency;
        }

        /// <summary>
        /// Amount to be charged in each cycle. Must be a positive integer.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Transaction Token Payment Type schema.
        /// </summary>
        [JsonProperty("payment_type")]
        public Models.TransactionTokenPaymentType PaymentType { get; set; }

        /// <summary>
        /// Optional different amount for the first charge. Must be zero or greater.
        /// </summary>
        [JsonProperty("initial_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialAmount { get; set; }

        /// <summary>
        /// Billing frequency for the simulated schedule. Includes `bimonthly`, which is not offered on `SubscriptionPeriod` for live subscription creation.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionSimulationPeriod? Period { get; set; }

        /// <summary>
        /// ISO-8601 Duration for custom frequency (e.g., P3D, P2M). Cannot be used together with 'period' — specify exactly one of the two.
        /// </summary>
        [JsonProperty("cyclical_period", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclicalPeriod { get; set; }

        /// <summary>
        /// Schedule settings applied to a subscription.
        /// </summary>
        [JsonProperty("schedule_settings")]
        public Models.SubscriptionScheduleSettings ScheduleSettings { get; set; }

        /// <summary>
        /// Cycle-limiting plan configuration used to simulate an installment plan or a Univapay-side subscription plan.
        /// </summary>
        [JsonProperty("installment_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionSimulationPlanSettings InstallmentPlan { get; set; }

        /// <summary>
        /// Cycle-limiting plan configuration used to simulate an installment plan or a Univapay-side subscription plan.
        /// </summary>
        [JsonProperty("subscription_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionSimulationPlanSettings SubscriptionPlan { get; set; }

        /// <summary>
        /// Whether only direct currency processing is allowed.
        /// </summary>
        [JsonProperty("only_direct_currency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDirectCurrency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionSimulationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {this.Amount}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"PaymentType = {this.PaymentType}");
            toStringOutput.Add($"InitialAmount = {(this.InitialAmount == null ? "null" : this.InitialAmount.ToString())}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"CyclicalPeriod = {this.CyclicalPeriod ?? "null"}");
            toStringOutput.Add($"ScheduleSettings = {(this.ScheduleSettings == null ? "null" : this.ScheduleSettings.ToString())}");
            toStringOutput.Add($"InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan.ToString())}");
            toStringOutput.Add($"SubscriptionPlan = {(this.SubscriptionPlan == null ? "null" : this.SubscriptionPlan.ToString())}");
            toStringOutput.Add($"OnlyDirectCurrency = {(this.OnlyDirectCurrency == null ? "null" : this.OnlyDirectCurrency.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}