// <copyright file="DirectDebitBankTransferError.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnivaPay.Models
{
    /// <summary>
    /// DirectDebitBankTransferError.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitBankTransferError
    {
        /// <summary>
        /// InsufficientFunds.
        /// </summary>
        [EnumMember(Value = "insufficient_funds")]
        InsufficientFunds,

        /// <summary>
        /// NoDepositTransaction.
        /// </summary>
        [EnumMember(Value = "no_deposit_transaction")]
        NoDepositTransaction,

        /// <summary>
        /// TransferStoppedByDepositor.
        /// </summary>
        [EnumMember(Value = "transfer_stopped_by_depositor")]
        TransferStoppedByDepositor,

        /// <summary>
        /// NoAccountTransferRequest.
        /// </summary>
        [EnumMember(Value = "no_account_transfer_request")]
        NoAccountTransferRequest,

        /// <summary>
        /// TransferStoppedByTrustee.
        /// </summary>
        [EnumMember(Value = "transfer_stopped_by_trustee")]
        TransferStoppedByTrustee,

        /// <summary>
        /// OtherError.
        /// </summary>
        [EnumMember(Value = "other_error")]
        OtherError,

        /// <summary>
        /// UnknownError.
        /// </summary>
        [EnumMember(Value = "unknown_error")]
        UnknownError
    }
}