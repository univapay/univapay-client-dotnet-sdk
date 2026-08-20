
# Checkout Card Configuration

Card payment settings applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutCardConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether card payments are enabled. |
| `DebitEnabled` | `bool?` | Optional | Whether debit cards are allowed. |
| `PrepaidEnabled` | `bool?` | Optional | Whether prepaid cards are allowed. |
| `DebitAuthorizationEnabled` | `bool?` | Optional | Whether authorization-only flows are allowed for debit cards. |
| `PrepaidAuthorizationEnabled` | `bool?` | Optional | Whether authorization-only flows are allowed for prepaid cards. |
| `OnlyDirectCurrency` | `bool?` | Optional | Whether card processing is restricted to direct-settlement currencies. |
| `ForbiddenCardBrands` | `List<string>` | Optional | Card brands rejected by merchant policy. Common values include `visa`, `mastercard`, `american_express`, `maestro`, `discover`, `jcb`, `diners_club`, `private_label`, and `unionpay`; gateway-specific brands the platform cannot map appear as `unmapped_<raw value>`. `null` when no brand is forbidden. |
| `AllowedCountriesByIp` | `List<string>` | Optional | ISO 3166-1 alpha-2 country codes allowed to originate card payments by IP geolocation. `null` when unrestricted. |
| `ForeignCardsAllowed` | `bool?` | Optional | Whether cards issued outside the primary operating country are allowed. |
| `FailOnNewEmail` | `bool?` | Optional | Whether to reject card charges from previously unseen customer email addresses. `null` when not configured. |
| `CardLimit` | [`CardLimit`](../../doc/models/card-limit.md) | Optional | Per-card spending limit. `null` when no limit is configured. |
| `AllowEmptyCvv` | `bool?` | Optional | Whether card flows may proceed without a CVV. `null` when not configured. |
| `AllowDirectTokenCreation` | `bool?` | Optional | Whether direct card token creation is allowed without a hosted capture flow. |
| `ThreeDsRequired` | `bool?` | Optional | Whether 3-D Secure is required for eligible card flows. |
| `ThreeDsAddressRequired` | `bool?` | Optional | Whether billing address data is required when running 3-D Secure. |
| `ThreeDsSkipEnabled` | `bool?` | Optional | Whether privileged callers may request a 3-D Secure skip. |
| `ThreeDsPhoneNumberRequired` | `bool?` | Optional | Whether a phone number is required when running 3-D Secure. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutCardConfiguration checkoutCardConfiguration = new CheckoutCardConfiguration
{
    Enabled = true,
    DebitEnabled = true,
    PrepaidEnabled = true,
    DebitAuthorizationEnabled = false,
    PrepaidAuthorizationEnabled = false,
    OnlyDirectCurrency = false,
    ForeignCardsAllowed = true,
    AllowDirectTokenCreation = true,
    ThreeDsRequired = false,
    ThreeDsAddressRequired = false,
    ThreeDsSkipEnabled = false,
    ThreeDsPhoneNumberRequired = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

