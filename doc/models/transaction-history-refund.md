
# Transaction History Refund

A single refund issued against the charge this row describes.

*This model accepts additional fields of type object.*

## Structure

`TransactionHistoryRefund`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RefundId` | `Guid?` | Optional | Unique identifier of the refund. |
| `Amount` | `int?` | Optional | Refunded amount, in the currency's minor unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Refunded amount, formatted per the currency's display scale. |
| `Status` | [`TransactionHistoryRefundStatus?`](../../doc/models/transaction-history-refund-status.md) | Optional | Status of a single refund entry. |
| `Reason` | [`TransactionHistoryRefundReason?`](../../doc/models/transaction-history-refund-reason.md) | Optional | Reason code for a refund. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

TransactionHistoryRefund transactionHistoryRefund = new TransactionHistoryRefund
{
    RefundId = new Guid("11ef0000-0000-4000-8000-000000000010"),
    Amount = 500,
    Currency = "JPY",
    AmountFormatted = 500,
    Status = TransactionHistoryRefundStatus.Successful,
    Reason = TransactionHistoryRefundReason.CustomerRequest,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

