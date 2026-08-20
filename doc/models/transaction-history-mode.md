
# Transaction History Mode

Environment mode: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data.

## Enumeration

`TransactionHistoryMode`

## Fields

| Name |
|  --- |
| `Live` |
| `Test` |
| `LiveTest` |

## Example

```csharp
using UnivaPay.Models;

TransactionHistoryMode transactionHistoryMode = TransactionHistoryMode.Test;
```

