
# Charge Capture Request

Request payload for capturing an authorized charge. Both fields are optional; omit the entire body to capture the full outstanding amount.

*This model accepts additional fields of type object.*

## Structure

`ChargeCaptureRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | The amount to capture. Must be less than or equal to the authorized amount. If omitted, the full outstanding authorized amount is captured. |
| `Currency` | `string` | Optional | ISO-4217 currency code. Must exactly match the currency used during authorization. If omitted, defaults to the currency originally requested on the charge. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeCaptureRequest chargeCaptureRequest = new ChargeCaptureRequest
{
    Amount = 1000,
    Currency = "JPY",
};
```

