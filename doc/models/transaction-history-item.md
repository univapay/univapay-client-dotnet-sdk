
# Transaction History Item

A single charge or refund row in the merchant's transaction history.

*This model accepts additional fields of type object.*

## Structure

`TransactionHistoryItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `ResourceId` | `Guid?` | Optional | ID of the underlying resource — a charge ID for charge rows, a refund ID for refund rows. |
| `ChargeId` | `Guid?` | Optional | ID of the originating charge. `null` for charge rows; set for refund rows. |
| `Amount` | `int?` | Optional | Amount, in the currency's minor unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Amount, formatted per the currency's display scale. |
| `Type` | [`TransactionHistoryType?`](../../doc/models/transaction-history-type.md) | Optional | Whether this row represents a charge or a refund. |
| `Status` | [`TransactionHistoryStatus?`](../../doc/models/transaction-history-status.md) | Optional | Status of the underlying resource. Charge rows use the full set of values; refund rows only ever report `pending`, `successful`, `failed`, or `error`. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the underlying resource was created. |
| `Mode` | [`TransactionHistoryMode?`](../../doc/models/transaction-history-mode.md) | Optional | Environment mode: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data. |
| `MerchantName` | `string` | Optional | Merchant display name. |
| `StoreName` | `string` | Optional | Store display name. |
| `PaymentType` | [`TransactionHistoryPaymentType?`](../../doc/models/transaction-history-payment-type.md) | Optional | The payment method used for the underlying charge. |
| `UserData` | [`TransactionHistoryUserData`](../../doc/models/transaction-history-user-data.md) | Optional | Payment-type-specific details for this row. This is a single flat object covering every payment type — the fields actually populated depend on `payment_type` (documented per field below). Fields not applicable to a given payment type are omitted. |
| `BankTransferPaymentStatus` | [`BankTransferPaymentStatus?`](../../doc/models/bank-transfer-payment-status.md) | Optional | Bank transfer payment status, or `null` when not applicable. |
| `BankTransferLatestDepositDate` | `DateTime?` | Optional | Timestamp of the most recent deposit matched against a bank transfer charge. `null` when not applicable. |
| `McpTokenId` | `Guid?` | Optional | ID of the multi-currency-pricing token used, when applicable. `null` when not applicable. |
| `ChargeType` | [`TransactionHistoryChargeType?`](../../doc/models/transaction-history-charge-type.md) | Optional | Charge type, or `null` when not applicable. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

TransactionHistoryItem transactionHistoryItem = new TransactionHistoryItem
{
    StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
    ResourceId = new Guid("11ef0000-0000-4000-8000-000000000070"),
    ChargeId = new Guid("000017d4-0000-0000-0000-000000000000"),
    Amount = 1000,
    Currency = "JPY",
    AmountFormatted = 1000,
    Type = TransactionHistoryType.Charge,
    Status = TransactionHistoryStatus.Successful,
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
    },
    CreatedOn = DateTime.ParseExact("2024-05-01T12:34:56.789Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Mode = TransactionHistoryMode.Test,
    MerchantName = "Test merchant",
    StoreName = "Test store",
    PaymentType = TransactionHistoryPaymentType.Card,
    UserData = new TransactionHistoryUserData
    {
        Type = TransactionHistoryType.Charge,
        CardholderName = "Some Guy",
        CardholderEmailAddress = "test4@univapay.com",
        CardholderPhoneNumber = "cardholder_phone_number4",
        CustomerName = "customer_name8",
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
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    BankTransferPaymentStatus = BankTransferPaymentStatus.Exact,
    ChargeType = TransactionHistoryChargeType.Normal,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

