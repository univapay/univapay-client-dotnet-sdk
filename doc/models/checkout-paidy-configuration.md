
# Checkout Paidy Configuration

Paidy payment feature toggle.

*This model accepts additional fields of type object.*

## Structure

`CheckoutPaidyConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether Paidy payments are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutPaidyConfiguration checkoutPaidyConfiguration = new CheckoutPaidyConfiguration
{
    Enabled = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

