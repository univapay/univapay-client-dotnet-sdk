// <copyright file="CheckoutThemeColors.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// CheckoutThemeColors.
    /// </summary>
    public class CheckoutThemeColors
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThemeColors"/> class.
        /// </summary>
        public CheckoutThemeColors()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutThemeColors"/> class.
        /// </summary>
        /// <param name="mainBackground">main_background.</param>
        /// <param name="secondaryBackground">secondary_background.</param>
        /// <param name="mainColor">main_color.</param>
        /// <param name="mainText">main_text.</param>
        /// <param name="primaryText">primary_text.</param>
        /// <param name="secondaryText">secondary_text.</param>
        /// <param name="baseText">base_text.</param>
        /// <param name="bodyBackground">body_background.</param>
        public CheckoutThemeColors(
            string mainBackground = null,
            string secondaryBackground = null,
            string mainColor = null,
            string mainText = null,
            string primaryText = null,
            string secondaryText = null,
            string baseText = null,
            string bodyBackground = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.MainBackground = mainBackground;
            this.SecondaryBackground = secondaryBackground;
            this.MainColor = mainColor;
            this.MainText = mainText;
            this.PrimaryText = primaryText;
            this.SecondaryText = secondaryText;
            this.BaseText = baseText;
            this.BodyBackground = bodyBackground;
        }

        /// <summary>
        /// Main background color.
        /// </summary>
        [JsonProperty("main_background", NullValueHandling = NullValueHandling.Ignore)]
        public string MainBackground { get; set; }

        /// <summary>
        /// Secondary background color.
        /// </summary>
        [JsonProperty("secondary_background", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryBackground { get; set; }

        /// <summary>
        /// Main accent color.
        /// </summary>
        [JsonProperty("main_color", NullValueHandling = NullValueHandling.Ignore)]
        public string MainColor { get; set; }

        /// <summary>
        /// Main text color.
        /// </summary>
        [JsonProperty("main_text", NullValueHandling = NullValueHandling.Ignore)]
        public string MainText { get; set; }

        /// <summary>
        /// Primary text color.
        /// </summary>
        [JsonProperty("primary_text", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryText { get; set; }

        /// <summary>
        /// Secondary text color.
        /// </summary>
        [JsonProperty("secondary_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryText { get; set; }

        /// <summary>
        /// Base text color.
        /// </summary>
        [JsonProperty("base_text", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseText { get; set; }

        /// <summary>
        /// Body background color.
        /// </summary>
        [JsonProperty("body_background", NullValueHandling = NullValueHandling.Ignore)]
        public string BodyBackground { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CheckoutThemeColors : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MainBackground = {this.MainBackground ?? "null"}");
            toStringOutput.Add($"SecondaryBackground = {this.SecondaryBackground ?? "null"}");
            toStringOutput.Add($"MainColor = {this.MainColor ?? "null"}");
            toStringOutput.Add($"MainText = {this.MainText ?? "null"}");
            toStringOutput.Add($"PrimaryText = {this.PrimaryText ?? "null"}");
            toStringOutput.Add($"SecondaryText = {this.SecondaryText ?? "null"}");
            toStringOutput.Add($"BaseText = {this.BaseText ?? "null"}");
            toStringOutput.Add($"BodyBackground = {this.BodyBackground ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}