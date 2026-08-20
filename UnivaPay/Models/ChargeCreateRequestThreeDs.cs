// <copyright file="ChargeCreateRequestThreeDs.cs" company="APIMatic">
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
    /// ChargeCreateRequestThreeDs.
    /// </summary>
    public class ChargeCreateRequestThreeDs
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
        /// Initializes a new instance of the <see cref="ChargeCreateRequestThreeDs"/> class.
        /// </summary>
        public ChargeCreateRequestThreeDs()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeCreateRequestThreeDs"/> class.
        /// </summary>
        /// <param name="redirectEndpoint">redirect_endpoint.</param>
        /// <param name="mode">mode.</param>
        /// <param name="authenticationValue">authentication_value.</param>
        /// <param name="eci">eci.</param>
        /// <param name="dsTransactionId">ds_transaction_id.</param>
        /// <param name="serverTransactionId">server_transaction_id.</param>
        /// <param name="messageVersion">message_version.</param>
        /// <param name="transactionStatus">transaction_status.</param>
        public ChargeCreateRequestThreeDs(
            string redirectEndpoint = null,
            Models.ChargeCreateRequestThreeDsMode? mode = null,
            string authenticationValue = null,
            string eci = null,
            string dsTransactionId = null,
            string serverTransactionId = null,
            string messageVersion = null,
            string transactionStatus = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.RedirectEndpoint = redirectEndpoint;
            this.Mode = mode;
            this.AuthenticationValue = authenticationValue;
            this.Eci = eci;
            this.DsTransactionId = dsTransactionId;
            this.ServerTransactionId = serverTransactionId;
            this.MessageVersion = messageVersion;
            this.TransactionStatus = transactionStatus;
        }

        /// <summary>
        /// URL to redirect the customer to after 3DS authentication.
        /// </summary>
        [JsonProperty("redirect_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectEndpoint { get; set; }

        /// <summary>
        /// 3D-Secure authentication type. App Token Secret is required to use 'skip'. `if_available` enforces 3DS only if credentials are available for the recurring token and it has not already completed 3DS. `provided` is set automatically by the server when external MPI authentication data (`authentication_value`, `eci`, etc.) is submitted on the request and cannot be set manually. When omitted, the store's default 3DS policy applies — do not assume 'normal'.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeCreateRequestThreeDsMode? Mode { get; set; }

        /// <summary>
        /// External MPI: the cardholder authentication value (CAVV/AAV) returned by the 3-D Secure directory server. Submit together with `eci`, `ds_transaction_id`, `server_transaction_id`, `message_version`, and `transaction_status` to provide externally completed 3DS authentication data — either all six fields must be present, or none of them.
        /// </summary>
        [JsonProperty("authentication_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// External MPI: the two-digit Electronic Commerce Indicator returned by the directory server. Submit together with the other external MPI fields.
        /// </summary>
        [JsonProperty("eci", NullValueHandling = NullValueHandling.Ignore)]
        public string Eci { get; set; }

        /// <summary>
        /// External MPI: the directory server transaction ID. Submit together with the other external MPI fields.
        /// </summary>
        [JsonProperty("ds_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DsTransactionId { get; set; }

        /// <summary>
        /// External MPI: the 3DS server transaction ID. Submit together with the other external MPI fields.
        /// </summary>
        [JsonProperty("server_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerTransactionId { get; set; }

        /// <summary>
        /// External MPI: the 3-D Secure protocol message version (e.g., '2.1.0', '2.2.0'). Submit together with the other external MPI fields.
        /// </summary>
        [JsonProperty("message_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageVersion { get; set; }

        /// <summary>
        /// External MPI: the 3-D Secure directory server transaction status. Only a successful authentication status is accepted. Submit together with the other external MPI fields.
        /// </summary>
        [JsonProperty("transaction_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChargeCreateRequestThreeDs : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RedirectEndpoint = {this.RedirectEndpoint ?? "null"}");
            toStringOutput.Add($"Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
            toStringOutput.Add($"AuthenticationValue = {this.AuthenticationValue ?? "null"}");
            toStringOutput.Add($"Eci = {this.Eci ?? "null"}");
            toStringOutput.Add($"DsTransactionId = {this.DsTransactionId ?? "null"}");
            toStringOutput.Add($"ServerTransactionId = {this.ServerTransactionId ?? "null"}");
            toStringOutput.Add($"MessageVersion = {this.MessageVersion ?? "null"}");
            toStringOutput.Add($"TransactionStatus = {this.TransactionStatus ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}