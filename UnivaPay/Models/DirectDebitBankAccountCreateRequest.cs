// <copyright file="DirectDebitBankAccountCreateRequest.cs" company="APIMatic">
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
    /// DirectDebitBankAccountCreateRequest.
    /// </summary>
    public class DirectDebitBankAccountCreateRequest
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
        /// Initializes a new instance of the <see cref="DirectDebitBankAccountCreateRequest"/> class.
        /// </summary>
        public DirectDebitBankAccountCreateRequest()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitBankAccountCreateRequest"/> class.
        /// </summary>
        /// <param name="userNumber">user_number.</param>
        /// <param name="bankCode">bank_code.</param>
        /// <param name="bankName">bank_name.</param>
        /// <param name="branchCode">branch_code.</param>
        /// <param name="bankAccountType">bank_account_type.</param>
        /// <param name="bankAccountName">bank_account_name.</param>
        /// <param name="bankAccountNumber">bank_account_number.</param>
        public DirectDebitBankAccountCreateRequest(
            string userNumber,
            string bankCode,
            string bankName,
            string branchCode,
            Models.DirectDebitBankAccountType bankAccountType,
            string bankAccountName,
            string bankAccountNumber)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.UserNumber = userNumber;
            this.BankCode = bankCode;
            this.BankName = bankName;
            this.BranchCode = branchCode;
            this.BankAccountType = bankAccountType;
            this.BankAccountName = bankAccountName;
            this.BankAccountNumber = bankAccountNumber;
        }

        /// <summary>
        /// The merchant's own membership number for the consumer (会員番号). Alphanumeric.
        /// </summary>
        [JsonProperty("user_number")]
        public string UserNumber { get; set; }

        /// <summary>
        /// Four-digit code identifying the consumer's bank (銀行コード).
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Bank name in half-width katakana (銀行名).
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Three-digit code identifying the bank branch (支店コード).
        /// </summary>
        [JsonProperty("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Deposit account type (預金種類) — `regular` (普通), `current` (当座), `savings` (貯蓄) or `others` (その他).
        /// </summary>
        [JsonProperty("bank_account_type")]
        public Models.DirectDebitBankAccountType BankAccountType { get; set; }

        /// <summary>
        /// Account holder name (口座名義), in half-width katakana. Full-width characters are rejected by the bank.
        /// </summary>
        [JsonProperty("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// Seven-digit account number (口座番号).
        /// </summary>
        [JsonProperty("bank_account_number")]
        public string BankAccountNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DirectDebitBankAccountCreateRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"UserNumber = {this.UserNumber ?? "null"}");
            toStringOutput.Add($"BankCode = {this.BankCode ?? "null"}");
            toStringOutput.Add($"BankName = {this.BankName ?? "null"}");
            toStringOutput.Add($"BranchCode = {this.BranchCode ?? "null"}");
            toStringOutput.Add($"BankAccountType = {this.BankAccountType}");
            toStringOutput.Add($"BankAccountName = {this.BankAccountName ?? "null"}");
            toStringOutput.Add($"BankAccountNumber = {this.BankAccountNumber ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}