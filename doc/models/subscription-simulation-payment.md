
# Subscription Simulation Payment

A single scheduled payment produced by the subscription plan simulation.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionSimulationPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DueDate` | `DateTime?` | Optional | Scheduled due date for this simulated payment (YYYY-MM-DD). |
| `ZoneId` | `string` | Optional | IANA timezone identifier used to resolve the due date. |
| `Amount` | `int?` | Optional | Amount to be charged on this cycle, in the smallest currency unit.<br><br>**Constraints**: `>= 0` |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `IsPaid` | `bool?` | Optional | Always `false` for simulated payments — no real payment has been made. |
| `IsLastPayment` | `bool?` | Optional | Whether this is the final payment in the simulated schedule. |
| `SuccessfulPaymentDate` | `DateTime?` | Optional | Always `null` for simulated payments — populated only once a real payment settles. |
| `TerminateWithStatus` | [`TerminateWithStatus?`](../../doc/models/terminate-with-status.md) | Optional | The status the subscription would transition to on this payment's due date, if a termination is scheduled. `null` when no termination applies. |
| `RetryInterval` | `string` | Optional | ISO-8601 Duration for the retry interval applied if this payment fails (e.g., P5D). `null` if no retry interval is configured. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionSimulationPayment subscriptionSimulationPayment = new SubscriptionSimulationPayment
{
};
```

