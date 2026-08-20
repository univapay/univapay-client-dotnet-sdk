
# Merchant Webhook Limit Charge by Card Configuration

Per-card velocity limit configuration.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookLimitChargeByCardConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QuantityOfCharges` | `int?` | Optional | Maximum number of charges allowed in the time window. |
| `DurationWindow` | `string` | Optional | ISO-8601 duration for the rolling window. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

MerchantWebhookLimitChargeByCardConfiguration merchantWebhookLimitChargeByCardConfiguration = new MerchantWebhookLimitChargeByCardConfiguration
{
    QuantityOfCharges = 5,
    DurationWindow = "PT24H",
};
```

