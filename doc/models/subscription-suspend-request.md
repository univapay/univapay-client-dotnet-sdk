
# Subscription Suspend Request

Request body for suspending a subscription. The `schedule_settings.termination_mode`  field controls when the suspension takes effect.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionSuspendRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ScheduleSettings` | [`SuspendScheduleSettings`](../../doc/models/suspend-schedule-settings.md) | Optional | Schedule-related settings. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionSuspendRequest subscriptionSuspendRequest = new SubscriptionSuspendRequest
{
    ScheduleSettings = new SuspendScheduleSettings
    {
        TerminationMode = SubscriptionTerminationMode.OnNextPayment,
    },
};
```

