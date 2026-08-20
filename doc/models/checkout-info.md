
# Checkout Info

Merchant/store checkout configuration: enabled payment methods and their limits, installment/subscription plan settings, convenience-store and bank-transfer settings, widget theme, and per-brand feature support. Returned in full on every call — there is no partial-update or list variant.

*This model accepts additional fields of type object.*

## Structure

`CheckoutInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mode` | [`CheckoutMode?`](../../doc/models/checkout-mode.md) | Optional | Store processing mode reflected in the checkout configuration: `live` and `test` reflect the credential used to authenticate, while `live_test` is reserved for privileged callers testing against live-mode data. |
| `RecurringTokenPrivilege` | [`CheckoutRecurringTokenPrivilege?`](../../doc/models/checkout-recurring-token-privilege.md) | Optional | Level of recurring-charge privilege granted to transaction tokens created under this store: `none` disallows recurring use, `bounded` allows a limited number of recurring charges, and `infinite` allows unlimited recurring charges. |
| `Name` | `string` | Optional | Store display name. |
| `CardConfiguration` | [`CheckoutCardConfiguration`](../../doc/models/checkout-card-configuration.md) | Optional | Card payment settings applied to checkout. |
| `SubscriptionConfiguration` | [`CheckoutSubscriptionConfiguration`](../../doc/models/checkout-subscription-configuration.md) | Optional | Univapay-hosted subscription feature toggle. |
| `InstallmentsConfiguration` | [`CheckoutInstallmentsConfiguration`](../../doc/models/checkout-installments-configuration.md) | Optional | Installment plan configuration applied to checkout. |
| `SubscriptionPlanConfiguration` | [`CheckoutSubscriptionPlanConfiguration`](../../doc/models/checkout-subscription-plan-configuration.md) | Optional | Univapay-side subscription plan configuration applied to checkout. |
| `CheckoutConfiguration` | [`CheckoutEcConfiguration`](../../doc/models/checkout-ec-configuration.md) | Optional | EC checkout feature toggles for hosted email receipts and product line items. |
| `QrScanConfiguration` | [`CheckoutQrScanConfiguration`](../../doc/models/checkout-qr-scan-configuration.md) | Optional | QR-scan (CPM) payment settings applied to checkout. |
| `ConvenienceConfiguration` | [`CheckoutConvenienceConfiguration`](../../doc/models/checkout-convenience-configuration.md) | Optional | Convenience-store (konbini) payment settings applied to checkout. |
| `PaidyConfiguration` | [`CheckoutPaidyConfiguration`](../../doc/models/checkout-paidy-configuration.md) | Optional | Paidy payment feature toggle. |
| `PaidyPublicKey` | `string` | Optional | Public key used to initialize the Paidy widget. `null` when Paidy is not configured for this store. |
| `LogoImage` | `string` | Optional | URL of the store's checkout logo image. `null` when no logo is configured. Note: this response field is `logo_image`, but the corresponding store-configuration update field is `logo_url` — the two names do not round-trip automatically. |
| `Theme` | [`CheckoutTheme`](../../doc/models/checkout-theme.md) | Optional | Widget theme applied to checkout. |
| `RecurringCardChargeCvvConfirmation` | [`RecurringCvvConfirmation`](../../doc/models/recurring-cvv-confirmation.md) | Optional | CVV re-confirmation policy applied to recurring card charges (subscriptions and tokens with recurring privilege). |
| `OnlineConfiguration` | [`CheckoutOnlineConfiguration`](../../doc/models/checkout-online-configuration.md) | Optional | Online redirect/wallet payment feature toggle. |
| `BankTransferConfiguration` | [`CheckoutBankTransferConfiguration`](../../doc/models/checkout-bank-transfer-configuration.md) | Optional | Bank transfer (振込) payment settings applied to checkout. |
| `SupportedBrands` | [`List<CheckoutSupportedBrand>`](../../doc/models/checkout-supported-brand.md) | Optional | Feature support and capability flags for every payment-type / brand combination the store can accept. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutInfo checkoutInfo = new CheckoutInfo
{
    Mode = CheckoutMode.Test,
    RecurringTokenPrivilege = CheckoutRecurringTokenPrivilege.None,
    Name = "Test store",
    CardConfiguration = new CheckoutCardConfiguration
    {
        Enabled = false,
        DebitEnabled = false,
        PrepaidEnabled = false,
        DebitAuthorizationEnabled = false,
        PrepaidAuthorizationEnabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SubscriptionConfiguration = new CheckoutSubscriptionConfiguration
    {
        Enabled = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SupportedBrands = new List<CheckoutSupportedBrand>
    {
        new CheckoutSupportedBrand
        {
            PaymentType = CheckoutPaymentType.Card,
            Brand = "visa",
            CardBrand = "visa",
            QrBrand = "qr_brand4",
            OnlineBrand = "online_brand2",
            DynamicInfo = false,
            SupportAuthCapture = true,
            RequiresFullName = false,
            RequiresCvv = true,
            CountriesAllowed = null,
            SupportedCurrencies = null,
            CvvAuth = false,
            InstallmentCapable = true,
            McpCapable = false,
            McpOnly = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new CheckoutSupportedBrand
        {
            PaymentType = CheckoutPaymentType.QrMerchant,
            Brand = "alipay_merchant_qr",
            CardBrand = "card_brand4",
            QrBrand = "alipay_merchant_qr",
            OnlineBrand = "online_brand2",
            DynamicInfo = false,
            SupportAuthCapture = false,
            RequiresFullName = false,
            RequiresCvv = false,
            CountriesAllowed = null,
            SupportedCurrencies = null,
            CvvAuth = false,
            InstallmentCapable = false,
            McpCapable = false,
            McpOnly = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

