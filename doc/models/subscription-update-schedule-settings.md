
# Subscription Update Schedule Settings

Schedule settings that can be updated on a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUpdateScheduleSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TerminationMode` | [`SubscriptionTerminationMode?`](../../doc/models/subscription-termination-mode.md) | Optional | Subscription Termination Mode schema.<br><br>**Default**: `SubscriptionTerminationMode.immediate` |
| `StartOn` | `DateTime?` | Optional | Subscription start date (YYYY-MM-DD). Used to change the first actual charge date for subscriptions that initially only registered a payment method. Must be in the future; only available before the subscription has more than one paid payment. |
| `PreserveEndOfMonth` | `bool?` | Optional | If true, subsequent charges will always occur on the last day of the month. |
| `RetryInterval` | `string` | Optional | ISO-8601 Duration for retry interval if payment fails  (e.g., P3D for 3 days, PT48H for 48 hours). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionUpdateScheduleSettings subscriptionUpdateScheduleSettings = new SubscriptionUpdateScheduleSettings
{
};
```

