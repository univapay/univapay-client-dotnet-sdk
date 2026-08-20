
# Subscription User Data

Customer-facing payment method summary data.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUserData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | Type of the resource. |
| `CardholderName` | `string` | Optional | Cardholder name value. |
| `Email` | `string` | Optional | Customer email address. |
| `Brand` | `string` | Optional | Brand or network name. |
| `Gateway` | `string` | Optional | Gateway identifier. |
| `ServiceProvider` | `string` | Optional | Service provider identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionUserData subscriptionUserData = new SubscriptionUserData
{
};
```

