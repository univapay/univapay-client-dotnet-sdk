
# Checkout Ec Email Configuration

Email-related EC checkout settings.

*This model accepts additional fields of type object.*

## Structure

`CheckoutEcEmailConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether EC email receipts are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutEcEmailConfiguration checkoutEcEmailConfiguration = new CheckoutEcEmailConfiguration
{
    Enabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

