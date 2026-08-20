
# Transaction Token Create Request Payment Type

Transaction Token Create Request Payment Type schema.

## Enumeration

`TransactionTokenCreateRequestPaymentType`

## Fields

| Name |
|  --- |
| `Card` |
| `Online` |
| `Konbini` |
| `BankTransfer` |
| `QrScan` |
| `QrMerchant` |
| `Paidy` |

## Example

```csharp
using UnivaPay.Models;

TransactionTokenCreateRequestPaymentType transactionTokenCreateRequestPaymentType = TransactionTokenCreateRequestPaymentType.QrScan;
```

