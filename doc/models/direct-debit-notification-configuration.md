
# Direct Debit Notification Configuration

Which direct debit email notifications the merchant has opted into.

*This model accepts additional fields of type object.*

## Structure

`DirectDebitNotificationConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NotifyDeadlineMailing` | `bool?` | Optional | Notify when the deadline for the bank to receive the signed mandate approaches (郵送期限の通知). |
| `NotifyDeadlineDebit` | `bool?` | Optional | Notify when the transfer registration cutoff approaches (締切日の通知). |
| `NotifyDebitUpdate` | `bool?` | Optional | Notify when transfer results are reflected (振替結果の通知). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

DirectDebitNotificationConfiguration directDebitNotificationConfiguration = new DirectDebitNotificationConfiguration
{
    NotifyDeadlineMailing = true,
    NotifyDeadlineDebit = true,
    NotifyDebitUpdate = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

