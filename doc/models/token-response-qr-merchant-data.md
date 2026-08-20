
# Token Response Qr Merchant Data

Token Response Qr Merchant Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenResponseQrMerchantData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QrImageUrl` | `string` | Required | QR code payload to be rendered by the consumer (content varies by brand — may be a URL or an opaque code). Some brands return an image URL; others (e.g. convenience-store QR brands) return an opaque numeric code with no URL structure. Populated asynchronously shortly after token/charge creation — `null` until then. |
| `Brand` | `string` | Optional | The QR-MPM brand this code was generated for. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenResponseQrMerchantData tokenResponseQrMerchantData = new TokenResponseQrMerchantData
{
    QrImageUrl = "71001234567890202604141200450",
    Brand = "pay_pay_merchant",
};
```

