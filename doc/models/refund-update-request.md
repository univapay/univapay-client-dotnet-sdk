
# Refund Update Request

Request body for updating a refund. All fields are optional. Omitted fields are left unchanged.

*This model accepts additional fields of type object.*

## Structure

`RefundUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Message` | `string` | Optional | Update or clear the refund note. Send `null` to remove. |
| `Reason` | [`RefundReasonRequest?`](../../doc/models/refund-reason-request.md) | Optional | Merchant-settable refund reason, or `null` to remove it during update. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

RefundUpdateRequest refundUpdateRequest = new RefundUpdateRequest
{
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    Message = "Updated reason note",
};
```

