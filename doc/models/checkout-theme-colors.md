
# Checkout Theme Colors

Hex colors applied to the checkout widget. Always resolves to the platform defaults shown here when not customized — never `null`.

*This model accepts additional fields of type object.*

## Structure

`CheckoutThemeColors`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MainBackground` | `string` | Optional | Main background color. |
| `SecondaryBackground` | `string` | Optional | Secondary background color. |
| `MainColor` | `string` | Optional | Main accent color. |
| `MainText` | `string` | Optional | Main text color. |
| `PrimaryText` | `string` | Optional | Primary text color. |
| `SecondaryText` | `string` | Optional | Secondary text color. |
| `BaseText` | `string` | Optional | Base text color. |
| `BodyBackground` | `string` | Optional | Body background color. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutThemeColors checkoutThemeColors = new CheckoutThemeColors
{
    MainBackground = "#FFFFFF",
    SecondaryBackground = "#F5F8FC",
    MainColor = "#4C5F85",
    MainText = "#FFFFFF",
    PrimaryText = "#4C5F85",
    SecondaryText = "#4C5F85",
    BaseText = "#4C5F85",
    BodyBackground = "#FFFFFF",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

