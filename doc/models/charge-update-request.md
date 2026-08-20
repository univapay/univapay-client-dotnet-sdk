
# Charge Update Request

Request payload for updating charge metadata.

*This model accepts additional fields of type object.*

## Structure

`ChargeUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

ChargeUpdateRequest chargeUpdateRequest = new ChargeUpdateRequest
{
    Metadata = new GenericMetadata
    {
        OrderId = "12347",
    },
};
```

