// <copyright file="CheckoutPaymentType.cs" company="APIMatic">
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
    /// CheckoutPaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckoutPaymentType
    {
        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "card")]
        Card,

        /// <summary>
        /// QrScan.
        /// </summary>
        [EnumMember(Value = "qr_scan")]
        QrScan,

        /// <summary>
        /// QrMerchant.
        /// </summary>
        [EnumMember(Value = "qr_merchant")]
        QrMerchant,

        /// <summary>
        /// Konbini.
        /// </summary>
        [EnumMember(Value = "konbini")]
        Konbini,

        /// <summary>
        /// ApplePay.
        /// </summary>
        [EnumMember(Value = "apple_pay")]
        ApplePay,

        /// <summary>
        /// Paidy.
        /// </summary>
        [EnumMember(Value = "paidy")]
        Paidy,

        /// <summary>
        /// Online.
        /// </summary>
        [EnumMember(Value = "online")]
        Online,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "bank_transfer")]
        BankTransfer
    }
}