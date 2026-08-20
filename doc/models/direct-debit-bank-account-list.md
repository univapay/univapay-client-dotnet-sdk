
# Direct Debit Bank Account List

Paginated list of direct debit bank accounts.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankAccountList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<DirectDebitBankAccount>`](../../doc/models/direct-debit-bank-account.md) | Optional | List of resources. |
| `HasMore` | `bool?` | Optional | Whether more results are available. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankAccountList directDebitBankAccountList = new DirectDebitBankAccountList
{
    Items = new List<DirectDebitBankAccount>
    {
        new DirectDebitBankAccount
        {
            Id = "1098116",
            LegacyStoreId = "1283794",
            MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
            UserNumber = "SD02688328",
            BankCode = "0012",
            BankName = "ﾗｸﾃﾝｷﾞﾝｺｳ",
            BranchCode = "120",
            BankAccountType = DirectDebitBankAccountType.Regular,
            BankAccountName = "ﾀﾅｶﾕﾐｺ",
            BankAccountNumber = "1234567",
            RegistrationOrigin = DirectDebitRegistrationOrigin.MerchantConsole,
            Status = DirectDebitBankAccountStatus.Active,
            CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new DirectDebitBankAccount
        {
            Id = "1098117",
            LegacyStoreId = "1283794",
            MerchantId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
            UserNumber = "SD02688329",
            BankCode = "0009",
            BankName = "ﾐﾂｲｽﾐﾄﾓ",
            BranchCode = "221",
            BankAccountType = DirectDebitBankAccountType.Current,
            BankAccountName = "ｽｽﾞｷﾀﾛｳ",
            BankAccountNumber = "7654321",
            RegistrationOrigin = DirectDebitRegistrationOrigin.Anywhere,
            Status = DirectDebitBankAccountStatus.Inactive,
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

