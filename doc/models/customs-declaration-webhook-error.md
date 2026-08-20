
# Customs Declaration Webhook Error

Error payload returned when customs declaration processing fails.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `int?` | Optional | Backend customs declaration error code. |
| `Message` | `string` | Optional | Human-readable backend error name. |
| `Details` | `string` | Optional | Optional backend-provided detail string. |
| `Others` | [`List<CustomsDeclarationWebhookOtherError>`](../../doc/models/customs-declaration-webhook-other-error.md) | Optional | Additional nested error records returned by the backend. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;

CustomsDeclarationWebhookError customsDeclarationWebhookError = new CustomsDeclarationWebhookError
{
    Code = 601,
    Message = "There was a processing error",
    Details = "Missing customs registration",
    Others = new List<CustomsDeclarationWebhookOtherError>
    {
        new CustomsDeclarationWebhookOtherError
        {
            Type = "related_item",
            ItemName = "charge",
        },
    },
};
```

