
# Subscription Simulation Request

Request payload for simulating a subscription payment schedule without creating a live subscription. Specify exactly one of 'period' or 'cyclical_period' to define the billing frequency. 'installment_plan' and 'subscription_plan' are mutually exclusive — specify at most one to model a limited-cycle schedule.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionSimulationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | Amount to be charged in each cycle. Must be a positive integer.<br><br>**Constraints**: `>= 1` |
| `Currency` | `string` | Required | ISO-4217 currency code. |
| `PaymentType` | [`TransactionTokenPaymentType`](../../doc/models/transaction-token-payment-type.md) | Required | Transaction Token Payment Type schema. |
| `InitialAmount` | `int?` | Optional | Optional different amount for the first charge. Must be zero or greater.<br><br>**Constraints**: `>= 0` |
| `Period` | [`SubscriptionSimulationPeriod?`](../../doc/models/subscription-simulation-period.md) | Optional | Billing frequency for the simulated schedule. Includes `bimonthly`, which is not offered on `SubscriptionPeriod` for live subscription creation. |
| `CyclicalPeriod` | `string` | Optional | ISO-8601 Duration for custom frequency (e.g., P3D, P2M). Cannot be used together with 'period' — specify exactly one of the two. |
| `ScheduleSettings` | [`SubscriptionScheduleSettings`](../../doc/models/subscription-schedule-settings.md) | Required | Schedule settings applied to a subscription. |
| `InstallmentPlan` | [`SubscriptionSimulationPlanSettings`](../../doc/models/subscription-simulation-plan-settings.md) | Optional | Cycle-limiting plan configuration used to simulate an installment plan or a Univapay-side subscription plan. |
| `SubscriptionPlan` | [`SubscriptionSimulationPlanSettings`](../../doc/models/subscription-simulation-plan-settings.md) | Optional | Cycle-limiting plan configuration used to simulate an installment plan or a Univapay-side subscription plan. |
| `OnlyDirectCurrency` | `bool?` | Optional | Whether only direct currency processing is allowed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionSimulationRequest subscriptionSimulationRequest = new SubscriptionSimulationRequest
{
    Amount = 1000,
    Currency = "JPY",
    PaymentType = TransactionTokenPaymentType.Card,
    ScheduleSettings = new SubscriptionScheduleSettings
    {
        ZoneId = "Asia/Tokyo",
    },
    Period = SubscriptionSimulationPeriod.Monthly,
};
```

