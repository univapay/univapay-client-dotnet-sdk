
# Subscription Schedule Settings

Schedule settings applied to a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionScheduleSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartOn` | `DateTime?` | Optional | Date when the recurring schedule starts (YYYY-MM-DD). |
| `ZoneId` | `string` | Optional | IANA Timezone ID. |
| `PreserveEndOfMonth` | `bool?` | Optional | If true, subsequent charges will always occur on the last day of the month. |
| `RetryInterval` | `string` | Optional | ISO-8601 Duration for retry interval if payment fails (e.g., P5D). |
| `TerminationMode` | [`SubscriptionTerminationMode?`](../../doc/models/subscription-termination-mode.md) | Optional | Subscription Termination Mode schema.<br><br>**Default**: `SubscriptionTerminationMode.immediate` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionScheduleSettings subscriptionScheduleSettings = new SubscriptionScheduleSettings
{
};
```

