// <copyright file="GenericMetadataValue.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace UnivaPay.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<GenericMetadataValue>),
        new[] {
            typeof(MStringCase),
            typeof(PrecisionCase),
            typeof(BooleanCase),
            typeof(ListOfObjectCase)
        },
        false
    )]
    public abstract class GenericMetadataValue
    {
        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The GenericMetadataValue instance, wrapping the provided string value.
        /// </returns>
        public static GenericMetadataValue FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The GenericMetadataValue instance, wrapping the provided double value.
        /// </returns>
        public static GenericMetadataValue FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// This is Boolean case.
        /// </summary>
        /// <returns>
        /// The GenericMetadataValue instance, wrapping the provided bool value.
        /// </returns>
        public static GenericMetadataValue FromBoolean(bool boolean)
        {
            return new BooleanCase().Set(boolean);
        }

        /// <summary>
        /// This is List of Object case.
        /// </summary>
        /// <returns>
        /// The GenericMetadataValue instance, wrapping the provided object value.
        /// </returns>
        public static GenericMetadataValue FromListOfObject(object listOfObject)
        {
            return new ListOfObjectCase().Set(listOfObject);
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
            Func<string, T> mString,
            Func<double, T> precision,
            Func<bool, T> boolean,
            Func<object, T> listOfObject);

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
            Func<string, T> mString = null,
            Func<double, T> precision = null,
            Func<bool, T> boolean = null,
            Func<object, T> listOfObject = null) =>
                Match(mString, precision, boolean, listOfObject);

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : GenericMetadataValue, ICaseValue<MStringCase, string>
        {
            public string Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean,
                Func<object, T> listOfObject) =>
                   mString != null ? mString(Value) : default;

            public MStringCase Set(string value)
            {
                Value = value;
                return this;
            }

            public string Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : GenericMetadataValue, ICaseValue<PrecisionCase, double>
        {
            public double Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean,
                Func<object, T> listOfObject) =>
                   precision != null ? precision(Value) : default;

            public PrecisionCase Set(double value)
            {
                Value = value;
                return this;
            }

            public double Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : GenericMetadataValue, ICaseValue<BooleanCase, bool>
        {
            public bool Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean,
                Func<object, T> listOfObject) =>
                   boolean != null ? boolean(Value) : default;

            public BooleanCase Set(bool value)
            {
                Value = value;
                return this;
            }

            public bool Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfObjectCase, object>))]
        private sealed class ListOfObjectCase : GenericMetadataValue, ICaseValue<ListOfObjectCase, object>
        {
            public object Value;

            public override T Match<T>(
                Func<string, T> mString,
                Func<double, T> precision,
                Func<bool, T> boolean,
                Func<object, T> listOfObject) =>
                   listOfObject != null ? listOfObject(Value) : default;

            public ListOfObjectCase Set(object value)
            {
                Value = value;
                return this;
            }

            public object Get()
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