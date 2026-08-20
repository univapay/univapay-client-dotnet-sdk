
# Token Create Paidy Data Shipping Address

Shipping address for a Paidy token. `zip` is required; the server additionally requires at least one of `line1`, `line2`, `city`, or `state` to be present (not enforceable at the schema level).

*This model accepts additional fields of type object.*

## Structure

`TokenCreatePaidyDataShippingAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Zip` | `string` | Required | Japanese postal code (e.g., '105-0011'). |
| `Line1` | `string` | Optional | Primary street address line. |
| `Line2` | `string` | Optional | Secondary street address line. |
| `City` | `string` | Optional | City or locality. |
| `State` | `string` | Optional | State or prefecture. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenCreatePaidyDataShippingAddress tokenCreatePaidyDataShippingAddress = new TokenCreatePaidyDataShippingAddress
{
    Zip = "105-0011",
    Line1 = "1-1-1",
    City = "Minato",
    State = "Tokyo",
};
```

