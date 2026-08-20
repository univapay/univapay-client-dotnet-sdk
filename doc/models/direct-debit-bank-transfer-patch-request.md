
# Direct Debit Bank Transfer Patch Request

Request payload for changing a transfer's amount. Only permitted while the transfer is unlocked.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankTransferPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `long` | Required | Transfer amount in JPY. Must be a positive, non-zero whole number.<br><br>**Constraints**: `>= 1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankTransferPatchRequest directDebitBankTransferPatchRequest = new DirectDebitBankTransferPatchRequest
{
    Amount = 1000L,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

