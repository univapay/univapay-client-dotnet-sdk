// <copyright file="DirectDebitBankAccountStatus.cs" company="APIMatic">
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
    /// DirectDebitBankAccountStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitBankAccountStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Inactive.
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// RegistrationFailed.
        /// </summary>
        [EnumMember(Value = "registration_failed")]
        RegistrationFailed
    }
}