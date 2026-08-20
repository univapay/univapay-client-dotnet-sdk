
# Merchant Webhook Recurring Token Configuration

Recurring token configuration inherited by the merchant.

*This model accepts additional fields of type object.*

## Structure

`MerchantWebhookRecurringTokenConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RecurringType` | `string` | Optional | Merchant recurring-token privilege. |
| `ChargeWaitPeriod` | `string` | Optional | ISO-8601 duration to wait before first recurring charge. |
| `CardChargeCvvConfirmation` | [`MerchantWebhookRecurringCvvConfirmationConfig`](../../doc/models/merchant-webhook-recurring-cvv-confirmation-config.md) | Optional | CVV confirmation rules for recurring token charges. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

MerchantWebhookRecurringTokenConfiguration merchantWebhookRecurringTokenConfiguration = new MerchantWebhookRecurringTokenConfiguration
{
    RecurringType = "infinite",
    ChargeWaitPeriod = "P7D",
    CardChargeCvvConfirmation = new MerchantWebhookRecurringCvvConfirmationConfig
    {
        Enabled = false,
    },
};
```

