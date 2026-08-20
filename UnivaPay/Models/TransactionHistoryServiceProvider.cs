// <copyright file="TransactionHistoryServiceProvider.cs" company="APIMatic">
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
    /// TransactionHistoryServiceProvider.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionHistoryServiceProvider
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// Convenience.
        /// </summary>
        [EnumMember(Value = "convenience")]
        Convenience,

        /// <summary>
        /// BankTransfer.
        /// </summary>
        [EnumMember(Value = "bank_transfer")]
        BankTransfer,

        /// <summary>
        /// Paidy.
        /// </summary>
        [EnumMember(Value = "paidy")]
        Paidy,

        /// <summary>
        /// PayPay.
        /// </summary>
        [EnumMember(Value = "pay_pay")]
        PayPay,

        /// <summary>
        /// Alipay.
        /// </summary>
        [EnumMember(Value = "alipay")]
        Alipay,

        /// <summary>
        /// WeChat.
        /// </summary>
        [EnumMember(Value = "we_chat")]
        WeChat,

        /// <summary>
        /// Docomo.
        /// </summary>
        [EnumMember(Value = "docomo")]
        Docomo,

        /// <summary>
        /// Mercari.
        /// </summary>
        [EnumMember(Value = "mercari")]
        Mercari,

        /// <summary>
        /// Au.
        /// </summary>
        [EnumMember(Value = "au")]
        Au,

        /// <summary>
        /// Rakuten.
        /// </summary>
        [EnumMember(Value = "rakuten")]
        Rakuten,

        /// <summary>
        /// Bartong.
        /// </summary>
        [EnumMember(Value = "bartong")]
        Bartong,

        /// <summary>
        /// Jkopay.
        /// </summary>
        [EnumMember(Value = "jkopay")]
        Jkopay,

        /// <summary>
        /// GinkoPay.
        /// </summary>
        [EnumMember(Value = "ginko_pay")]
        GinkoPay,

        /// <summary>
        /// AeonPay.
        /// </summary>
        [EnumMember(Value = "aeon_pay")]
        AeonPay,

        /// <summary>
        /// Eromnet.
        /// </summary>
        [EnumMember(Value = "eromnet")]
        Eromnet,

        /// <summary>
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test
    }
}