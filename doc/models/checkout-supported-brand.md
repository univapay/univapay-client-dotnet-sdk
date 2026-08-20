
# Checkout Supported Brand

Feature support and capability flags for a single payment-type / brand combination the store can accept.

*This model accepts additional fields of type object.*

## Structure

`CheckoutSupportedBrand`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentType` | [`CheckoutPaymentType?`](../../doc/models/checkout-payment-type.md) | Optional | Payment type identifier used throughout the checkout configuration. |
| `Brand` | `string` | Optional | Brand identifier for `payment_type`. For `card` and `apple_pay`, one of the common `CardBrand` values (`visa`, `mastercard`, `american_express`, `maestro`, `discover`, `jcb`, `diners_club`, `private_label`, `unionpay`) or an `unmapped_<raw value>` fallback. For `qr_scan`, a QR-CPM brand (e.g. `pay_pay`, `we_chat`, `qq`, `line_pay`, `au_pay`, `alipay_china`). For `qr_merchant`, a QR-MPM brand (e.g. `rakuten_pay_merchant`, `alipay_merchant_qr`, `pay_pay_merchant`, `d_barai_mpm`, `we_chat_mpm`). For `online`, an online-redirect brand (e.g. `alipay_online`, `pay_pay_online`, `we_chat_online`, `d_barai_online`, `kakaopay`). For `konbini`, a convenience-store brand (e.g. `seven_eleven`, `family_mart`, `lawson`). For `paidy` and `bank_transfer`, the payment type's own identifier. The full brand catalogue is large and gateway-dependent — treat this as an open string, not a fixed set. |
| `CardBrand` | `string` | Optional | Legacy alias of `brand`. Present only when `payment_type` is `card` or `apple_pay`. |
| `QrBrand` | `string` | Optional | Legacy alias of `brand`. Present only when `payment_type` is `qr_merchant`. |
| `OnlineBrand` | `string` | Optional | Legacy alias of `brand`. Present only when `payment_type` is `online`. |
| `DynamicInfo` | `bool?` | Optional | Whether the brand's supported feature set is resolved dynamically. |
| `SupportAuthCapture` | `bool?` | Optional | Whether the brand supports separate authorization and capture. |
| `RequiresFullName` | `bool?` | Optional | Whether the brand requires the cardholder's full name. |
| `RequiresCvv` | `bool?` | Optional | Whether the brand requires a CVV. |
| `CountriesAllowed` | `List<string>` | Optional | ISO 3166-1 alpha-2 country codes allowed for this brand. `null` when unrestricted. |
| `SupportedCurrencies` | `List<string>` | Optional | ISO-4217 currency codes supported by this brand. `null` when unrestricted. |
| `CvvAuth` | `bool?` | Optional | Whether this brand supports CVV-only authorization. |
| `InstallmentCapable` | `bool?` | Optional | Whether this brand supports installment plans. |
| `McpCapable` | `bool?` | Optional | Whether this brand supports multi-currency pricing. |
| `McpOnly` | `bool?` | Optional | Whether this brand is only available through multi-currency pricing. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutSupportedBrand checkoutSupportedBrand = new CheckoutSupportedBrand
{
    PaymentType = CheckoutPaymentType.Card,
    Brand = "visa",
    CardBrand = "visa",
    QrBrand = "alipay_merchant_qr",
    OnlineBrand = "alipay_online",
    DynamicInfo = false,
    SupportAuthCapture = true,
    RequiresFullName = false,
    RequiresCvv = true,
    CvvAuth = false,
    InstallmentCapable = true,
    McpCapable = false,
    McpOnly = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

