
# Checkout Ec Products Configuration

Product-related EC checkout settings.

*This model accepts additional fields of type object.*

## Structure

`CheckoutEcProductsConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether EC product line items are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutEcProductsConfiguration checkoutEcProductsConfiguration = new CheckoutEcProductsConfiguration
{
    Enabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

