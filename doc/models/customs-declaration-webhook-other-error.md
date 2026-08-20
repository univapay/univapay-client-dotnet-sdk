
# Customs Declaration Webhook Other Error

Nested customs-processing error entry returned in `others`.

*This model accepts additional fields of type object.*

## Structure

`CustomsDeclarationWebhookOtherError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Backend other-error type. |
| `CredentialsId` | `Guid?` | Optional | Gateway credentials involved in the error when applicable. |
| `Message` | `List<string>` | Optional | Additional reason values for `not_selected_reasons`. |
| `ItemName` | `string` | Optional | Related item name for `related_item`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

CustomsDeclarationWebhookOtherError customsDeclarationWebhookOtherError = new CustomsDeclarationWebhookOtherError
{
    Type = "related_item",
    ItemName = "charge",
};
```

