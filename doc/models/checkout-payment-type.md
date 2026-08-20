
# Checkout Payment Type

Payment type identifier used throughout the checkout configuration.

## Enumeration

`CheckoutPaymentType`

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

CheckoutPaymentType checkoutPaymentType = CheckoutPaymentType.ApplePay;
```

