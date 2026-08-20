
# Charge Create Request Redirect

Charge Create Request Redirect schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeCreateRequestRedirect`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Endpoint` | `string` | Optional | URL to redirect the customer to after payment completion. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeCreateRequestRedirect chargeCreateRequestRedirect = new ChargeCreateRequestRedirect
{
};
```

