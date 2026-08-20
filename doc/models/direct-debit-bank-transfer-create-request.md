
# Direct Debit Bank Transfer Create Request

Request payload for scheduling a transfer against an active bank account.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitBankTransferCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `long` | Required | Transfer amount in JPY. Must be a positive, non-zero whole number.<br><br>**Constraints**: `>= 1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitBankTransferCreateRequest directDebitBankTransferCreateRequest = new DirectDebitBankTransferCreateRequest
{
    Amount = 1000L,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

