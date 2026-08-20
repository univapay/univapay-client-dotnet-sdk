// <copyright file="SubscriptionSimulationPeriod.cs" company="APIMatic">
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
    /// SubscriptionSimulationPeriod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSimulationPeriod
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,

        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,

        /// <summary>
        /// Biweekly.
        /// </summary>
        [EnumMember(Value = "biweekly")]
        Biweekly,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,

        /// <summary>
        /// Bimonthly.
        /// </summary>
        [EnumMember(Value = "bimonthly")]
        Bimonthly,

        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,

        /// <summary>
        /// Semiannually.
        /// </summary>
        [EnumMember(Value = "semiannually")]
        Semiannually,

        /// <summary>
        /// Annually.
        /// </summary>
        [EnumMember(Value = "annually")]
        Annually
    }
}