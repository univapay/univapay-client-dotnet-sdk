// <copyright file="DirectDebitSchedule.cs" company="APIMatic">
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
    /// DirectDebitSchedule.
    /// </summary>
    public class DirectDebitSchedule
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
        /// Initializes a new instance of the <see cref="DirectDebitSchedule"/> class.
        /// </summary>
        public DirectDebitSchedule()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitSchedule"/> class.
        /// </summary>
        /// <param name="merchantBankAccountTransferDate">merchant_bank_account_transfer_date.</param>
        /// <param name="merchantBankAccountRegistrationDeadline">merchant_bank_account_registration_deadline.</param>
        /// <param name="merchantBankTransferUploadDeadline">merchant_bank_transfer_upload_deadline.</param>
        /// <param name="platformResultRegistrationDate">platform_result_registration_date.</param>
        /// <param name="platformScheduledPayout">platform_scheduled_payout.</param>
        public DirectDebitSchedule(
            DateTime? merchantBankAccountTransferDate = null,
            DateTime? merchantBankAccountRegistrationDeadline = null,
            DateTime? merchantBankTransferUploadDeadline = null,
            DateTime? platformResultRegistrationDate = null,
            DateTime? platformScheduledPayout = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.MerchantBankAccountTransferDate = merchantBankAccountTransferDate;
            this.MerchantBankAccountRegistrationDeadline = merchantBankAccountRegistrationDeadline;
            this.MerchantBankTransferUploadDeadline = merchantBankTransferUploadDeadline;
            this.PlatformResultRegistrationDate = platformResultRegistrationDate;
            this.PlatformScheduledPayout = platformScheduledPayout;
        }

        /// <summary>
        /// The date funds are pulled from consumer accounts (指定振替日).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("merchant_bank_account_transfer_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MerchantBankAccountTransferDate { get; set; }

        /// <summary>
        /// The date by which the bank must receive the signed direct debit mandate (振替依頼書到着期限).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("merchant_bank_account_registration_deadline", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MerchantBankAccountRegistrationDeadline { get; set; }

        /// <summary>
        /// The last date transfers can be registered or edited for this cycle (振替データアップロード期限). After this, transfers lock.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("merchant_bank_transfer_upload_deadline", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MerchantBankTransferUploadDeadline { get; set; }

        /// <summary>
        /// The date transfer results are reflected on the platform (振替結果反映日).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("platform_result_registration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlatformResultRegistrationDate { get; set; }

        /// <summary>
        /// The date collected funds are paid out to the merchant (支払日).
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("platform_scheduled_payout", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlatformScheduledPayout { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DirectDebitSchedule : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MerchantBankAccountTransferDate = {(this.MerchantBankAccountTransferDate == null ? "null" : this.MerchantBankAccountTransferDate.ToString())}");
            toStringOutput.Add($"MerchantBankAccountRegistrationDeadline = {(this.MerchantBankAccountRegistrationDeadline == null ? "null" : this.MerchantBankAccountRegistrationDeadline.ToString())}");
            toStringOutput.Add($"MerchantBankTransferUploadDeadline = {(this.MerchantBankTransferUploadDeadline == null ? "null" : this.MerchantBankTransferUploadDeadline.ToString())}");
            toStringOutput.Add($"PlatformResultRegistrationDate = {(this.PlatformResultRegistrationDate == null ? "null" : this.PlatformResultRegistrationDate.ToString())}");
            toStringOutput.Add($"PlatformScheduledPayout = {(this.PlatformScheduledPayout == null ? "null" : this.PlatformScheduledPayout.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}