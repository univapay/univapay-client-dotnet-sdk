
# Webhook Event

Represents a single delivery attempt of a webhook event, including the payload sent and the delivery outcome.

*This model accepts additional fields of type object.*

## Structure

`WebhookEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier for the webhook event. |
| `WebhookId` | `Guid?` | Optional | ID of the parent webhook. |
| `Event` | [`WebhookTrigger?`](../../doc/models/webhook-trigger.md) | Optional | Event type that triggers a webhook notification. |
| `Data` | `object` | Optional | Domain object payload for webhook deliveries. The actual structure depends on the event type — see each webhook callback schema for the specific payload shape. |
| `Successful` | `bool?` | Optional | Whether the webhook delivery was acknowledged (HTTP 2xx). |
| `FiredOn` | `DateTime?` | Optional | Timestamp when the webhook was dispatched. |
| `ErrorMessage` | `string` | Optional | Error message if delivery failed. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the event was created. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

WebhookEvent webhookEvent = new WebhookEvent
{
};
```

