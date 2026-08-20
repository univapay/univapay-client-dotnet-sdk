
# Token Response Paidy Data

Token Response Paidy Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponsePaidyData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaidyToken` | `string` | Required | One-time token issued by the Paidy SDK/widget on the client side. |
| `PhoneNumber` | `string` | Optional | Consumer phone number in Japanese format. |
| `ShippingAddress` | [`TokenResponsePaidyDataShippingAddress`](../../doc/models/token-response-paidy-data-shipping-address.md) | Optional | Shipping address returned for a Paidy token. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenResponsePaidyData tokenResponsePaidyData = new TokenResponsePaidyData
{
    PaidyToken = "paidy-token-abc123",
    PhoneNumber = "08012341234",
    ShippingAddress = new TokenResponsePaidyDataShippingAddress
    {
        Zip = "105-0011",
        Line1 = "1-1-1",
        City = "Minato",
        State = "Tokyo",
    },
};
```

