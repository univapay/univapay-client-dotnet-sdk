
# Store

Store resource returned by the backend `FullStore` formatter. It combines core store identity with the resolved configuration snapshot used for runtime policy evaluation.

*This model accepts additional fields of type object.*

## Structure

`Store`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Store identifier. |
| `Name` | `string` | Optional | Store display name. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the store was created. |
| `Configuration` | [`MerchantWebhookConfiguration`](../../doc/models/merchant-webhook-configuration.md) | Optional | Store-scoped configuration snapshot as serialized by the backend. It uses the same flattened serializer as merchant configuration, but omits `transfer_schedule`. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;

Store store = new Store
{
    Id = new Guid("11ef0000-0000-4000-8000-000000000022"),
    Name = "Tokyo Store",
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Configuration = new MerchantWebhookConfiguration
    {
        PercentFee = 3.6,
        Country = "JP",
        Language = "ja",
        MinimumChargeAmounts = new List<MerchantWebhookMoneyAmount>
        {
            new MerchantWebhookMoneyAmount
            {
                Amount = 100,
                Currency = "JPY",
            },
        },
        MaximumChargeAmounts = new List<MerchantWebhookMoneyAmount>
        {
            new MerchantWebhookMoneyAmount
            {
                Amount = 100000,
                Currency = "JPY",
            },
        },
        UserTransactionsConfiguration = new MerchantWebhookUserTransactionsConfiguration
        {
            Enabled = true,
            NotifyCustomer = true,
            NotifyOnWebhookFailure = true,
        },
        RecurringTokenConfiguration = new MerchantWebhookRecurringTokenConfiguration
        {
            RecurringType = "infinite",
            ChargeWaitPeriod = "P7D",
            CardChargeCvvConfirmation = new MerchantWebhookRecurringCvvConfirmationConfig
            {
                Enabled = false,
            },
        },
        SecurityConfiguration = new MerchantWebhookSecurityConfiguration
        {
            CardChargeCooldown = "PT5M",
            SubscriptionCooldown = "PT10M",
            RestrictIpAfterFailedCharge = new RestrictIpAfterFailedChargeConfig
            {
                Enabled = true,
                Count = 5,
                Cooldown = "PT1H",
            },
            RefundPercentLimit = 100,
            ConfirmationRequired = false,
            MinRefundThreshold = 100,
            LimitRefundBySales = new MerchantWebhookLimitRefundBySalesConfiguration
            {
                Enabled = true,
                Period = "monthly",
                RollingWindow = true,
            },
        },
        InstallmentsConfiguration = new MerchantWebhookInstallmentPlanConfiguration
        {
            Enabled = true,
            CardProcessor = new CardProcessorInstallmentConfig
            {
                Revolving = true,
                FixedCycle = true,
            },
            SupportedPaymentTypes = new List<string>
            {
                "card",
            },
            MinChargeAmount = new MerchantWebhookMoneyAmount
            {
                Amount = 3000,
                Currency = "JPY",
            },
            MaxPayoutPeriod = "P12M",
            OnlyWithProcessor = true,
        },
        CardBrandPercentFees = new MerchantWebhookCardBrandPercentFees
        {
            Visa = 3.6,
            Mastercard = 3.6,
            Jcb = 3.8,
        },
        CardConfiguration = new MerchantWebhookCardConfiguration
        {
            Enabled = true,
            DebitEnabled = true,
            PrepaidEnabled = false,
            ThreeDsRequired = true,
        },
        QrScanConfiguration = new MerchantWebhookQrScanConfiguration
        {
            Enabled = true,
            ForbiddenQrScanGateways = new List<string>
            {
                "wechat",
            },
        },
        ConvenienceConfiguration = new MerchantWebhookConvenienceConfiguration
        {
            Enabled = true,
            Expiration = "P3D",
        },
        PaidyConfiguration = new MerchantWebhookPaidyConfiguration
        {
            Enabled = false,
        },
        OnlineConfiguration = new MerchantWebhookOnlineConfiguration
        {
            Enabled = true,
        },
        BankTransferConfiguration = new MerchantWebhookBankTransferConfiguration
        {
            Enabled = true,
            MatchAmount = true,
            Expiration = "P7D",
        },
    },
};
```

