
# Transaction History User Data

Payment-type-specific details for this row. This is a single flat object covering every payment type — the fields actually populated depend on `payment_type` (documented per field below). Fields not applicable to a given payment type are omitted.

*This model accepts additional fields of type object.*

## Structure

`TransactionHistoryUserData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`TransactionHistoryType?`](../../doc/models/transaction-history-type.md) | Optional | Whether this row represents a charge or a refund. |
| `CardholderName` | `string` | Optional | Cardholder name. Present for `card` and `apple_pay` rows only. |
| `CardholderEmailAddress` | `string` | Optional | Cardholder/customer email address. Present for every payment type except `konbini`'s legacy alias fields; always non-null for `bank_transfer` rows, nullable for every other type. |
| `CardholderPhoneNumber` | `string` | Optional | Cardholder phone number. Present for `paidy` rows only. |
| `CustomerName` | `string` | Optional | Customer name as entered at checkout. Present for `konbini` rows only (empty string when not provided). |
| `ConvenienceStore` | `string` | Optional | Legacy duplicate of `brand`. Present for `konbini` rows only. |
| `Brand` | `string` | Optional | Raw brand identifier for the payment method. Present for every payment type; the value set is payment-type-specific (e.g. card brands for `card`/`apple_pay`, QR brands for `qr_scan`/`qr_merchant`, online-wallet brands for `online`, convenience-store brands for `konbini`, `paidy` for `paidy` rows). Nullable for `qr_scan`, `qr_merchant`, and `online`; always non-null for the other types. |
| `Gateway` | `string` | Optional | Raw gateway identifier that processed the payment. Present for every payment type. |
| `ServiceProvider` | [`TransactionHistoryServiceProvider?`](../../doc/models/transaction-history-service-provider.md) | Optional | Service provider, or `null` when not reported. |
| `Refunds` | [`List<TransactionHistoryRefund>`](../../doc/models/transaction-history-refund.md) | Optional | Refunds issued against this charge. Present for charge rows only (`type: charge`); absent for refund rows. |
| `Reason` | [`TransactionHistoryRefundReason?`](../../doc/models/transaction-history-refund-reason.md) | Optional | Refund reason, or `null` when unset. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;

TransactionHistoryUserData transactionHistoryUserData = new TransactionHistoryUserData
{
    Type = TransactionHistoryType.Charge,
    CardholderName = "Some Guy",
    CardholderEmailAddress = "test4@univapay.com",
    Brand = "visa",
    Gateway = "test",
    ServiceProvider = TransactionHistoryServiceProvider.Credit,
    Refunds = new List<TransactionHistoryRefund>
    {
        new TransactionHistoryRefund
        {
            RefundId = new Guid("11ef0000-0000-4000-8000-000000000010"),
            Amount = 500,
            Currency = "JPY",
            AmountFormatted = 500,
            Status = TransactionHistoryRefundStatus.Successful,
        },
    },
};
```

