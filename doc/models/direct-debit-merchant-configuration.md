
# Direct Debit Merchant Configuration

The merchant's effective direct debit configuration.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitMerchantConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LegacyId` | `string` | Optional | Identifier of the merchant in the legacy direct debit system.<br><br>**Constraints**: *Pattern*: `^[0-9]+$` |
| `Enabled` | `bool?` | Optional | Whether direct debit is enabled for this merchant. |
| `DebitDate` | [`DirectDebitDebitDate?`](../../doc/models/direct-debit-debit-date.md) | Optional | Monthly debit cycle — funds are pulled on either the 14th or the 27th. |
| `ConsignorCode` | `string` | Optional | Consignor code (委託者コード) assigned by the collecting bank.<br><br>**Constraints**: *Minimum Length*: `6`, *Maximum Length*: `6`, *Pattern*: `^[0-9]{6}$` |
| `Classifier` | `string` | Optional | Transfer classification code (区分) agreed with the collecting bank.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2`, *Pattern*: `^[0-9]{2}$` |
| `Signature` | `string` | Optional | Name printed on the consumer's bank statement (印字名), in half-width katakana. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitMerchantConfiguration directDebitMerchantConfiguration = new DirectDebitMerchantConfiguration
{
    LegacyId = "1283794",
    Enabled = true,
    DebitDate = DirectDebitDebitDate.Fourteen,
    ConsignorCode = "135456",
    Classifier = "99",
    Signature = "モモサン",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

