// <copyright file="SubscriptionThreeDsMode.cs" company="APIMatic">
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
    /// SubscriptionThreeDsMode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionThreeDsMode
    {
        /// <summary>
        /// Normal.
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// Require.
        /// </summary>
        [EnumMember(Value = "require")]
        Require,

        /// <summary>
        /// Force.
        /// </summary>
        [EnumMember(Value = "force")]
        Force,

        /// <summary>
        /// Skip.
        /// </summary>
        [EnumMember(Value = "skip")]
        Skip,

        /// <summary>
        /// IfAvailable.
        /// </summary>
        [EnumMember(Value = "if_available")]
        IfAvailable,

        /// <summary>
        /// Provided.
        /// </summary>
        [EnumMember(Value = "provided")]
        Provided
    }
}