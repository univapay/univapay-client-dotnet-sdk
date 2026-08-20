
# Transaction History Refund Reason

Reason code for a refund.

## Enumeration

`TransactionHistoryRefundReason`

## Fields

| Name |
|  --- |
| `Duplicate` |
| `Fraud` |
| `CustomerRequest` |
| `SystemFailure` |
| `Chargeback` |
| `ChargebackFeeExempt` |
| `ChargebackReverse` |

## Example

```csharp
using UnivaPay.Models;

TransactionHistoryRefundReason transactionHistoryRefundReason = TransactionHistoryRefundReason.Chargeback;
```

