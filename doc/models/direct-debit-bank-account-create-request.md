
# Direct Debit Bank Account Create Request

Request payload for registering a consumer bank account for direct debit.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankAccountCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserNumber` | `string` | Required | The merchant's own membership number for the consumer (会員番号). Alphanumeric.<br><br>**Constraints**: *Pattern*: `^[a-zA-Z0-9]+$` |
| `BankCode` | `string` | Required | Four-digit code identifying the consumer's bank (銀行コード).<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4`, *Pattern*: `^[0-9]{4}$` |
| `BankName` | `string` | Required | Bank name in half-width katakana (銀行名).<br><br>**Constraints**: *Maximum Length*: `15` |
| `BranchCode` | `string` | Required | Three-digit code identifying the bank branch (支店コード).<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `BankAccountType` | [`DirectDebitBankAccountType`](../../doc/models/direct-debit-bank-account-type.md) | Required | Deposit account type (預金種類) — `regular` (普通), `current` (当座), `savings` (貯蓄) or `others` (その他). |
| `BankAccountName` | `string` | Required | Account holder name (口座名義), in half-width katakana. Full-width characters are rejected by the bank.<br><br>**Constraints**: *Maximum Length*: `30`, *Pattern*: `^[A-Z0-9ｱ-ﾝﾞﾟ().\- ]{1,30}$` |
| `BankAccountNumber` | `string` | Required | Seven-digit account number (口座番号).<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7`, *Pattern*: `^[0-9]{7}$` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankAccountCreateRequest directDebitBankAccountCreateRequest = new DirectDebitBankAccountCreateRequest
{
    UserNumber = "SD02688328",
    BankCode = "0012",
    BankName = "ﾗｸﾃﾝｷﾞﾝｺｳ",
    BranchCode = "120",
    BankAccountType = DirectDebitBankAccountType.Regular,
    BankAccountName = "ﾀﾅｶﾕﾐｺ",
    BankAccountNumber = "1234567",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

