
# Transaction History Payment Type

The payment method used for the underlying charge.

## Enumeration

`TransactionHistoryPaymentType`

## Fields

| Name |
|  --- |
| `Card` |
| `QrScan` |
| `QrMerchant` |
| `Konbini` |
| `ApplePay` |
| `Paidy` |
| `Online` |
| `BankTransfer` |

## Example

```csharp
using UnivaPay.Models;

TransactionHistoryPaymentType transactionHistoryPaymentType = TransactionHistoryPaymentType.QrMerchant;
```

