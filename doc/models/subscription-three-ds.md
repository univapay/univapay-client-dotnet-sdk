
# Subscription Three Ds

3-D Secure configuration and redirect details applied to the subscription's payments.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionThreeDs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | [`SubscriptionThreeDsMode?`](../../doc/models/subscription-three-ds-mode.md) | Optional | 3-D Secure authentication mode applied to the subscription's payments. `if_available` enforces 3DS only if credentials are available for the recurring token and it has not already completed 3DS. `provided` indicates externally supplied MPI authentication data was used. |
| `RedirectEndpoint` | `string` | Optional | URL the customer is redirected to for 3-D Secure authentication. |
| `RedirectId` | `Guid?` | Optional | Identifier of the 3-D Secure redirect. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionThreeDs subscriptionThreeDs = new SubscriptionThreeDs
{
};
```

