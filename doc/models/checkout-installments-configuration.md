
# Checkout Installments Configuration

Installment plan configuration applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutInstallmentsConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether installment plans are enabled. |
| `CardProcessor` | [`CheckoutInstallmentCardProcessor`](../../doc/models/checkout-installment-card-processor.md) | Optional | Card-processor capabilities available for installment payments. |
| `SupportedPaymentTypes` | [`List<CheckoutPaymentType>`](../../doc/models/checkout-payment-type.md) | Optional | Payment types eligible for installment plans. |
| `MinChargeAmount` | [`CheckoutMoneyAmount`](../../doc/models/checkout-money-amount.md) | Optional | Minimum charge amount eligible for installment plans. `null` when unrestricted. |
| `MaxPayoutPeriod` | `string` | Optional | ISO-8601 period bounding the maximum payout delay for installment settlements. `null` when unrestricted. |
| `OnlyWithProcessor` | `bool?` | Optional | Whether installment plans are restricted to processor-backed flows. Always `true` — retained for backwards compatibility. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutInstallmentsConfiguration checkoutInstallmentsConfiguration = new CheckoutInstallmentsConfiguration
{
    Enabled = true,
    CardProcessor = new CheckoutInstallmentCardProcessor
    {
        Revolving = false,
        FixedCycle = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SupportedPaymentTypes = new List<CheckoutPaymentType>
    {
        CheckoutPaymentType.Card,
    },
    MinChargeAmount = null,
    MaxPayoutPeriod = "max_payout_period8",
    OnlyWithProcessor = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

