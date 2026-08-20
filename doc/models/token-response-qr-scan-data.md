
# Token Response Qr Scan Data

Token Response Qr Scan Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseQrScanData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Required | QR-CPM brand detected from the scanned code (e.g. `pay_pay`, `we_chat`, `qq`, `line_pay`, `au_pay`, `alipay_china`). This is an open value set — new brands may appear without notice. Returned as `null` when the scanned code could not be parsed into a known brand. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenResponseQrScanData tokenResponseQrScanData = new TokenResponseQrScanData
{
    Brand = "pay_pay",
};
```

