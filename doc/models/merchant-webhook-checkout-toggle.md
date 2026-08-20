
# Merchant Webhook Checkout Toggle

Checkout feature toggle.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookCheckoutToggle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Enables this checkout field in hosted payment flows. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

MerchantWebhookCheckoutToggle merchantWebhookCheckoutToggle = new MerchantWebhookCheckoutToggle
{
    Enabled = true,
};
```

