
# Token Create Paidy Data

Token Create Paidy Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreatePaidyData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaidyToken` | `string` | Required | One-time token issued by the Paidy SDK/widget on the client side. |
| `ShippingAddress` | [`TokenCreatePaidyDataShippingAddress`](../../doc/models/token-create-paidy-data-shipping-address.md) | Required | Shipping address for a Paidy token. `zip` is required; the server additionally requires at least one of `line1`, `line2`, `city`, or `state` to be present (not enforceable at the schema level). |
| `PhoneNumber` | `string` | Optional | Consumer phone number in Japanese format (e.g., '08012341234'). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenCreatePaidyData tokenCreatePaidyData = new TokenCreatePaidyData
{
    PaidyToken = "paidy-token-abc123",
    ShippingAddress = new TokenCreatePaidyDataShippingAddress
    {
        Zip = "105-0011",
        Line1 = "1-1-1",
        City = "Minato",
        State = "Tokyo",
    },
    PhoneNumber = "08012341234",
};
```

