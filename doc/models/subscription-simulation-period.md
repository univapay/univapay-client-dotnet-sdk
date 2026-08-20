
# Subscription Simulation Period

Billing frequency for the simulated schedule. Includes `bimonthly`, which is not offered on `SubscriptionPeriod` for live subscription creation.

## Enumeration

`SubscriptionSimulationPeriod`

## Fields

| Name |
|  --- |
| `Daily` |
| `Weekly` |
| `Biweekly` |
| `Monthly` |
| `Bimonthly` |
| `Quarterly` |
| `Semiannually` |
| `Annually` |

## Example

```csharp
using UnivaPay.Models;

SubscriptionSimulationPeriod subscriptionSimulationPeriod = SubscriptionSimulationPeriod.Biweekly;
```

