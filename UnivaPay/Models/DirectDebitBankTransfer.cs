// <copyright file="DirectDebitBankTransfer.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// DirectDebitBankTransfer.
    /// </summary>
    public class DirectDebitBankTransfer
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

        private Models.DirectDebitBankTransferError? error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitBankTransfer"/> class.
        /// </summary>
        public DirectDebitBankTransfer()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitBankTransfer"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="legacyStoreId">legacy_store_id.</param>
        /// <param name="merchantId">merchant_id.</param>
        /// <param name="bankAccountId">bank_account_id.</param>
        /// <param name="userNumber">user_number.</param>
        /// <param name="bankCode">bank_code.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountName">bank_account_name.</param>
        /// <param name="bankAccountNumber">bank_account_number.</param>
        /// <param name="amount">amount.</param>
        /// <param name="debitDate">debit_date.</param>
        /// <param name="calculatedDebitDate">calculated_debit_date.</param>
        /// <param name="mLock">lock.</param>
        /// <param name="status">status.</param>
        /// <param name="error">error.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="updatedOn">updated_on.</param>
        public DirectDebitBankTransfer(
            string id = null,
            string legacyStoreId = null,
            Guid? merchantId = null,
            string bankAccountId = null,
            string userNumber = null,
            string bankCode = null,
            string bankName = null,
            string branchCode = null,
            Models.DirectDebitBankAccountType? bankAccountType = null,
            string bankAccountName = null,
            string bankAccountNumber = null,
            long? amount = null,
            Models.DirectDebitDebitDate? debitDate = null,
            DateTime? calculatedDebitDate = null,
            Models.DirectDebitBankTransferLock? mLock = null,
            Models.DirectDebitBankTransferStatus? status = null,
            Models.DirectDebitBankTransferError? error = null,
            DateTime? createdOn = null,
            DateTime? updatedOn = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.Id = id;
            this.LegacyStoreId = legacyStoreId;
            this.MerchantId = merchantId;
            this.BankAccountId = bankAccountId;
            this.UserNumber = userNumber;
            this.BankCode = bankCode;
            this.BankName = bankName;
            this.BranchCode = branchCode;
            this.BankAccountType = bankAccountType;
            this.BankAccountName = bankAccountName;
            this.BankAccountNumber = bankAccountNumber;
            this.Amount = amount;
            this.DebitDate = debitDate;
            this.CalculatedDebitDate = calculatedDebitDate;
            this.MLock = mLock;
            this.Status = status;

            if (error != null)
            {
                this.Error = error;
            }
            this.CreatedOn = createdOn;
            this.UpdatedOn = updatedOn;
        }

        /// <summary>
        /// Unique identifier of a direct debit bank transfer (振替ID).
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier of the merchant in the legacy direct debit system.
        /// </summary>
        [JsonProperty("legacy_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LegacyStoreId { get; set; }

        /// <summary>
        /// The merchant that owns this transfer.
        /// </summary>
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MerchantId { get; set; }

        /// <summary>
        /// Unique identifier of a direct debit bank account (銀行口座ID).
        /// </summary>
        [JsonProperty("bank_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountId { get; set; }

        /// <summary>
        /// The merchant's own membership number for the consumer (会員番号). Alphanumeric.
        /// </summary>
        [JsonProperty("user_number", NullValueHandling = NullValueHandling.Ignore)]
        public string UserNumber { get; set; }

        /// <summary>
        /// Four-digit code identifying the consumer's bank (銀行コード).
        /// </summary>
        [JsonProperty("bank_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCode { get; set; }

        /// <summary>
        /// Bank name in half-width katakana (銀行名).
        /// </summary>
        [JsonProperty("bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankName { get; set; }

        /// <summary>
        /// Three-digit code identifying the bank branch (支店コード).
        /// </summary>
        [JsonProperty("branch_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Deposit account type (預金種類) — `regular` (普通), `current` (当座), `savings` (貯蓄) or `others` (その他).
        /// </summary>
        [JsonProperty("bank_account_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitBankAccountType? BankAccountType { get; set; }

        /// <summary>
        /// Account holder name (口座名義), in half-width katakana. Full-width characters are rejected by the bank.
        /// </summary>
        [JsonProperty("bank_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Seven-digit account number (口座番号).
        /// </summary>
        [JsonProperty("bank_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Transfer amount in JPY. Must be a positive, non-zero whole number.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        /// <summary>
        /// Monthly debit cycle — funds are pulled on either the 14th or the 27th.
        /// </summary>
        [JsonProperty("debit_date", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitDebitDate? DebitDate { get; set; }

        /// <summary>
        /// The actual business day on which funds are pulled (計算された振替日), derived from the debit cycle.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("calculated_debit_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CalculatedDebitDate { get; set; }

        /// <summary>
        /// Whether the transfer can still be edited. Transfers are `unlocked` until the upload deadline for their debit cycle passes, after which they are `locked` and can no longer be changed or deleted.
        /// </summary>
        [JsonProperty("lock", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitBankTransferLock? MLock { get; set; }

        /// <summary>
        /// Transfer state. `awaiting` until the bank reports back, then `successful` or `failed`. Results are reflected days after the debit date, not immediately.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitBankTransferStatus? Status { get; set; }

        /// <summary>
        /// Failure reason, or null while the transfer is awaiting a result or has succeeded.
        /// </summary>
        [JsonProperty("error")]
        public Models.DirectDebitBankTransferError? Error
        {
            get
            {
                return this.error;
            }

            set
            {
                this.shouldSerialize["error"] = true;
                this.error = value;
            }
        }

        /// <summary>
        /// Timestamp when the resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Timestamp when the resource was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DirectDebitBankTransfer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeError()
        {
            return this.shouldSerialize["error"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"LegacyStoreId = {this.LegacyStoreId ?? "null"}");
            toStringOutput.Add($"MerchantId = {(this.MerchantId == null ? "null" : this.MerchantId.ToString())}");
            toStringOutput.Add($"BankAccountId = {this.BankAccountId ?? "null"}");
            toStringOutput.Add($"UserNumber = {this.UserNumber ?? "null"}");
            toStringOutput.Add($"BankCode = {this.BankCode ?? "null"}");
            toStringOutput.Add($"BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"BranchCode = {this.BranchCode ?? "null"}");
            toStringOutput.Add($"BankAccountType = {(this.BankAccountType == null ? "null" : this.BankAccountType.ToString())}");
            toStringOutput.Add($"BankAccountName = {this.BankAccountName ?? "null"}");
            toStringOutput.Add($"BankAccountNumber = {this.BankAccountNumber ?? "null"}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"DebitDate = {(this.DebitDate == null ? "null" : this.DebitDate.ToString())}");
            toStringOutput.Add($"CalculatedDebitDate = {(this.CalculatedDebitDate == null ? "null" : this.CalculatedDebitDate.ToString())}");
            toStringOutput.Add($"MLock = {(this.MLock == null ? "null" : this.MLock.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"UpdatedOn = {(this.UpdatedOn == null ? "null" : this.UpdatedOn.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}