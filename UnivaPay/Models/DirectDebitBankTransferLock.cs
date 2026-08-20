// <copyright file="DirectDebitBankTransferLock.cs" company="APIMatic">
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
    /// DirectDebitBankTransferLock.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitBankTransferLock
    {
        /// <summary>
        /// Unlocked.
        /// </summary>
        [EnumMember(Value = "unlocked")]
        Unlocked,

        /// <summary>
        /// Locked.
        /// </summary>
        [EnumMember(Value = "locked")]
        Locked
    }
}