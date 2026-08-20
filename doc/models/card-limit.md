
# Card Limit

Per-card spending limit enforced on card payments, evaluated over a rolling duration.

*This model accepts additional fields of type object.*

## Structure

`CardLimit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | Maximum amount a single card may charge within `duration`. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Limit amount formatted for display. |
| `Duration` | `string` | Optional | ISO-8601 period over which the limit is evaluated (e.g. P1M). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CardLimit cardLimit = new CardLimit
{
    Amount = 100000,
    Currency = "JPY",
    AmountFormatted = 100000,
    Duration = "P1M",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

