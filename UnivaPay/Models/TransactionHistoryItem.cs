// <copyright file="TransactionHistoryItem.cs" company="APIMatic">
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
    /// TransactionHistoryItem.
    /// </summary>
    public class TransactionHistoryItem
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

        private Guid? chargeId;
        private Models.BankTransferPaymentStatus? bankTransferPaymentStatus;
        private DateTime? bankTransferLatestDepositDate;
        private Guid? mcpTokenId;
        private Models.TransactionHistoryChargeType? chargeType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "charge_id", false },
            { "bank_transfer_payment_status", false },
            { "bank_transfer_latest_deposit_date", false },
            { "mcp_token_id", false },
            { "charge_type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryItem"/> class.
        /// </summary>
        public TransactionHistoryItem()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryItem"/> class.
        /// </summary>
        /// <param name="storeId">store_id.</param>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="chargeId">charge_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="mode">mode.</param>
        /// <param name="merchantName">merchant_name.</param>
        /// <param name="storeName">store_name.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="userData">user_data.</param>
        /// <param name="bankTransferPaymentStatus">bank_transfer_payment_status.</param>
        /// <param name="bankTransferLatestDepositDate">bank_transfer_latest_deposit_date.</param>
        /// <param name="mcpTokenId">mcp_token_id.</param>
        /// <param name="chargeType">charge_type.</param>
        public TransactionHistoryItem(
            Guid? storeId = null,
            Guid? resourceId = null,
            Guid? chargeId = null,
            int? amount = null,
            string currency = null,
            double? amountFormatted = null,
            Models.TransactionHistoryType? type = null,
            Models.TransactionHistoryStatus? status = null,
            Models.GenericMetadata metadata = null,
            DateTime? createdOn = null,
            Models.TransactionHistoryMode? mode = null,
            string merchantName = null,
            string storeName = null,
            Models.TransactionHistoryPaymentType? paymentType = null,
            Models.TransactionHistoryUserData userData = null,
            Models.BankTransferPaymentStatus? bankTransferPaymentStatus = null,
            DateTime? bankTransferLatestDepositDate = null,
            Guid? mcpTokenId = null,
            Models.TransactionHistoryChargeType? chargeType = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.StoreId = storeId;
            this.ResourceId = resourceId;

            if (chargeId != null)
            {
                this.ChargeId = chargeId;
            }
            this.Amount = amount;
            this.Currency = currency;
            this.AmountFormatted = amountFormatted;
            this.Type = type;
            this.Status = status;
            this.Metadata = metadata;
            this.CreatedOn = createdOn;
            this.Mode = mode;
            this.MerchantName = merchantName;
            this.StoreName = storeName;
            this.PaymentType = paymentType;
            this.UserData = userData;

            if (bankTransferPaymentStatus != null)
            {
                this.BankTransferPaymentStatus = bankTransferPaymentStatus;
            }

            if (bankTransferLatestDepositDate != null)
            {
                this.BankTransferLatestDepositDate = bankTransferLatestDepositDate;
            }

            if (mcpTokenId != null)
            {
                this.McpTokenId = mcpTokenId;
            }

            if (chargeType != null)
            {
                this.ChargeType = chargeType;
            }
        }

        /// <summary>
        /// Store identifier.
        /// </summary>
        [JsonProperty("store_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StoreId { get; set; }

        /// <summary>
        /// ID of the underlying resource — a charge ID for charge rows, a refund ID for refund rows.
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// ID of the originating charge. `null` for charge rows; set for refund rows.
        /// </summary>
        [JsonProperty("charge_id")]
        public Guid? ChargeId
        {
            get
            {
                return this.chargeId;
            }

            set
            {
                this.shouldSerialize["charge_id"] = true;
                this.chargeId = value;
            }
        }

        /// <summary>
        /// Amount, in the currency's minor unit.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// ISO-4217 currency code.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Amount, formatted per the currency's display scale.
        /// </summary>
        [JsonProperty("amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountFormatted { get; set; }

        /// <summary>
        /// Whether this row represents a charge or a refund.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryType? Type { get; set; }

        /// <summary>
        /// Status of the underlying resource. Charge rows use the full set of values; refund rows only ever report `pending`, `successful`, `failed`, or `error`.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryStatus? Status { get; set; }

        /// <summary>
        /// A free-form dictionary for custom metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GenericMetadata Metadata { get; set; }

        /// <summary>
        /// Timestamp when the underlying resource was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Environment mode: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryMode? Mode { get; set; }

        /// <summary>
        /// Merchant display name.
        /// </summary>
        [JsonProperty("merchant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Store display name.
        /// </summary>
        [JsonProperty("store_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreName { get; set; }

        /// <summary>
        /// The payment method used for the underlying charge.
        /// </summary>
        [JsonProperty("payment_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryPaymentType? PaymentType { get; set; }

        /// <summary>
        /// Payment-type-specific details for this row. This is a single flat object covering every payment type — the fields actually populated depend on `payment_type` (documented per field below). Fields not applicable to a given payment type are omitted.
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionHistoryUserData UserData { get; set; }

        /// <summary>
        /// Bank transfer payment status, or `null` when not applicable.
        /// </summary>
        [JsonProperty("bank_transfer_payment_status")]
        public Models.BankTransferPaymentStatus? BankTransferPaymentStatus
        {
            get
            {
                return this.bankTransferPaymentStatus;
            }

            set
            {
                this.shouldSerialize["bank_transfer_payment_status"] = true;
                this.bankTransferPaymentStatus = value;
            }
        }

        /// <summary>
        /// Timestamp of the most recent deposit matched against a bank transfer charge. `null` when not applicable.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("bank_transfer_latest_deposit_date")]
        public DateTime? BankTransferLatestDepositDate
        {
            get
            {
                return this.bankTransferLatestDepositDate;
            }

            set
            {
                this.shouldSerialize["bank_transfer_latest_deposit_date"] = true;
                this.bankTransferLatestDepositDate = value;
            }
        }

        /// <summary>
        /// ID of the multi-currency-pricing token used, when applicable. `null` when not applicable.
        /// </summary>
        [JsonProperty("mcp_token_id")]
        public Guid? McpTokenId
        {
            get
            {
                return this.mcpTokenId;
            }

            set
            {
                this.shouldSerialize["mcp_token_id"] = true;
                this.mcpTokenId = value;
            }
        }

        /// <summary>
        /// Charge type, or `null` when not applicable.
        /// </summary>
        [JsonProperty("charge_type")]
        public Models.TransactionHistoryChargeType? ChargeType
        {
            get
            {
                return this.chargeType;
            }

            set
            {
                this.shouldSerialize["charge_type"] = true;
                this.chargeType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TransactionHistoryItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeId()
        {
            this.shouldSerialize["charge_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankTransferPaymentStatus()
        {
            this.shouldSerialize["bank_transfer_payment_status"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBankTransferLatestDepositDate()
        {
            this.shouldSerialize["bank_transfer_latest_deposit_date"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMcpTokenId()
        {
            this.shouldSerialize["mcp_token_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChargeType()
        {
            this.shouldSerialize["charge_type"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeId()
        {
            return this.shouldSerialize["charge_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankTransferPaymentStatus()
        {
            return this.shouldSerialize["bank_transfer_payment_status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBankTransferLatestDepositDate()
        {
            return this.shouldSerialize["bank_transfer_latest_deposit_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMcpTokenId()
        {
            return this.shouldSerialize["mcp_token_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChargeType()
        {
            return this.shouldSerialize["charge_type"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StoreId = {(this.StoreId == null ? "null" : this.StoreId.ToString())}");
            toStringOutput.Add($"ResourceId = {(this.ResourceId == null ? "null" : this.ResourceId.ToString())}");
            toStringOutput.Add($"ChargeId = {(this.ChargeId == null ? "null" : this.ChargeId.ToString())}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"AmountFormatted = {(this.AmountFormatted == null ? "null" : this.AmountFormatted.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"MerchantName = {this.MerchantName ?? "null"}");
            toStringOutput.Add($"StoreName = {this.StoreName ?? "null"}");
            toStringOutput.Add($"PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType.ToString())}");
            toStringOutput.Add($"UserData = {(this.UserData == null ? "null" : this.UserData.ToString())}");
            toStringOutput.Add($"BankTransferPaymentStatus = {(this.BankTransferPaymentStatus == null ? "null" : this.BankTransferPaymentStatus.ToString())}");
            toStringOutput.Add($"BankTransferLatestDepositDate = {(this.BankTransferLatestDepositDate == null ? "null" : this.BankTransferLatestDepositDate.ToString())}");
            toStringOutput.Add($"McpTokenId = {(this.McpTokenId == null ? "null" : this.McpTokenId.ToString())}");
            toStringOutput.Add($"ChargeType = {(this.ChargeType == null ? "null" : this.ChargeType.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}