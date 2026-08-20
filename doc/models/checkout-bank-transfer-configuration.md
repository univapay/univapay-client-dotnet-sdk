
# Checkout Bank Transfer Configuration

Bank transfer (振込) payment settings applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutBankTransferConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether bank transfer payments are enabled. |
| `MatchAmount` | [`CheckoutBankTransferMatchAmount?`](../../doc/models/checkout-bank-transfer-match-amount.md) | Optional | Deposit-matching policy applied to bank transfer payments. |
| `Expiration` | `string` | Optional | ISO-8601 duration before a bank transfer payment expires. |
| `ExpirationTimeShift` | [`ExpirationTimeShift`](../../doc/models/expiration-time-shift.md) | Optional | Time-of-day override applied when calculating expirations, shared by convenience-store and bank-transfer configuration. |
| `VirtualBankAccountsThreshold` | `int?` | Optional | Number of unused virtual bank accounts that triggers provisioning of additional accounts.<br><br>**Constraints**: `>= 0` |
| `VirtualBankAccountsFetchCount` | `int?` | Optional | Number of virtual bank accounts provisioned per replenishment.<br><br>**Constraints**: `>= 1` |
| `DefaultExtensionPeriod` | `string` | Optional | ISO-8601 duration by which a payment deadline is extended by default. |
| `MaximumExtensionPeriod` | `string` | Optional | ISO-8601 duration for the maximum allowed extension. |
| `AutomaticExtensionEnabled` | `bool?` | Optional | Whether payment deadlines are extended automatically. |
| `ChargeRequestNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a bank transfer charge is requested. |
| `ChargeRequestCanceledNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a requested bank transfer charge is canceled. |
| `ChargeExpiredNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a bank transfer charge expires. |
| `DepositReceivedNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a deposit is received. |
| `DepositInsufficientNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a deposit is insufficient. |
| `DepositExceededNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a deposit exceeds the requested amount. |
| `ExtensionNotificationEnabled` | `bool?` | Optional | Whether a notification is sent when a payment deadline is extended. |
| `RemindNotificationPeriod` | `string` | Optional | ISO-8601 duration before expiration at which a reminder notification is sent. |
| `RemindNotificationEnabled` | `bool?` | Optional | Whether reminder notifications are sent before a payment deadline. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutBankTransferConfiguration checkoutBankTransferConfiguration = new CheckoutBankTransferConfiguration
{
    Enabled = true,
    MatchAmount = CheckoutBankTransferMatchAmount.Disabled,
    Expiration = "PT72H",
    ExpirationTimeShift = new ExpirationTimeShift
    {
        MValue = "value4",
        Enabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    VirtualBankAccountsThreshold = 5,
    VirtualBankAccountsFetchCount = 10,
    DefaultExtensionPeriod = "PT168H",
    MaximumExtensionPeriod = "PT168H",
    AutomaticExtensionEnabled = false,
    ChargeRequestNotificationEnabled = false,
    ChargeRequestCanceledNotificationEnabled = false,
    ChargeExpiredNotificationEnabled = false,
    DepositReceivedNotificationEnabled = false,
    DepositInsufficientNotificationEnabled = false,
    DepositExceededNotificationEnabled = false,
    ExtensionNotificationEnabled = false,
    RemindNotificationPeriod = "PT168H",
    RemindNotificationEnabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

