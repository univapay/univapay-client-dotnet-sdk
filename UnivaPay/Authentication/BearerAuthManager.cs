// <copyright file="BearerAuthManager.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using APIMatic.Core.Authentication;

namespace UnivaPay.Authentication
{
    /// <summary>
    /// BearerAuthManager.
    /// </summary>
    internal class BearerAuthManager : AuthManager, IBearerAuthCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuthManager"/> class.
        /// </summary>
        /// <param name="bearerAuthModel">BearerAuthModel.</param>
        public BearerAuthManager(BearerAuthModel bearerAuthModel)
        {
            this.SecretKey = bearerAuthModel?.SecretKey;
            this.JwtToken = bearerAuthModel?.JwtToken;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("Authorization",
                    this.SecretKey == null || this.JwtToken == null
                        ? null
                        : $"Bearer {this.SecretKey}.{this.JwtToken}"
                ).Required()));
        }

        /// <summary>
        /// Gets string value for secretKey.
        /// </summary>
        public string SecretKey { get; }

        /// <summary>
        /// Gets string value for jwtToken.
        /// </summary>
        public string JwtToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="secretKey"> The string value for the secret key.</param>
        /// <param name="jwtToken"> The string value for the JWT token.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string secretKey, string jwtToken)
        {
            return secretKey.Equals(this.SecretKey) && jwtToken.Equals(this.JwtToken);
        }

    }

    public sealed class BearerAuthModel
    {
        internal BearerAuthModel()
        {
        }

        internal string SecretKey { get; set; }

        internal string JwtToken { get; set; }

        /// <summary>
        /// Creates an object of the BearerAuthModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(SecretKey, JwtToken);
        }

        /// <summary>
        /// Builder class for BearerAuthModel.
        /// </summary>
        public class Builder
        {
            private string secretKey;
            private string jwtToken;

            public Builder(string secretKey, string jwtToken)
            {
                this.secretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
                this.jwtToken = jwtToken ?? throw new ArgumentNullException(nameof(jwtToken));
            }

            /// <summary>
            /// Single-token overload retained only so the generated
            /// CreateFromEnvironment branch that reads UNIVA_PAY_ACCESS_TOKEN still
            /// compiles. This SDK authenticates with a secret key plus a JWT token, so
            /// that branch is inert and this constructor is never reached. Internal, so
            /// it adds nothing to the public surface. Keeping the generated code
            /// untouched matters: it sits beside the base-URL block codegen rewrites
            /// whenever the server list changes.
            /// </summary>
            internal Builder(string accessToken) =>
                throw new NotSupportedException(
                    "This SDK requires a secret key and a JWT token. Use Builder(secretKey, jwtToken).");

            /// <summary>
            /// Sets SecretKey.
            /// </summary>
            /// <param name="secretKey">SecretKey.</param>
            /// <returns>Builder.</returns>
            public Builder SecretKey(string secretKey)
            {
                this.secretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
                return this;
            }

            /// <summary>
            /// Sets JwtToken.
            /// </summary>
            /// <param name="jwtToken">JwtToken.</param>
            /// <returns>Builder.</returns>
            public Builder JwtToken(string jwtToken)
            {
                this.jwtToken = jwtToken ?? throw new ArgumentNullException(nameof(jwtToken));
                return this;
            }

            /// <summary>
            /// Creates an object of the BearerAuthModel using the values provided for the builder.
            /// </summary>
            /// <returns>BearerAuthModel.</returns>
            public BearerAuthModel Build()
            {
                return new BearerAuthModel()
                {
                    SecretKey = this.secretKey,
                    JwtToken = this.jwtToken
                };
            }
        }

        internal static BearerAuthModel FromOptions(BearerAuthModelOptions options)
        {
            var builder = new Builder(options.SecretKey, options.JwtToken);
            return builder.Build();
        }
    }

    public class BearerAuthModelOptions
    {
        public string SecretKey { get; set; }

        public string JwtToken { get; set; }
    }
}