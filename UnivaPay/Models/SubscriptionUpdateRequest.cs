// <copyright file="SubscriptionUpdateRequest.cs" company="APIMatic">
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
    /// SubscriptionUpdateRequest.
    /// </summary>
    public class SubscriptionUpdateRequest
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
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest"/> class.
        /// </summary>
        public SubscriptionUpdateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest"/> class.
        /// </summary>
        /// <param name="transactionTokenId">transaction_token_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="period">period.</param>
        /// <param name="cyclicalPeriod">cyclical_period.</param>
        /// <param name="initialAmount">initial_amount.</param>
        /// <param name="subscriptionPlan">subscription_plan.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="status">status.</param>
        /// <param name="scheduleSettings">schedule_settings.</param>
        /// <param name="nextPayment">next_payment.</param>
        public SubscriptionUpdateRequest(
            Guid? transactionTokenId = null,
            int? amount = null,
            Models.SubscriptionPeriod? period = null,
            string cyclicalPeriod = null,
            int? initialAmount = null,
            Models.SubscriptionPlanSettings subscriptionPlan = null,
            Models.SubscriptionInstallmentPlan installmentPlan = null,
            Models.GenericMetadata metadata = null,
            Models.SubscriptionUpdateStatus? status = null,
            Models.SubscriptionUpdateScheduleSettings scheduleSettings = null,
            Models.SubscriptionUpdateNextPayment nextPayment = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.TransactionTokenId = transactionTokenId;
            this.Amount = amount;
            this.Period = period;
            this.CyclicalPeriod = cyclicalPeriod;
            this.InitialAmount = initialAmount;
            this.SubscriptionPlan = subscriptionPlan;
            this.InstallmentPlan = installmentPlan;
            this.Metadata = metadata;
            this.Status = status;
            this.ScheduleSettings = scheduleSettings;
            this.NextPayment = nextPayment;
        }

        /// <summary>
        /// Transaction token ID used for the subscription.  Can be changed to update the payment method (e.g., when a card expires).  Allowed only when the status is `unconfirmed`, `unpaid`, `current`, or `suspended`.
        /// </summary>
        [JsonProperty("transaction_token_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TransactionTokenId { get; set; }

        /// <summary>
        /// The recurring charge amount (applied to the cycle after the next one).  Not available for limited-cycle subscriptions.  To change the immediate next payment amount, update `next_payment.amount` instead.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Subscription Period schema.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionPeriod? Period { get; set; }

        /// <summary>
        /// ISO-8601 Duration for custom frequency (e.g., P3D, P2M). Cannot be used together with `period`. Only allowed before the subscription's first payment has been paid.
        /// </summary>
        [JsonProperty("cyclical_period", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclicalPeriod { get; set; }

        /// <summary>
        /// Different amount for the first charge. Only allowed while the subscription status is still editable (before it has started) and requires the App Token Secret.
        /// </summary>
        [JsonProperty("initial_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialAmount { get; set; }

        /// <summary>
        /// Configuration for limited-cycle subscriptions (Univapay side).
        /// </summary>
        [JsonProperty("subscription_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionPlanSettings SubscriptionPlan { get; set; }

        /// <summary>
        /// Configuration for credit card company side installments.
        /// </summary>
        [JsonProperty("installment_plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionInstallmentPlan InstallmentPlan { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Update the subscription status.  `suspended`: Pause the subscription.  `unpaid`: Resume a suspended subscription.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateStatus? Status { get; set; }

        /// <summary>
        /// Schedule settings that can be updated on a subscription.
        /// </summary>
        [JsonProperty("schedule_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateScheduleSettings ScheduleSettings { get; set; }

        /// <summary>
        /// Fields that can be updated on the next scheduled payment.
        /// </summary>
        [JsonProperty("next_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionUpdateNextPayment NextPayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionUpdateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionTokenId = {(this.TransactionTokenId == null ? "null" : this.TransactionTokenId.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"CyclicalPeriod = {this.CyclicalPeriod ?? "null"}");
            toStringOutput.Add($"InitialAmount = {(this.InitialAmount == null ? "null" : this.InitialAmount.ToString())}");
            toStringOutput.Add($"SubscriptionPlan = {(this.SubscriptionPlan == null ? "null" : this.SubscriptionPlan.ToString())}");
            toStringOutput.Add($"InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"ScheduleSettings = {(this.ScheduleSettings == null ? "null" : this.ScheduleSettings.ToString())}");
            toStringOutput.Add($"NextPayment = {(this.NextPayment == null ? "null" : this.NextPayment.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}