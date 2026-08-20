// <copyright file="CheckoutRecurringTokenPrivilege.cs" company="APIMatic">
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
    /// CheckoutRecurringTokenPrivilege.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckoutRecurringTokenPrivilege
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Bounded.
        /// </summary>
        [EnumMember(Value = "bounded")]
        Bounded,

        /// <summary>
        /// Infinite.
        /// </summary>
        [EnumMember(Value = "infinite")]
        Infinite
    }
}