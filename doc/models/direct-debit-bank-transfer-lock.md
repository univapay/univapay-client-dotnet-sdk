
# Direct Debit Bank Transfer Lock

Whether the transfer can still be edited. Transfers are `unlocked` until the upload deadline for their debit cycle passes, after which they are `locked` and can no longer be changed or deleted.

## Enumeration

`DirectDebitBankTransferLock`

## Fields

| Name |
|  --- |
| `Unlocked` |
| `Locked` |

## Example

```csharp
using UnivaPay.Models;

DirectDebitBankTransferLock directDebitBankTransferLock = DirectDebitBankTransferLock.Unlocked;
```

