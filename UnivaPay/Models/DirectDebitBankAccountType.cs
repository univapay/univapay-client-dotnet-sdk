// <copyright file="DirectDebitBankAccountType.cs" company="APIMatic">
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
    /// DirectDebitBankAccountType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitBankAccountType
    {
        /// <summary>
        /// Regular.
        /// </summary>
        [EnumMember(Value = "regular")]
        Regular,

        /// <summary>
        /// Current.
        /// </summary>
        [EnumMember(Value = "current")]
        Current,

        /// <summary>
        /// Savings.
        /// </summary>
        [EnumMember(Value = "savings")]
        Savings,

        /// <summary>
        /// Others.
        /// </summary>
        [EnumMember(Value = "others")]
        Others
    }
}