
# Transaction Token List Type

Filterable token types for token listings. `one_time` tokens cannot be filtered on and are excluded from this enum.

## Enumeration

`TransactionTokenListType`

## Fields

| Name |
|  --- |
| `Subscription` |
| `Recurring` |

## Example

```csharp
using UnivaPay.Models;

TransactionTokenListType transactionTokenListType = TransactionTokenListType.Subscription;
```

