
# Direct Debit Schedule

The key dates for one debit cycle. Use these to work out whether the current month's registration window is still open.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitSchedule`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantBankAccountTransferDate` | `DateTime?` | Optional | The date funds are pulled from consumer accounts (指定振替日). |
| `MerchantBankAccountRegistrationDeadline` | `DateTime?` | Optional | The date by which the bank must receive the signed direct debit mandate (振替依頼書到着期限). |
| `MerchantBankTransferUploadDeadline` | `DateTime?` | Optional | The last date transfers can be registered or edited for this cycle (振替データアップロード期限). After this, transfers lock. |
| `PlatformResultRegistrationDate` | `DateTime?` | Optional | The date transfer results are reflected on the platform (振替結果反映日). |
| `PlatformScheduledPayout` | `DateTime?` | Optional | The date collected funds are paid out to the merchant (支払日). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitSchedule directDebitSchedule = new DirectDebitSchedule
{
    MerchantBankAccountTransferDate = DateTime.Parse("2026-03-14"),
    MerchantBankAccountRegistrationDeadline = DateTime.Parse("2026-02-20"),
    MerchantBankTransferUploadDeadline = DateTime.Parse("2026-03-04"),
    PlatformResultRegistrationDate = DateTime.Parse("2026-03-24"),
    PlatformScheduledPayout = DateTime.Parse("2026-03-31"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

