// <copyright file="CheckoutBankTransferConfiguration.cs" company="APIMatic">
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
    /// CheckoutBankTransferConfiguration.
    /// </summary>
    public class CheckoutBankTransferConfiguration
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
        /// Initializes a new instance of the <see cref="CheckoutBankTransferConfiguration"/> class.
        /// </summary>
        public CheckoutBankTransferConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutBankTransferConfiguration"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="matchAmount">match_amount.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="expirationTimeShift">expiration_time_shift.</param>
        /// <param name="virtualBankAccountsThreshold">virtual_bank_accounts_threshold.</param>
        /// <param name="virtualBankAccountsFetchCount">virtual_bank_accounts_fetch_count.</param>
        /// <param name="defaultExtensionPeriod">default_extension_period.</param>
        /// <param name="maximumExtensionPeriod">maximum_extension_period.</param>
        /// <param name="automaticExtensionEnabled">automatic_extension_enabled.</param>
        /// <param name="chargeRequestNotificationEnabled">charge_request_notification_enabled.</param>
        /// <param name="chargeRequestCanceledNotificationEnabled">charge_request_canceled_notification_enabled.</param>
        /// <param name="chargeExpiredNotificationEnabled">charge_expired_notification_enabled.</param>
        /// <param name="depositReceivedNotificationEnabled">deposit_received_notification_enabled.</param>
        /// <param name="depositInsufficientNotificationEnabled">deposit_insufficient_notification_enabled.</param>
        /// <param name="depositExceededNotificationEnabled">deposit_exceeded_notification_enabled.</param>
        /// <param name="extensionNotificationEnabled">extension_notification_enabled.</param>
        /// <param name="remindNotificationPeriod">remind_notification_period.</param>
        /// <param name="remindNotificationEnabled">remind_notification_enabled.</param>
        public CheckoutBankTransferConfiguration(
            bool? enabled = null,
            Models.CheckoutBankTransferMatchAmount? matchAmount = null,
            string expiration = null,
            Models.ExpirationTimeShift expirationTimeShift = null,
            int? virtualBankAccountsThreshold = null,
            int? virtualBankAccountsFetchCount = null,
            string defaultExtensionPeriod = null,
            string maximumExtensionPeriod = null,
            bool? automaticExtensionEnabled = null,
            bool? chargeRequestNotificationEnabled = null,
            bool? chargeRequestCanceledNotificationEnabled = null,
            bool? chargeExpiredNotificationEnabled = null,
            bool? depositReceivedNotificationEnabled = null,
            bool? depositInsufficientNotificationEnabled = null,
            bool? depositExceededNotificationEnabled = null,
            bool? extensionNotificationEnabled = null,
            string remindNotificationPeriod = null,
            bool? remindNotificationEnabled = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Enabled = enabled;
            this.MatchAmount = matchAmount;
            this.Expiration = expiration;
            this.ExpirationTimeShift = expirationTimeShift;
            this.VirtualBankAccountsThreshold = virtualBankAccountsThreshold;
            this.VirtualBankAccountsFetchCount = virtualBankAccountsFetchCount;
            this.DefaultExtensionPeriod = defaultExtensionPeriod;
            this.MaximumExtensionPeriod = maximumExtensionPeriod;
            this.AutomaticExtensionEnabled = automaticExtensionEnabled;
            this.ChargeRequestNotificationEnabled = chargeRequestNotificationEnabled;
            this.ChargeRequestCanceledNotificationEnabled = chargeRequestCanceledNotificationEnabled;
            this.ChargeExpiredNotificationEnabled = chargeExpiredNotificationEnabled;
            this.DepositReceivedNotificationEnabled = depositReceivedNotificationEnabled;
            this.DepositInsufficientNotificationEnabled = depositInsufficientNotificationEnabled;
            this.DepositExceededNotificationEnabled = depositExceededNotificationEnabled;
            this.ExtensionNotificationEnabled = extensionNotificationEnabled;
            this.RemindNotificationPeriod = remindNotificationPeriod;
            this.RemindNotificationEnabled = remindNotificationEnabled;
        }

        /// <summary>
        /// Whether bank transfer payments are enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Deposit-matching policy applied to bank transfer payments.
        /// </summary>
        [JsonProperty("match_amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CheckoutBankTransferMatchAmount? MatchAmount { get; set; }

        /// <summary>
        /// ISO-8601 duration before a bank transfer payment expires.
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiration { get; set; }

        /// <summary>
        /// Time-of-day override applied when calculating expirations, shared by convenience-store and bank-transfer configuration.
        /// </summary>
        [JsonProperty("expiration_time_shift", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExpirationTimeShift ExpirationTimeShift { get; set; }

        /// <summary>
        /// Number of unused virtual bank accounts that triggers provisioning of additional accounts.
        /// </summary>
        [JsonProperty("virtual_bank_accounts_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualBankAccountsThreshold { get; set; }

        /// <summary>
        /// Number of virtual bank accounts provisioned per replenishment.
        /// </summary>
        [JsonProperty("virtual_bank_accounts_fetch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VirtualBankAccountsFetchCount { get; set; }

        /// <summary>
        /// ISO-8601 duration by which a payment deadline is extended by default.
        /// </summary>
        [JsonProperty("default_extension_period", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultExtensionPeriod { get; set; }

        /// <summary>
        /// ISO-8601 duration for the maximum allowed extension.
        /// </summary>
        [JsonProperty("maximum_extension_period", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumExtensionPeriod { get; set; }

        /// <summary>
        /// Whether payment deadlines are extended automatically.
        /// </summary>
        [JsonProperty("automatic_extension_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomaticExtensionEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a bank transfer charge is requested.
        /// </summary>
        [JsonProperty("charge_request_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeRequestNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a requested bank transfer charge is canceled.
        /// </summary>
        [JsonProperty("charge_request_canceled_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeRequestCanceledNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a bank transfer charge expires.
        /// </summary>
        [JsonProperty("charge_expired_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChargeExpiredNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a deposit is received.
        /// </summary>
        [JsonProperty("deposit_received_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DepositReceivedNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a deposit is insufficient.
        /// </summary>
        [JsonProperty("deposit_insufficient_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DepositInsufficientNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a deposit exceeds the requested amount.
        /// </summary>
        [JsonProperty("deposit_exceeded_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DepositExceededNotificationEnabled { get; set; }

        /// <summary>
        /// Whether a notification is sent when a payment deadline is extended.
        /// </summary>
        [JsonProperty("extension_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExtensionNotificationEnabled { get; set; }

        /// <summary>
        /// ISO-8601 duration before expiration at which a reminder notification is sent.
        /// </summary>
        [JsonProperty("remind_notification_period", NullValueHandling = NullValueHandling.Ignore)]
        public string RemindNotificationPeriod { get; set; }

        /// <summary>
        /// Whether reminder notifications are sent before a payment deadline.
        /// </summary>
        [JsonProperty("remind_notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemindNotificationEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutBankTransferConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"MatchAmount = {(this.MatchAmount == null ? "null" : this.MatchAmount.ToString())}");
            toStringOutput.Add($"Expiration = {this.Expiration ?? "null"}");
            toStringOutput.Add($"ExpirationTimeShift = {(this.ExpirationTimeShift == null ? "null" : this.ExpirationTimeShift.ToString())}");
            toStringOutput.Add($"VirtualBankAccountsThreshold = {(this.VirtualBankAccountsThreshold == null ? "null" : this.VirtualBankAccountsThreshold.ToString())}");
            toStringOutput.Add($"VirtualBankAccountsFetchCount = {(this.VirtualBankAccountsFetchCount == null ? "null" : this.VirtualBankAccountsFetchCount.ToString())}");
            toStringOutput.Add($"DefaultExtensionPeriod = {this.DefaultExtensionPeriod ?? "null"}");
            toStringOutput.Add($"MaximumExtensionPeriod = {this.MaximumExtensionPeriod ?? "null"}");
            toStringOutput.Add($"AutomaticExtensionEnabled = {(this.AutomaticExtensionEnabled == null ? "null" : this.AutomaticExtensionEnabled.ToString())}");
            toStringOutput.Add($"ChargeRequestNotificationEnabled = {(this.ChargeRequestNotificationEnabled == null ? "null" : this.ChargeRequestNotificationEnabled.ToString())}");
            toStringOutput.Add($"ChargeRequestCanceledNotificationEnabled = {(this.ChargeRequestCanceledNotificationEnabled == null ? "null" : this.ChargeRequestCanceledNotificationEnabled.ToString())}");
            toStringOutput.Add($"ChargeExpiredNotificationEnabled = {(this.ChargeExpiredNotificationEnabled == null ? "null" : this.ChargeExpiredNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositReceivedNotificationEnabled = {(this.DepositReceivedNotificationEnabled == null ? "null" : this.DepositReceivedNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositInsufficientNotificationEnabled = {(this.DepositInsufficientNotificationEnabled == null ? "null" : this.DepositInsufficientNotificationEnabled.ToString())}");
            toStringOutput.Add($"DepositExceededNotificationEnabled = {(this.DepositExceededNotificationEnabled == null ? "null" : this.DepositExceededNotificationEnabled.ToString())}");
            toStringOutput.Add($"ExtensionNotificationEnabled = {(this.ExtensionNotificationEnabled == null ? "null" : this.ExtensionNotificationEnabled.ToString())}");
            toStringOutput.Add($"RemindNotificationPeriod = {this.RemindNotificationPeriod ?? "null"}");
            toStringOutput.Add($"RemindNotificationEnabled = {(this.RemindNotificationEnabled == null ? "null" : this.RemindNotificationEnabled.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}