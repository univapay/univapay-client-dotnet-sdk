
# Direct Debit Bank Transfer List

Paginated list of direct debit bank transfers.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankTransferList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<DirectDebitBankTransfer>`](../../doc/models/direct-debit-bank-transfer.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankTransferList directDebitBankTransferList = new DirectDebitBankTransferList
{
    Items = new List<DirectDebitBankTransfer>
    {
        new DirectDebitBankTransfer
        {
            Id = "2594976",
            LegacyStoreId = "1283794",
            MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
            BankAccountId = "1098116",
            UserNumber = "SD02688328",
            BankCode = "0012",
            BankName = "ﾗｸﾃﾝｷﾞﾝｺｳ",
            BranchCode = "120",
            BankAccountType = DirectDebitBankAccountType.Regular,
            BankAccountName = "ﾀﾅｶﾕﾐｺ",
            BankAccountNumber = "1234567",
            Amount = 1000L,
            DebitDate = DirectDebitDebitDate.Fourteen,
            CalculatedDebitDate = DateTime.Parse("2026-03-14"),
            MLock = DirectDebitBankTransferLock.Unlocked,
            Status = DirectDebitBankTransferStatus.Awaiting,
            Error = null,
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new DirectDebitBankTransfer
        {
            Id = "2594977",
            LegacyStoreId = "1283794",
            MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
            BankAccountId = "1098117",
            UserNumber = "SD02688329",
            BankCode = "0009",
            BankName = "ﾐﾂｲｽﾐﾄﾓ",
            BranchCode = "221",
            BankAccountType = DirectDebitBankAccountType.Current,
            BankAccountName = "ｽｽﾞｷﾀﾛｳ",
            BankAccountNumber = "7654321",
            Amount = 1850L,
            DebitDate = DirectDebitDebitDate.TwentySeven,
            CalculatedDebitDate = DateTime.Parse("2026-03-27"),
            MLock = DirectDebitBankTransferLock.Locked,
            Status = DirectDebitBankTransferStatus.Failed,
            Error = DirectDebitBankTransferError.InsufficientFunds,
            CreatedOn = DateTime.ParseExact("2026-04-10T09:12:04.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-12T11:03:41.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    HasMore = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

