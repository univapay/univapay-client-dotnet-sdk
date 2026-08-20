
# Subscription

The Subscription object represents a recurring payment schedule.

*This model accepts additional fields of type object.*

## Structure

`Subscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `TransactionTokenId` | `Guid?` | Optional | Transaction token identifier. |
| `Amount` | `int?` | Optional | Amount in the smallest currency unit. |
| `Currency` | `string` | Optional | ISO-4217 currency code. |
| `AmountFormatted` | `double?` | Optional | Amount formatted for display. |
| `InitialAmount` | `int?` | Optional | Initial amount in the smallest currency unit. |
| `InitialAmountFormatted` | `double?` | Optional | Initial amount formatted for display. |
| `SubsequentCyclesStart` | `DateTime?` | Optional | Timestamp when recurring cycles begin. |
| `ScheduleSettings` | [`SubscriptionScheduleSettings`](../../doc/models/subscription-schedule-settings.md) | Optional | Schedule settings applied to a subscription. |
| `OnlyDirectCurrency` | `bool?` | Optional | Whether only direct currency processing is allowed. |
| `FirstChargeCaptureAfter` | `string` | Optional | ISO-8601 Duration (e.g., P3D). |
| `FirstChargeAuthorizationOnly` | `bool?` | Optional | Whether the first charge is authorization-only. |
| `Status` | [`SubscriptionStatus?`](../../doc/models/subscription-status.md) | Optional | Subscription Status schema. |
| `Metadata` | [`GenericMetadata`](../../doc/models/generic-metadata.md) | Optional | A free-form dictionary for custom metadata. |
| `Mode` | [`ChargeMode?`](../../doc/models/charge-mode.md) | Optional | Charge Mode schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `ThreeDs` | [`SubscriptionThreeDs`](../../doc/models/subscription-three-ds.md) | Optional | 3-D Secure configuration and redirect details applied to the subscription's payments. |
| `Period` | [`SubscriptionPeriod?`](../../doc/models/subscription-period.md) | Optional | Subscription Period schema. |
| `CyclicalPeriod` | `string` | Optional | ISO-8601 Duration for a custom billing frequency (e.g., P3D, P1M), returned instead of `period` when the subscription uses a custom cycle length rather than one of the fixed period presets. Mutually exclusive with `period` — exactly one of the two is present. |
| `NextPayment` | [`SubscriptionNextPayment`](../../doc/models/subscription-next-payment.md) | Optional | Next scheduled payment details for a subscription. |
| `CyclesLeft` | `int?` | Optional | Number of remaining billing cycles before the subscription completes. Only present for cycle-limited plans (`subscription_plan` or `installment_plan`); `null` for indefinite subscriptions.<br><br>**Constraints**: `>= 0` |
| `SubscriptionPlan` | [`SubscriptionPlanSettings`](../../doc/models/subscription-plan-settings.md) | Optional | Configuration for limited-cycle subscriptions (Univapay side). |
| `InstallmentPlan` | [`SubscriptionInstallmentPlanResponse`](../../doc/models/subscription-installment-plan-response.md) | Optional | Installment plan applied to the subscription, as returned by the API. Covers both card-network installment plans (`revolving`, `fixed_cycles`) and legacy fixed-amount installment plans (`fixed_cycle_amount`). |
| `ChargeId` | `Guid?` | Optional | Identifier of the charge associated with the subscription's installment plan. Only present when `installment_plan` is set. |
| `AmountLeft` | `int?` | Optional | Remaining amount to be charged over the life of the plan, in the smallest currency unit. Only present for cycle-limited plans.<br><br>**Constraints**: `>= 0` |
| `AmountLeftFormatted` | `double?` | Optional | `amount_left` formatted for display. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

Subscription subscription = new Subscription
{
    Id = new Guid("11ef335e-9aa5-c54a-8313-7f9847da313a"),
    StoreId = new Guid("11edf541-c42d-653c-8c3d-dfe0a55f95c0"),
    TransactionTokenId = new Guid("11ef32a7-3a71-8662-803f-1bc27702eeec"),
    Amount = 1250,
    Currency = "USD",
    AmountFormatted = 12.5,
    ScheduleSettings = new SubscriptionScheduleSettings
    {
        StartOn = DateTime.Parse("2016-03-13"),
        ZoneId = "zone_id8",
        PreserveEndOfMonth = false,
        RetryInterval = "retry_interval2",
        TerminationMode = SubscriptionTerminationMode.Immediate,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    OnlyDirectCurrency = false,
    FirstChargeAuthorizationOnly = false,
    Status = SubscriptionStatus.Current,
    Metadata = new GenericMetadata
    {
        OrderId = "12345",
        UnivapayName = "univapay-name8",
        UnivapayPhoneNumber = "univapay-phone-number2",
        ["exampleAdditionalProperty"] = GenericMetadataValue.FromString("String4"),
    },
    Mode = ChargeMode.Live,
    CreatedOn = DateTime.ParseExact("2024-06-26T01:51:28.627023Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ThreeDs = new SubscriptionThreeDs
    {
        Mode = SubscriptionThreeDsMode.Normal,
        RedirectEndpoint = "redirect_endpoint8",
        RedirectId = new Guid("000023a4-0000-0000-0000-000000000000"),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Period = SubscriptionPeriod.Monthly,
    NextPayment = new SubscriptionNextPayment
    {
        Id = new Guid("00000110-0000-0000-0000-000000000000"),
        DueDate = DateTime.Parse("2016-03-13"),
        ZoneId = "zone_id8",
        Amount = 126,
        Currency = "currency8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SubscriptionPlan = new SubscriptionPlanSettings
    {
        PlanType = PlanSettingsType.FixedCycles,
        FixedCycles = 46,
        FixedCycleAmount = 112,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    InstallmentPlan = new SubscriptionInstallmentPlanResponse
    {
        PlanType = CombinedPlanType.FixedCycles,
        FixedCycles = CombinedInstallmentFixedCycles.Cycles12,
        FixedCyclesAmount = 198,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

