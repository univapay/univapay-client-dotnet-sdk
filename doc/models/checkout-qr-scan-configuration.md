
# Checkout Qr Scan Configuration

QR-scan (CPM) payment settings applied to checkout.

*This model accepts additional fields of type object.*

## Structure

`CheckoutQrScanConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enabled` | `bool?` | Optional | Whether QR-scan payments are enabled. |
| `ForbiddenQrScanGateways` | `List<string>` | Optional | QR-scan gateways disabled for the merchant. Common values include `alipay`, `alipay_plus`, `pay_pay`, `we_chat`, `univapay`, and `test`. `null` when no gateway is forbidden. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using UnivaPay.Models;
using UnivaPay.Utilities;

CheckoutQrScanConfiguration checkoutQrScanConfiguration = new CheckoutQrScanConfiguration
{
    Enabled = true,
    ForbiddenQrScanGateways = new List<string>
    {
        "forbidden_qr_scan_gateways1",
        "forbidden_qr_scan_gateways0",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

