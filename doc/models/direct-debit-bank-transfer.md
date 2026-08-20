
# Direct Debit Bank Transfer

A single scheduled pull of funds from a registered bank account. The bank account details are copied onto the transfer at registration time, so later edits to the account do not change past transfers.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankTransfer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier of a direct debit bank transfer (振替ID).<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `LegacyStoreId` | `string` | Optional | Identifier of the merchant in the legacy direct debit system.<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `MerchantId` | `Guid?` | Optional | The merchant that owns this transfer. |
| `BankAccountId` | `string` | Optional | Unique identifier of a direct debit bank account (銀行口座ID).<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `UserNumber` | `string` | Optional | The merchant's own membership number for the consumer (会員番号). Alphanumeric.<br><br>**Constraints**: *Pattern*: `^[a-zA-Z0-9]+$` |
| `BankCode` | `string` | Optional | Four-digit code identifying the consumer's bank (銀行コード).<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4`, *Pattern*: `^[0-9]{4}$` |
| `BankName` | `string` | Optional | Bank name in half-width katakana (銀行名).<br><br>**Constraints**: *Maximum Length*: `15` |
| `BranchCode` | `string` | Optional | Three-digit code identifying the bank branch (支店コード).<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `BankAccountType` | [`DirectDebitBankAccountType?`](../../doc/models/direct-debit-bank-account-type.md) | Optional | Deposit account type (預金種類) — `regular` (普通), `current` (当座), `savings` (貯蓄) or `others` (その他). |
| `BankAccountName` | `string` | Optional | Account holder name (口座名義), in half-width katakana. Full-width characters are rejected by the bank.<br><br>**Constraints**: *Maximum Length*: `30`, *Pattern*: `^[A-Z0-9ｱ-ﾝﾞﾟ().\- ]{1,30}$` |
| `BankAccountNumber` | `string` | Optional | Seven-digit account number (口座番号).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{7}$` |
| `Amount` | `long?` | Optional | Transfer amount in JPY. Must be a positive, non-zero whole number.<br><br>**Constraints**: `>= 1` |
| `DebitDate` | [`DirectDebitDebitDate?`](../../doc/models/direct-debit-debit-date.md) | Optional | Monthly debit cycle — funds are pulled on either the 14th or the 27th. |
| `CalculatedDebitDate` | `DateTime?` | Optional | The actual business day on which funds are pulled (計算された振替日), derived from the debit cycle. |
| `Lock` | [`DirectDebitBankTransferLock?`](../../doc/models/direct-debit-bank-transfer-lock.md) | Optional | Whether the transfer can still be edited. Transfers are `unlocked` until the upload deadline for their debit cycle passes, after which they are `locked` and can no longer be changed or deleted. |
| `Status` | [`DirectDebitBankTransferStatus?`](../../doc/models/direct-debit-bank-transfer-status.md) | Optional | Transfer state. `awaiting` until the bank reports back, then `successful` or `failed`. Results are reflected days after the debit date, not immediately. |
| `Error` | [`DirectDebitBankTransferError?`](../../doc/models/direct-debit-bank-transfer-error.md) | Optional | Failure reason, or null while the transfer is awaiting a result or has succeeded. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankTransfer directDebitBankTransfer = new DirectDebitBankTransfer
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
    Error = DirectDebitBankTransferError.InsufficientFunds,
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

