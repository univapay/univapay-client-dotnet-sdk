
# Subscription Update Request

Request payload for updating a subscription.

*This model accepts additional fields of type object.*

## Structure

`SubscriptionUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionTokenId` | `Guid?` | Optional | Transaction token ID used for the subscription.  Can be changed to update the payment method (e.g., when a card expires).  Allowed only when the status is `unconfirmed`, `unpaid`, `current`, or `suspended`. |
| `Amount` | `int?` | Optional | The recurring charge amount (applied to the cycle after the next one).  Not available for limited-cycle subscriptions.  To change the immediate next payment amount, update `next_payment.amount` instead. |
| `Period` | [`SubscriptionPeriod?`](../../doc/models/subscription-period.md) | Optional | Subscription Period schema. |
| `CyclicalPeriod` | `string` | Optional | ISO-8601 Duration for custom frequency (e.g., P3D, P2M). Cannot be used together with `period`. Only allowed before the subscription's first payment has been paid. |
| `InitialAmount` | `int?` | Optional | Different amount for the first charge. Only allowed while the subscription status is still editable (before it has started) and requires the App Token Secret. |
| `SubscriptionPlan` | [`SubscriptionPlanSettings`](../../doc/models/subscription-plan-settings.md) | Optional | Configuration for limited-cycle subscriptions (Univapay side). |
| `InstallmentPlan` | [`SubscriptionInstallmentPlan`](../../doc/models/subscription-installment-plan.md) | Optional | Configuration for credit card company side installments. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Status` | [`SubscriptionUpdateStatus?`](../../doc/models/subscription-update-status.md) | Optional | Update the subscription status.  `suspended`: Pause the subscription.  `unpaid`: Resume a suspended subscription. |
| `ScheduleSettings` | [`SubscriptionUpdateScheduleSettings`](../../doc/models/subscription-update-schedule-settings.md) | Optional | Schedule settings that can be updated on a subscription. |
| `NextPayment` | [`SubscriptionUpdateNextPayment`](../../doc/models/subscription-update-next-payment.md) | Optional | Fields that can be updated on the next scheduled payment. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

SubscriptionUpdateRequest subscriptionUpdateRequest = new SubscriptionUpdateRequest
{
    TransactionTokenId = new Guid("11ef3362-3700-c54a-9baa-6f7e6527c9d9"),
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
    },
    ScheduleSettings = new SubscriptionUpdateScheduleSettings
    {
        TerminationMode = SubscriptionTerminationMode.OnNextPayment,
    },
    NextPayment = new SubscriptionUpdateNextPayment
    {
        DueDate = DateTime.Parse("2030-01-01"),
    },
};
```

