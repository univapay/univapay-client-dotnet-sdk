// <copyright file="CheckoutMode.cs" company="APIMatic">
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
    /// CheckoutMode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CheckoutMode
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test,

        /// <summary>
        /// LiveTest.
        /// </summary>
        [EnumMember(Value = "live_test")]
        LiveTest
    }
}