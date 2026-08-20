// <copyright file="DirectDebitNotificationConfiguration.cs" company="APIMatic">
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
    /// DirectDebitNotificationConfiguration.
    /// </summary>
    public class DirectDebitNotificationConfiguration
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
        /// Initializes a new instance of the <see cref="DirectDebitNotificationConfiguration"/> class.
        /// </summary>
        public DirectDebitNotificationConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitNotificationConfiguration"/> class.
        /// </summary>
        /// <param name="notifyDeadlineMailing">notify_deadline_mailing.</param>
        /// <param name="notifyDeadlineDebit">notify_deadline_debit.</param>
        /// <param name="notifyDebitUpdate">notify_debit_update.</param>
        public DirectDebitNotificationConfiguration(
            bool? notifyDeadlineMailing = null,
            bool? notifyDeadlineDebit = null,
            bool? notifyDebitUpdate = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.NotifyDeadlineMailing = notifyDeadlineMailing;
            this.NotifyDeadlineDebit = notifyDeadlineDebit;
            this.NotifyDebitUpdate = notifyDebitUpdate;
        }

        /// <summary>
        /// Notify when the deadline for the bank to receive the signed mandate approaches (郵送期限の通知).
        /// </summary>
        [JsonProperty("notify_deadline_mailing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyDeadlineMailing { get; set; }

        /// <summary>
        /// Notify when the transfer registration cutoff approaches (締切日の通知).
        /// </summary>
        [JsonProperty("notify_deadline_debit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyDeadlineDebit { get; set; }

        /// <summary>
        /// Notify when transfer results are reflected (振替結果の通知).
        /// </summary>
        [JsonProperty("notify_debit_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyDebitUpdate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DirectDebitNotificationConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"NotifyDeadlineMailing = {(this.NotifyDeadlineMailing == null ? "null" : this.NotifyDeadlineMailing.ToString())}");
            toStringOutput.Add($"NotifyDeadlineDebit = {(this.NotifyDeadlineDebit == null ? "null" : this.NotifyDeadlineDebit.ToString())}");
            toStringOutput.Add($"NotifyDebitUpdate = {(this.NotifyDebitUpdate == null ? "null" : this.NotifyDebitUpdate.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}