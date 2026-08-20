// <copyright file="BaseOnlineDataBrand.cs" company="APIMatic">
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
    /// BaseOnlineDataBrand.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseOnlineDataBrand
    {
        /// <summary>
        /// AlipayOnline.
        /// </summary>
        [EnumMember(Value = "alipay_online")]
        AlipayOnline,

        /// <summary>
        /// AlipayPlusOnline.
        /// </summary>
        [EnumMember(Value = "alipay_plus_online")]
        AlipayPlusOnline,

        /// <summary>
        /// PayPayOnline.
        /// </summary>
        [EnumMember(Value = "pay_pay_online")]
        PayPayOnline,

        /// <summary>
        /// WeChatOnline.
        /// </summary>
        [EnumMember(Value = "we_chat_online")]
        WeChatOnline,

        /// <summary>
        /// DBaraiOnline.
        /// </summary>
        [EnumMember(Value = "d_barai_online")]
        DBaraiOnline,

        /// <summary>
        /// AlipayChina.
        /// </summary>
        [EnumMember(Value = "alipay_china")]
        AlipayChina,

        /// <summary>
        /// AlipayHk.
        /// </summary>
        [EnumMember(Value = "alipay_hk")]
        AlipayHk,

        /// <summary>
        /// Gcash.
        /// </summary>
        [EnumMember(Value = "gcash")]
        Gcash,

        /// <summary>
        /// Dana.
        /// </summary>
        [EnumMember(Value = "dana")]
        Dana,

        /// <summary>
        /// Truemoney.
        /// </summary>
        [EnumMember(Value = "truemoney")]
        Truemoney,

        /// <summary>
        /// Kakaopay.
        /// </summary>
        [EnumMember(Value = "kakaopay")]
        Kakaopay,

        /// <summary>
        /// Tng.
        /// </summary>
        [EnumMember(Value = "tng")]
        Tng,

        /// <summary>
        /// RabbitLinePay.
        /// </summary>
        [EnumMember(Value = "rabbit_line_pay")]
        RabbitLinePay,

        /// <summary>
        /// Bpi.
        /// </summary>
        [EnumMember(Value = "bpi")]
        Bpi,

        /// <summary>
        /// Boost.
        /// </summary>
        [EnumMember(Value = "boost")]
        Boost,

        /// <summary>
        /// Tinaba.
        /// </summary>
        [EnumMember(Value = "tinaba")]
        Tinaba,

        /// <summary>
        /// NaverPay.
        /// </summary>
        [EnumMember(Value = "naver_pay")]
        NaverPay,

        /// <summary>
        /// TossPay.
        /// </summary>
        [EnumMember(Value = "toss_pay")]
        TossPay,

        /// <summary>
        /// Maya.
        /// </summary>
        [EnumMember(Value = "maya")]
        Maya,

        /// <summary>
        /// GrabSg.
        /// </summary>
        [EnumMember(Value = "grab_sg")]
        GrabSg,

        /// <summary>
        /// KredivoId.
        /// </summary>
        [EnumMember(Value = "kredivo_id")]
        KredivoId,

        /// <summary>
        /// KPlus.
        /// </summary>
        [EnumMember(Value = "k_plus")]
        KPlus,

        /// <summary>
        /// KaspiKz.
        /// </summary>
        [EnumMember(Value = "kaspi_kz")]
        KaspiKz
    }
}