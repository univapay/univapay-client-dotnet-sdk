// <copyright file="TransactionTokenCreateRequestData.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace UnivaPay.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TransactionTokenCreateRequestData>),
        new[] {
            typeof(TokenCreateCardDataCase),
            typeof(TokenCreateKonbiniDataCase),
            typeof(TokenCreateOnlineDataCase),
            typeof(TokenCreateBankTransferDataCase),
            typeof(TokenCreatePaidyDataCase),
            typeof(TokenCreateQrScanDataCase),
            typeof(TokenCreateQrMerchantDataCase)
        },
        false
    )]
    public abstract class TransactionTokenCreateRequestData
    {
        /// <summary>
        /// This is TokenCreateCardData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateCardData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateCardData(TokenCreateCardData tokenCreateCardData)
        {
            return new TokenCreateCardDataCase().Set(tokenCreateCardData);
        }

        /// <summary>
        /// This is TokenCreateKonbiniData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateKonbiniData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateKonbiniData(TokenCreateKonbiniData tokenCreateKonbiniData)
        {
            return new TokenCreateKonbiniDataCase().Set(tokenCreateKonbiniData);
        }

        /// <summary>
        /// This is TokenCreateOnlineData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateOnlineData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateOnlineData(TokenCreateOnlineData tokenCreateOnlineData)
        {
            return new TokenCreateOnlineDataCase().Set(tokenCreateOnlineData);
        }

        /// <summary>
        /// This is TokenCreateBankTransferData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateBankTransferData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateBankTransferData(TokenCreateBankTransferData tokenCreateBankTransferData)
        {
            return new TokenCreateBankTransferDataCase().Set(tokenCreateBankTransferData);
        }

        /// <summary>
        /// This is TokenCreatePaidyData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreatePaidyData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreatePaidyData(TokenCreatePaidyData tokenCreatePaidyData)
        {
            return new TokenCreatePaidyDataCase().Set(tokenCreatePaidyData);
        }

        /// <summary>
        /// This is TokenCreateQrScanData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateQrScanData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateQrScanData(TokenCreateQrScanData tokenCreateQrScanData)
        {
            return new TokenCreateQrScanDataCase().Set(tokenCreateQrScanData);
        }

        /// <summary>
        /// This is TokenCreateQrMerchantData case.
        /// </summary>
        /// <returns>
        /// The TransactionTokenCreateRequestData instance, wrapping the provided TokenCreateQrMerchantData value.
        /// </returns>
        public static TransactionTokenCreateRequestData FromTokenCreateQrMerchantData(TokenCreateQrMerchantData tokenCreateQrMerchantData)
        {
            return new TokenCreateQrMerchantDataCase().Set(tokenCreateQrMerchantData);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<TokenCreateCardData, T> tokenCreateCardData,
            Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
            Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
            Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
            Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
            Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
            Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData);

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<TokenCreateCardData, T> tokenCreateCardData = null,
            Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData = null,
            Func<TokenCreateOnlineData, T> tokenCreateOnlineData = null,
            Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData = null,
            Func<TokenCreatePaidyData, T> tokenCreatePaidyData = null,
            Func<TokenCreateQrScanData, T> tokenCreateQrScanData = null,
            Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData = null) =>
                Match(tokenCreateCardData, tokenCreateKonbiniData, tokenCreateOnlineData, tokenCreateBankTransferData, tokenCreatePaidyData, tokenCreateQrScanData, tokenCreateQrMerchantData);

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateCardDataCase, TokenCreateCardData>))]
        private sealed class TokenCreateCardDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateCardDataCase, TokenCreateCardData>
        {
            public TokenCreateCardData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateCardData != null ? tokenCreateCardData(Value) : default;

            public TokenCreateCardDataCase Set(TokenCreateCardData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateCardData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateKonbiniDataCase, TokenCreateKonbiniData>))]
        private sealed class TokenCreateKonbiniDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateKonbiniDataCase, TokenCreateKonbiniData>
        {
            public TokenCreateKonbiniData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateKonbiniData != null ? tokenCreateKonbiniData(Value) : default;

            public TokenCreateKonbiniDataCase Set(TokenCreateKonbiniData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateKonbiniData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateOnlineDataCase, TokenCreateOnlineData>))]
        private sealed class TokenCreateOnlineDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateOnlineDataCase, TokenCreateOnlineData>
        {
            public TokenCreateOnlineData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateOnlineData != null ? tokenCreateOnlineData(Value) : default;

            public TokenCreateOnlineDataCase Set(TokenCreateOnlineData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateOnlineData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateBankTransferDataCase, TokenCreateBankTransferData>))]
        private sealed class TokenCreateBankTransferDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateBankTransferDataCase, TokenCreateBankTransferData>
        {
            public TokenCreateBankTransferData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateBankTransferData != null ? tokenCreateBankTransferData(Value) : default;

            public TokenCreateBankTransferDataCase Set(TokenCreateBankTransferData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateBankTransferData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreatePaidyDataCase, TokenCreatePaidyData>))]
        private sealed class TokenCreatePaidyDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreatePaidyDataCase, TokenCreatePaidyData>
        {
            public TokenCreatePaidyData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreatePaidyData != null ? tokenCreatePaidyData(Value) : default;

            public TokenCreatePaidyDataCase Set(TokenCreatePaidyData value)
            {
                Value = value;
                return this;
            }

            public TokenCreatePaidyData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateQrScanDataCase, TokenCreateQrScanData>))]
        private sealed class TokenCreateQrScanDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateQrScanDataCase, TokenCreateQrScanData>
        {
            public TokenCreateQrScanData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateQrScanData != null ? tokenCreateQrScanData(Value) : default;

            public TokenCreateQrScanDataCase Set(TokenCreateQrScanData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateQrScanData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TokenCreateQrMerchantDataCase, TokenCreateQrMerchantData>))]
        private sealed class TokenCreateQrMerchantDataCase : TransactionTokenCreateRequestData, ICaseValue<TokenCreateQrMerchantDataCase, TokenCreateQrMerchantData>
        {
            public TokenCreateQrMerchantData Value;

            public override T Match<T>(
                Func<TokenCreateCardData, T> tokenCreateCardData,
                Func<TokenCreateKonbiniData, T> tokenCreateKonbiniData,
                Func<TokenCreateOnlineData, T> tokenCreateOnlineData,
                Func<TokenCreateBankTransferData, T> tokenCreateBankTransferData,
                Func<TokenCreatePaidyData, T> tokenCreatePaidyData,
                Func<TokenCreateQrScanData, T> tokenCreateQrScanData,
                Func<TokenCreateQrMerchantData, T> tokenCreateQrMerchantData) =>
                   tokenCreateQrMerchantData != null ? tokenCreateQrMerchantData(Value) : default;

            public TokenCreateQrMerchantDataCase Set(TokenCreateQrMerchantData value)
            {
                Value = value;
                return this;
            }

            public TokenCreateQrMerchantData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }
    }
}