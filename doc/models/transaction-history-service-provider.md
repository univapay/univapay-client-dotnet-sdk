
# Transaction History Service Provider

The processor or service provider that handled the payment.

## Enumeration

`TransactionHistoryServiceProvider`

## Fields

| Name |
|  --- |
| `Credit` |
| `Convenience` |
| `BankTransfer` |
| `Paidy` |
| `PayPay` |
| `Alipay` |
| `WeChat` |
| `Docomo` |
| `Mercari` |
| `Au` |
| `Rakuten` |
| `Bartong` |
| `Jkopay` |
| `GinkoPay` |
| `AeonPay` |
| `Eromnet` |
| `Test` |

## Example

```csharp
using UnivaPay.Models;

TransactionHistoryServiceProvider transactionHistoryServiceProvider = TransactionHistoryServiceProvider.Mercari;
```

