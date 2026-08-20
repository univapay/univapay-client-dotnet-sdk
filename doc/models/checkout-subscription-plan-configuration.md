
# Checkout Subscription Plan Configuration

Univapay-side subscription plan configuration applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutSubscriptionPlanConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether subscription plans are enabled. |
| `FixedCycle` | `bool?` | Optional | Whether fixed-cycle subscription plans are allowed. |
| `FixedCycleAmount` | `bool?` | Optional | Whether fixed-cycle-amount subscription plans are allowed. |
| `SupportedPaymentTypes` | [`List<CheckoutPaymentType>`](../../doc/models/checkout-payment-type.md) | Optional | Payment types eligible for subscription plans. |
| `MinChargeAmount` | [`CheckoutMoneyAmount`](../../doc/models/checkout-money-amount.md) | Optional | Minimum charge amount eligible for subscription plans. `null` when unrestricted. |
| `MaxPayoutPeriod` | `string` | Optional | ISO-8601 period bounding the maximum payout delay for subscription settlements. `null` when unrestricted. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutSubscriptionPlanConfiguration checkoutSubscriptionPlanConfiguration = new CheckoutSubscriptionPlanConfiguration
{
    Enabled = true,
    FixedCycle = true,
    FixedCycleAmount = true,
    SupportedPaymentTypes = new List<CheckoutPaymentType>
    {
        CheckoutPaymentType.Card,
    },
    MinChargeAmount = null,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

