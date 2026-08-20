// <copyright file="DirectDebitDebitDate.cs" company="APIMatic">
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
    /// DirectDebitDebitDate.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitDebitDate
    {
        /// <summary>
        /// Fourteen.
        /// </summary>
        [EnumMember(Value = "fourteen")]
        Fourteen,

        /// <summary>
        /// TwentySeven.
        /// </summary>
        [EnumMember(Value = "twenty_seven")]
        TwentySeven
    }
}