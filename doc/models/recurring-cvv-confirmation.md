
# Recurring Cvv Confirmation

CVV re-confirmation policy applied to recurring card charges (subscriptions and tokens with recurring privilege).

*This model accepts additional fields of type object.*

## Structure

`RecurringCvvConfirmation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether CVV re-confirmation is required for recurring card charges. Resolves to `false` when not configured. |
| `Threshold` | [`List<CheckoutMoneyAmount>`](../../doc/models/checkout-money-amount.md) | Optional | Amount thresholds above which CVV re-confirmation is required. `null` when no threshold is configured. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

RecurringCvvConfirmation recurringCvvConfirmation = new RecurringCvvConfirmation
{
    Enabled = false,
    Threshold = new List<CheckoutMoneyAmount>
    {
        null,
        new CheckoutMoneyAmount
        {
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

