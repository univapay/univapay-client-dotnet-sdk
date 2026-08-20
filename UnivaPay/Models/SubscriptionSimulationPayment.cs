// <copyright file="SubscriptionSimulationPayment.cs" company="APIMatic">
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
    /// SubscriptionSimulationPayment.
    /// </summary>
    public class SubscriptionSimulationPayment
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

        private DateTime? successfulPaymentDate;
        private Models.TerminateWithStatus? terminateWithStatus;
        private string retryInterval;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "successful_payment_date", false },
            { "terminate_with_status", false },
            { "retry_interval", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSimulationPayment"/> class.
        /// </summary>
        public SubscriptionSimulationPayment()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSimulationPayment"/> class.
        /// </summary>
        /// <param name="dueDate">due_date.</param>
        /// <param name="zoneId">zone_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="isPaid">is_paid.</param>
        /// <param name="isLastPayment">is_last_payment.</param>
        /// <param name="successfulPaymentDate">successful_payment_date.</param>
        /// <param name="terminateWithStatus">terminate_with_status.</param>
        /// <param name="retryInterval">retry_interval.</param>
        public SubscriptionSimulationPayment(
            DateTime? dueDate = null,
            string zoneId = null,
            int? amount = null,
            string currency = null,
            bool? isPaid = null,
            bool? isLastPayment = null,
            DateTime? successfulPaymentDate = null,
            Models.TerminateWithStatus? terminateWithStatus = null,
            string retryInterval = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.DueDate = dueDate;
            this.ZoneId = zoneId;
            this.Amount = amount;
            this.Currency = currency;
            this.IsPaid = isPaid;
            this.IsLastPayment = isLastPayment;

            if (successfulPaymentDate != null)
            {
                this.SuccessfulPaymentDate = successfulPaymentDate;
            }

            if (terminateWithStatus != null)
            {
                this.TerminateWithStatus = terminateWithStatus;
            }

            if (retryInterval != null)
            {
                this.RetryInterval = retryInterval;
            }
        }

        /// <summary>
        /// Scheduled due date for this simulated payment (YYYY-MM-DD).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// IANA timezone identifier used to resolve the due date.
        /// </summary>
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Amount to be charged on this cycle, in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Always `false` for simulated payments — no real payment has been made.
        /// </summary>
        [JsonProperty("is_paid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Whether this is the final payment in the simulated schedule.
        /// </summary>
        [JsonProperty("is_last_payment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLastPayment { get; set; }

        /// <summary>
        /// Always `null` for simulated payments — populated only once a real payment settles.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("successful_payment_date")]
        public DateTime? SuccessfulPaymentDate
        {
            get
            {
                return this.successfulPaymentDate;
            }

            set
            {
                this.shouldSerialize["successful_payment_date"] = true;
                this.successfulPaymentDate = value;
            }
        }

        /// <summary>
        /// The status the subscription would transition to on this payment's due date, if a termination is scheduled. `null` when no termination applies.
        /// </summary>
        [JsonProperty("terminate_with_status")]
        public Models.TerminateWithStatus? TerminateWithStatus
        {
            get
            {
                return this.terminateWithStatus;
            }

            set
            {
                this.shouldSerialize["terminate_with_status"] = true;
                this.terminateWithStatus = value;
            }
        }

        /// <summary>
        /// ISO-8601 Duration for the retry interval applied if this payment fails (e.g., P5D). `null` if no retry interval is configured.
        /// </summary>
        [JsonProperty("retry_interval")]
        public string RetryInterval
        {
            get
            {
                return this.retryInterval;
            }

            set
            {
                this.shouldSerialize["retry_interval"] = true;
                this.retryInterval = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionSimulationPayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSuccessfulPaymentDate()
        {
            this.shouldSerialize["successful_payment_date"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTerminateWithStatus()
        {
            this.shouldSerialize["terminate_with_status"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRetryInterval()
        {
            this.shouldSerialize["retry_interval"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccessfulPaymentDate()
        {
            return this.shouldSerialize["successful_payment_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTerminateWithStatus()
        {
            return this.shouldSerialize["terminate_with_status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRetryInterval()
        {
            return this.shouldSerialize["retry_interval"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"ZoneId = {this.ZoneId ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"IsPaid = {(this.IsPaid == null ? "null" : this.IsPaid.ToString())}");
            toStringOutput.Add($"IsLastPayment = {(this.IsLastPayment == null ? "null" : this.IsLastPayment.ToString())}");
            toStringOutput.Add($"SuccessfulPaymentDate = {(this.SuccessfulPaymentDate == null ? "null" : this.SuccessfulPaymentDate.ToString())}");
            toStringOutput.Add($"TerminateWithStatus = {(this.TerminateWithStatus == null ? "null" : this.TerminateWithStatus.ToString())}");
            toStringOutput.Add($"RetryInterval = {this.RetryInterval ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}