// <copyright file="TransactionHistoryChargeType.cs" company="APIMatic">
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
    /// TransactionHistoryChargeType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionHistoryChargeType
    {
        /// <summary>
        /// Normal.
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// CvvAuth.
        /// </summary>
        [EnumMember(Value = "cvv_auth")]
        CvvAuth
    }
}