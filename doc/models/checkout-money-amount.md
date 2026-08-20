
# Checkout Money Amount

Monetary amount used by checkout configuration limits and thresholds.

*This model accepts additional fields of type object.*

## Structure

`CheckoutMoneyAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | Amount in the smallest unit of the currency. |
| `AmountFormatted` | `double?` | Optional | Amount formatted for display. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutMoneyAmount checkoutMoneyAmount = new CheckoutMoneyAmount
{
    Amount = 1000,
    AmountFormatted = 1000,
    Currency = "JPY",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

