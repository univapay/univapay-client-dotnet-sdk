
# Subscription Simulation Plan Settings

Cycle-limiting plan configuration used to simulate an installment plan or a Univapay-side subscription plan.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionSimulationPlanSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanType` | [`SimulationPlanSettingsType?`](../../doc/models/simulation-plan-settings-type.md) | Optional | Plan type selector. |
| `FixedCycles` | `int?` | Optional | Number of cycles for the fixed_cycles plan. Must be greater than 1. |
| `FixedCycleAmount` | `int?` | Optional | Total target amount for the fixed_cycle_amount plan. Must not exceed the requested amount. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionSimulationPlanSettings subscriptionSimulationPlanSettings = new SubscriptionSimulationPlanSettings
{
};
```

