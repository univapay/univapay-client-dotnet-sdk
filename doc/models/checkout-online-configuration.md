
# Checkout Online Configuration

Online redirect/wallet payment feature toggle.

*This model accepts additional fields of type object.*

## Structure

`CheckoutOnlineConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether online redirect/wallet payments are enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutOnlineConfiguration checkoutOnlineConfiguration = new CheckoutOnlineConfiguration
{
    Enabled = true,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

