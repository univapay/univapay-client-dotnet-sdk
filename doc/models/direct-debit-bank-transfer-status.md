
# Direct Debit Bank Transfer Status

Transfer state. `awaiting` until the bank reports back, then `successful` or `failed`. Results are reflected days after the debit date, not immediately.

## Enumeration

`DirectDebitBankTransferStatus`

## Fields

| Name |
|  --- |
| `Awaiting` |
| `Successful` |
| `Failed` |

## Example

```csharp
using UnivaPay.Models;

DirectDebitBankTransferStatus directDebitBankTransferStatus = DirectDebitBankTransferStatus.Successful;
```

