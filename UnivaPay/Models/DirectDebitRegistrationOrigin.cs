// <copyright file="DirectDebitRegistrationOrigin.cs" company="APIMatic">
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
    /// DirectDebitRegistrationOrigin.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitRegistrationOrigin
    {
        /// <summary>
        /// Anywhere.
        /// </summary>
        [EnumMember(Value = "anywhere")]
        Anywhere,

        /// <summary>
        /// MerchantConsole.
        /// </summary>
        [EnumMember(Value = "merchant_console")]
        MerchantConsole
    }
}