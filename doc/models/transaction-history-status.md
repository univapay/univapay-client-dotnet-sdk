
# Transaction History Status

Status of the underlying resource. Charge rows use the full set of values; refund rows only ever report `pending`, `successful`, `failed`, or `error`.

## Enumeration

`TransactionHistoryStatus`

## Fields

| Name |
|  --- |
| `Pending` |
| `Authorized` |
| `Successful` |
| `Failed` |
| `Error` |
| `Canceled` |
| `Awaiting` |

## Example

```csharp
using UnivaPay.Models;

TransactionHistoryStatus transactionHistoryStatus = TransactionHistoryStatus.Failed;
```

