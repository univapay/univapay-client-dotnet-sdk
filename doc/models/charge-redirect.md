
# Charge Redirect

Charge Redirect schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeRedirect`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Endpoint` | `string` | Optional | Endpoint value. |
| `RedirectId` | `Guid?` | Optional | Redirect identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeRedirect chargeRedirect = new ChargeRedirect
{
};
```

