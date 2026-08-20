
# Token Create Qr Scan Data

Token Create Qr Scan Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateQrScanData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ScannedQr` | `string` | Required | The QR/barcode payload scanned from the customer's payment app (Customer-Presented Mode). Only valid when `type` is `one_time` — the server rejects `subscription`/`recurring` token types for this payment type. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenCreateQrScanData tokenCreateQrScanData = new TokenCreateQrScanData
{
    ScannedQr = "091234567890123456789012345",
};
```

