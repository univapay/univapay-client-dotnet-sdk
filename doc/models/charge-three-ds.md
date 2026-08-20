
# Charge Three Ds

Charge Three Ds schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RedirectEndpoint` | `string` | Optional | Redirect endpoint URL. |
| `Mode` | `string` | Optional | Processing mode for the resource. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeThreeDs chargeThreeDs = new ChargeThreeDs
{
};
```

