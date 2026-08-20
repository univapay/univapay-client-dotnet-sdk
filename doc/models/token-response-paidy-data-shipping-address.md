
# Token Response Paidy Data Shipping Address

Shipping address returned for a Paidy token.

*This model accepts additional fields of type object.*

## Structure

`TokenResponsePaidyDataShippingAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Zip` | `string` | Optional | Japanese postal code. |
| `Line1` | `string` | Optional | Primary street address line. |
| `Line2` | `string` | Optional | Secondary street address line. |
| `City` | `string` | Optional | City or locality. |
| `State` | `string` | Optional | State or prefecture. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenResponsePaidyDataShippingAddress tokenResponsePaidyDataShippingAddress = new TokenResponsePaidyDataShippingAddress
{
    Zip = "105-0011",
    Line1 = "1-1-1",
    City = "Minato",
    State = "Tokyo",
};
```

