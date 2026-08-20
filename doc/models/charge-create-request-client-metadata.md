
# Charge Create Request Client Metadata

Charge Create Request Client Metadata schema.

*This model accepts additional fields of type object.*

## Structure

`ChargeCreateRequestClientMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IpAddress` | `string` | Optional | Consumer's IPv4 address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeCreateRequestClientMetadata chargeCreateRequestClientMetadata = new ChargeCreateRequestClientMetadata
{
    IpAddress = "198.51.100.14",
};
```

