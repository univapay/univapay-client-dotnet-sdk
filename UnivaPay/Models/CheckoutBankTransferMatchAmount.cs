// <copyright file="CheckoutBankTransferMatchAmount.cs" company="APIMatic">
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
    /// CheckoutBankTransferMatchAmount.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckoutBankTransferMatchAmount
    {
        /// <summary>
        /// Exact.
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact,

        /// <summary>
        /// Maximum.
        /// </summary>
        [EnumMember(Value = "maximum")]
        Maximum,

        /// <summary>
        /// Minimum.
        /// </summary>
        [EnumMember(Value = "minimum")]
        Minimum,

        /// <summary>
        /// Disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled
    }
}