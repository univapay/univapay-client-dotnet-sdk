// <copyright file="TransactionToken.cs" company="APIMatic">
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
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<TransactionToken>),
        new[] {
            typeof(CardTransactionTokenCase),
            typeof(KonbiniTransactionTokenCase),
            typeof(OnlineTransactionTokenCase),
            typeof(BankTransferTransactionTokenCase),
            typeof(PaidyTransactionTokenCase),
            typeof(QrScanTransactionTokenCase),
            typeof(QrMerchantTransactionTokenCase)
        },
        new[] {
            "card",
            "konbini",
            "online",
            "bank_transfer",
            "paidy",
            "qr_scan",
            "qr_merchant"
        },
        "payment_type",
        true
    )]
    public abstract class TransactionToken
    {
        /// <summary>
        /// This is CardTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided CardTransactionToken value.
        /// </returns>
        public static TransactionToken FromCardTransactionToken(CardTransactionToken cardTransactionToken)
        {
            return new CardTransactionTokenCase().Set(cardTransactionToken);
        }

        /// <summary>
        /// This is KonbiniTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided KonbiniTransactionToken value.
        /// </returns>
        public static TransactionToken FromKonbiniTransactionToken(KonbiniTransactionToken konbiniTransactionToken)
        {
            return new KonbiniTransactionTokenCase().Set(konbiniTransactionToken);
        }

        /// <summary>
        /// This is OnlineTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided OnlineTransactionToken value.
        /// </returns>
        public static TransactionToken FromOnlineTransactionToken(OnlineTransactionToken onlineTransactionToken)
        {
            return new OnlineTransactionTokenCase().Set(onlineTransactionToken);
        }

        /// <summary>
        /// This is BankTransferTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided BankTransferTransactionToken value.
        /// </returns>
        public static TransactionToken FromBankTransferTransactionToken(BankTransferTransactionToken bankTransferTransactionToken)
        {
            return new BankTransferTransactionTokenCase().Set(bankTransferTransactionToken);
        }

        /// <summary>
        /// This is PaidyTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided PaidyTransactionToken value.
        /// </returns>
        public static TransactionToken FromPaidyTransactionToken(PaidyTransactionToken paidyTransactionToken)
        {
            return new PaidyTransactionTokenCase().Set(paidyTransactionToken);
        }

        /// <summary>
        /// This is QrScanTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided QrScanTransactionToken value.
        /// </returns>
        public static TransactionToken FromQrScanTransactionToken(QrScanTransactionToken qrScanTransactionToken)
        {
            return new QrScanTransactionTokenCase().Set(qrScanTransactionToken);
        }

        /// <summary>
        /// This is QrMerchantTransactionToken case.
        /// </summary>
        /// <returns>
        /// The TransactionToken instance, wrapping the provided QrMerchantTransactionToken value.
        /// </returns>
        public static TransactionToken FromQrMerchantTransactionToken(QrMerchantTransactionToken qrMerchantTransactionToken)
        {
            return new QrMerchantTransactionTokenCase().Set(qrMerchantTransactionToken);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<CardTransactionToken, T> cardTransactionToken,
            Func<KonbiniTransactionToken, T> konbiniTransactionToken,
            Func<OnlineTransactionToken, T> onlineTransactionToken,
            Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
            Func<PaidyTransactionToken, T> paidyTransactionToken,
            Func<QrScanTransactionToken, T> qrScanTransactionToken,
            Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<CardTransactionToken, T> cardTransactionToken = null,
            Func<KonbiniTransactionToken, T> konbiniTransactionToken = null,
            Func<OnlineTransactionToken, T> onlineTransactionToken = null,
            Func<BankTransferTransactionToken, T> bankTransferTransactionToken = null,
            Func<PaidyTransactionToken, T> paidyTransactionToken = null,
            Func<QrScanTransactionToken, T> qrScanTransactionToken = null,
            Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken = null) =>
                Match(cardTransactionToken, konbiniTransactionToken, onlineTransactionToken, bankTransferTransactionToken, paidyTransactionToken, qrScanTransactionToken, qrMerchantTransactionToken);

        [JsonConverter(typeof(UnionTypeCaseConverter<CardTransactionTokenCase, CardTransactionToken>))]
        private sealed class CardTransactionTokenCase : TransactionToken, ICaseValue<CardTransactionTokenCase, CardTransactionToken>
        {
            public CardTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   cardTransactionToken != null ? cardTransactionToken(Value) : default;

            public CardTransactionTokenCase Set(CardTransactionToken value)
            {
                Value = value;
                return this;
            }

            public CardTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<KonbiniTransactionTokenCase, KonbiniTransactionToken>))]
        private sealed class KonbiniTransactionTokenCase : TransactionToken, ICaseValue<KonbiniTransactionTokenCase, KonbiniTransactionToken>
        {
            public KonbiniTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   konbiniTransactionToken != null ? konbiniTransactionToken(Value) : default;

            public KonbiniTransactionTokenCase Set(KonbiniTransactionToken value)
            {
                Value = value;
                return this;
            }

            public KonbiniTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<OnlineTransactionTokenCase, OnlineTransactionToken>))]
        private sealed class OnlineTransactionTokenCase : TransactionToken, ICaseValue<OnlineTransactionTokenCase, OnlineTransactionToken>
        {
            public OnlineTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   onlineTransactionToken != null ? onlineTransactionToken(Value) : default;

            public OnlineTransactionTokenCase Set(OnlineTransactionToken value)
            {
                Value = value;
                return this;
            }

            public OnlineTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BankTransferTransactionTokenCase, BankTransferTransactionToken>))]
        private sealed class BankTransferTransactionTokenCase : TransactionToken, ICaseValue<BankTransferTransactionTokenCase, BankTransferTransactionToken>
        {
            public BankTransferTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   bankTransferTransactionToken != null ? bankTransferTransactionToken(Value) : default;

            public BankTransferTransactionTokenCase Set(BankTransferTransactionToken value)
            {
                Value = value;
                return this;
            }

            public BankTransferTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaidyTransactionTokenCase, PaidyTransactionToken>))]
        private sealed class PaidyTransactionTokenCase : TransactionToken, ICaseValue<PaidyTransactionTokenCase, PaidyTransactionToken>
        {
            public PaidyTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   paidyTransactionToken != null ? paidyTransactionToken(Value) : default;

            public PaidyTransactionTokenCase Set(PaidyTransactionToken value)
            {
                Value = value;
                return this;
            }

            public PaidyTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<QrScanTransactionTokenCase, QrScanTransactionToken>))]
        private sealed class QrScanTransactionTokenCase : TransactionToken, ICaseValue<QrScanTransactionTokenCase, QrScanTransactionToken>
        {
            public QrScanTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   qrScanTransactionToken != null ? qrScanTransactionToken(Value) : default;

            public QrScanTransactionTokenCase Set(QrScanTransactionToken value)
            {
                Value = value;
                return this;
            }

            public QrScanTransactionToken Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<QrMerchantTransactionTokenCase, QrMerchantTransactionToken>))]
        private sealed class QrMerchantTransactionTokenCase : TransactionToken, ICaseValue<QrMerchantTransactionTokenCase, QrMerchantTransactionToken>
        {
            public QrMerchantTransactionToken Value;

            public override T Match<T>(
                Func<CardTransactionToken, T> cardTransactionToken,
                Func<KonbiniTransactionToken, T> konbiniTransactionToken,
                Func<OnlineTransactionToken, T> onlineTransactionToken,
                Func<BankTransferTransactionToken, T> bankTransferTransactionToken,
                Func<PaidyTransactionToken, T> paidyTransactionToken,
                Func<QrScanTransactionToken, T> qrScanTransactionToken,
                Func<QrMerchantTransactionToken, T> qrMerchantTransactionToken) =>
                   qrMerchantTransactionToken != null ? qrMerchantTransactionToken(Value) : default;

            public QrMerchantTransactionTokenCase Set(QrMerchantTransactionToken value)
            {
                Value = value;
                return this;
            }

            public QrMerchantTransactionToken Get()
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