
# Token Create Online Data

Token Create Online Data schema.

*This model accepts additional fields of type object.*

## Structure

`TokenCreateOnlineData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | [`BaseOnlineDataBrand`](../../doc/models/base-online-data-brand.md) | Required | Base Online Data Brand schema. `alipay_china`, `alipay_hk`, `gcash`, `dana`, `truemoney`, `kakaopay`, `tng`, `rabbit_line_pay`, `bpi`, `boost`, `tinaba`, `naver_pay`, `toss_pay`, `maya`, `grab_sg`, `kredivo_id`, `k_plus`, and `kaspi_kz` are Alipay+ regional wallets routed through the `alipay_plus_online` gateway family. |
| `CallMethod` | [`BaseOnlineDataCallMethod`](../../doc/models/base-online-data-call-method.md) | Required | Base Online Data Call Method schema. |
| `OsType` | [`BaseOnlineDataOsType?`](../../doc/models/base-online-data-os-type.md) | Optional | Base Online Data Os Type schema. |
| `UserIdentifier` | `string` | Optional | Consumer specific identifier required by some gateways for fraud prevention. |
| `UserIdentifierSource` | [`BaseOnlineDataUserIdentifierSource?`](../../doc/models/base-online-data-user-identifier-source.md) | Optional | The source of the user identifier |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using UnivaPay.Models;

TokenCreateOnlineData tokenCreateOnlineData = new TokenCreateOnlineData
{
    Brand = BaseOnlineDataBrand.WeChatOnline,
    CallMethod = BaseOnlineDataCallMethod.Web,
    UserIdentifier = "wechat_open_id_12345",
};
```

