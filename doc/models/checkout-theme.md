
# Checkout Theme

Widget theme applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutTheme`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Colors` | [`CheckoutThemeColors`](../../doc/models/checkout-theme-colors.md) | Optional | Hex colors applied to the checkout widget. Always resolves to the platform defaults shown here when not customized — never `null`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutTheme checkoutTheme = new CheckoutTheme
{
    Colors = new CheckoutThemeColors
    {
        MainBackground = "main_background8",
        SecondaryBackground = "secondary_background6",
        MainColor = "main_color0",
        MainText = "main_text4",
        PrimaryText = "primary_text8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

