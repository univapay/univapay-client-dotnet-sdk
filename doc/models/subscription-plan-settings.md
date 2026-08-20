
# Subscription Plan Settings

Configuration for limited-cycle subscriptions (Univapay side).

*This model accepts additional fields of type object.*

## Structure

`SubscriptionPlanSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanType` | [`PlanSettingsType?`](../../doc/models/plan-settings-type.md) | Optional | Plan type selector. |
| `FixedCycles` | `int?` | Optional | Number of cycles for fixed_cycles plan. |
| `FixedCycleAmount` | `int?` | Optional | Total target amount for fixed_cycle_amount plan. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionPlanSettings subscriptionPlanSettings = new SubscriptionPlanSettings
{
};
```

