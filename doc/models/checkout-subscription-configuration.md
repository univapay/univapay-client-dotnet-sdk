
# Checkout Subscription Configuration

Univapay-hosted subscription feature toggle.

*This model accepts additional fields of type object.*

## Structure

`CheckoutSubscriptionConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether Univapay-hosted subscriptions are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutSubscriptionConfiguration checkoutSubscriptionConfiguration = new CheckoutSubscriptionConfiguration
{
    Enabled = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

