
# Direct Debit Bank Account

A consumer bank account registered for direct debit.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier of a direct debit bank account (銀行口座ID).<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `LegacyStoreId` | `string` | Optional | Identifier of the merchant in the legacy direct debit system.<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `MerchantId` | `Guid?` | Optional | The merchant that owns this bank account. |
| `UserNumber` | `string` | Optional | The merchant's own membership number for the consumer (会員番号). Alphanumeric.<br><br>**Constraints**: *Pattern*: `^[a-zA-Z0-9]+$` |
| `BankCode` | `string` | Optional | Four-digit code identifying the consumer's bank (銀行コード).<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4`, *Pattern*: `^[0-9]{4}$` |
| `BankName` | `string` | Optional | Bank name in half-width katakana (銀行名).<br><br>**Constraints**: *Maximum Length*: `15` |
| `BranchCode` | `string` | Optional | Three-digit code identifying the bank branch (支店コード).<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `BankAccountType` | [`DirectDebitBankAccountType?`](../../doc/models/direct-debit-bank-account-type.md) | Optional | Deposit account type (預金種類) — `regular` (普通), `current` (当座), `savings` (貯蓄) or `others` (その他). |
| `BankAccountName` | `string` | Optional | Account holder name (口座名義), in half-width katakana. Full-width characters are rejected by the bank.<br><br>**Constraints**: *Maximum Length*: `30`, *Pattern*: `^[A-Z0-9ｱ-ﾝﾞﾟ().\- ]{1,30}$` |
| `BankAccountNumber` | `string` | Optional | Seven-digit account number (口座番号).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{7}$` |
| `RegistrationOrigin` | [`DirectDebitRegistrationOrigin?`](../../doc/models/direct-debit-registration-origin.md) | Optional | Where the bank account was registered from — `merchant_console` for the merchant dashboard, `anywhere` otherwise. |
| `Status` | [`DirectDebitBankAccountStatus?`](../../doc/models/direct-debit-bank-account-status.md) | Optional | Bank account state (有効・無効・登録失敗). Only an `active` account can have transfers registered against it. `registration_failed` means the bank rejected the account details. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankAccount directDebitBankAccount = new DirectDebitBankAccount
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
};
```

