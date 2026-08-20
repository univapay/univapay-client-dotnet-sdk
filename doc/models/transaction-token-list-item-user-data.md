
# Transaction Token List Item User Data

Transaction Token List Item User Data schema.

*This model accepts additional fields of type object.*

## Structure

`TransactionTokenListItemUserData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardholderName` | `string` | Optional | Cardholder name value. |
| `Email` | `string` | Optional | Customer email address. |
| `Brand` | `string` | Optional | Brand or network name. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TransactionTokenListItemUserData transactionTokenListItemUserData = new TransactionTokenListItemUserData
{
    CardholderName = "TARO YAMADA",
    Email = "user@example.com",
    Brand = "visa",
};
```

