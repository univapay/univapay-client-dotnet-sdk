
# Checkout Convenience Configuration

Convenience-store (konbini) payment settings applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutConvenienceConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether convenience-store payments are enabled. |
| `Expiration` | `string` | Optional | ISO-8601 duration before a convenience-store payment expires. |
| `ExpirationTimeShift` | [`ExpirationTimeShift`](../../doc/models/expiration-time-shift.md) | Optional | Time-of-day override applied when calculating expirations, shared by convenience-store and bank-transfer configuration. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutConvenienceConfiguration checkoutConvenienceConfiguration = new CheckoutConvenienceConfiguration
{
    Enabled = true,
    Expiration = "PT720H",
    ExpirationTimeShift = new ExpirationTimeShift
    {
        MValue = "value4",
        Enabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

