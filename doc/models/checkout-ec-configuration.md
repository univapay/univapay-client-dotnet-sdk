
# Checkout Ec Configuration

EC checkout feature toggles for hosted email receipts and product line items.

*This model accepts additional fields of type object.*

## Structure

`CheckoutEcConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EcEmail` | [`CheckoutEcEmailConfiguration`](../../doc/models/checkout-ec-email-configuration.md) | Optional | Email-related EC checkout settings. |
| `EcProducts` | [`CheckoutEcProductsConfiguration`](../../doc/models/checkout-ec-products-configuration.md) | Optional | Product-related EC checkout settings. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutEcConfiguration checkoutEcConfiguration = new CheckoutEcConfiguration
{
    EcEmail = new CheckoutEcEmailConfiguration
    {
        Enabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    EcProducts = new CheckoutEcProductsConfiguration
    {
        Enabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

