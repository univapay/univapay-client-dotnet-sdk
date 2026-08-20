
# Transaction History List

Paginated list of transaction history rows. Unlike other list responses in this API, `total_hits` is only present on the first page (no `cursor` supplied) or the last page, and `next_cursor` is only present while `has_more` is `true`.

*This model accepts additional fields of type object.*

## Structure

`TransactionHistoryList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<TransactionHistoryItem>`](../../doc/models/transaction-history-item.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `TotalHits` | `int?` | Optional | Total number of matching resources. Present on the first page (no `cursor` supplied) or the last page; absent on intermediate pages while `has_more` is `true`. |
| `NextCursor` | `Guid?` | Optional | Cursor to pass as `cursor` to fetch the next page. Present only while `has_more` is `true`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

TransactionHistoryList transactionHistoryList = new TransactionHistoryList
{
    Items = new List<TransactionHistoryItem>
    {
        new TransactionHistoryItem
        {
            StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
            ResourceId = new Guid("11ef0000-0000-4000-8000-000000000070"),
            ChargeId = null,
            Amount = 1000,
            Currency = "JPY",
            AmountFormatted = 1000,
            Type = TransactionHistoryType.Charge,
            Status = TransactionHistoryStatus.Successful,
            Metadata = new GenericMetadata
            {
                OrderId = "order_id0",
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
            BankTransferPaymentStatus = null,
            BankTransferLatestDepositDate = null,
            McpTokenId = null,
            ChargeType = TransactionHistoryChargeType.Normal,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new TransactionHistoryItem
        {
            StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
            ResourceId = new Guid("11ef0000-0000-4000-8000-000000000010"),
            ChargeId = new Guid("11ef0000-0000-4000-8000-000000000070"),
            Amount = 500,
            Currency = "JPY",
            AmountFormatted = 500,
            Type = TransactionHistoryType.Refund,
            Status = TransactionHistoryStatus.Successful,
            Metadata = new GenericMetadata
            {
                OrderId = "order_id0",
                UnivapayName = "univapay-name8",
                UnivapayPhoneNumber = "univapay-phone-number2",
                ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
            },
            CreatedOn = DateTime.ParseExact("2024-05-01T13:00:00.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Mode = TransactionHistoryMode.Test,
            MerchantName = "Test merchant",
            StoreName = "Test store",
            PaymentType = TransactionHistoryPaymentType.Card,
            UserData = new TransactionHistoryUserData
            {
                Type = TransactionHistoryType.Refund,
                CardholderName = "cardholder_name8",
                CardholderEmailAddress = "cardholder_email_address0",
                CardholderPhoneNumber = "cardholder_phone_number4",
                CustomerName = "customer_name8",
                Reason = TransactionHistoryRefundReason.CustomerRequest,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            BankTransferPaymentStatus = null,
            BankTransferLatestDepositDate = null,
            McpTokenId = null,
            ChargeType = null,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    TotalHits = 2,
    NextCursor = new Guid("11ef0000-0000-4000-8000-000000000071"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

