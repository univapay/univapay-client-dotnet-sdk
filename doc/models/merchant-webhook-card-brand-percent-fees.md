
# Merchant Webhook Card Brand Percent Fees

Per-card-brand percent fee overrides.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookCardBrandPercentFees`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Visa` | `double?` | Optional | Percent fee override applied to Visa transactions. |
| `AmericanExpress` | `double?` | Optional | Percent fee override applied to American Express transactions. |
| `Mastercard` | `double?` | Optional | Percent fee override applied to Mastercard transactions. |
| `Maestro` | `double?` | Optional | Percent fee override applied to Maestro transactions. |
| `Discover` | `double?` | Optional | Percent fee override applied to Discover transactions. |
| `Jcb` | `double?` | Optional | Percent fee override applied to JCB transactions. |
| `DinersClub` | `double?` | Optional | Percent fee override applied to Diners Club transactions. |
| `UnionPay` | `double?` | Optional | Percent fee override applied to UnionPay transactions. |
| `PrivateLabel` | `double?` | Optional | Percent fee override applied to private-label card transactions. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

MerchantWebhookCardBrandPercentFees merchantWebhookCardBrandPercentFees = new MerchantWebhookCardBrandPercentFees
{
    Visa = 3.6,
    Mastercard = 3.6,
    Jcb = 3.8,
};
```

