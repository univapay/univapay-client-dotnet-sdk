
# Konbini Transaction Token

Stored transaction token resource for a `konbini` payment type.

*This model accepts additional fields of type object.*

## Structure

`KonbiniTransactionToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique identifier. |
| `StoreId` | `Guid?` | Optional | Store identifier. |
| `Email` | `string` | Optional | Customer email address. |
| `Active` | `bool?` | Optional | Whether the resource is active. |
| `Mode` | [`TransactionTokenMode?`](../../doc/models/transaction-token-mode.md) | Optional | Transaction Token Mode schema. |
| `Type` | [`TransactionTokenType?`](../../doc/models/transaction-token-type.md) | Optional | Transaction Token Type schema. |
| `UsageLimit` | `string` | Optional | Usage limit applied to the token. |
| `Confirmed` | `bool?` | Optional | Whether the token has been confirmed. |
| `Metadata` | [`Dictionary<string, TransactionTokenMetadataAdditionalProperties>`](../../doc/models/containers/transaction-token-metadata-additional-properties.md) | Optional | Transaction Token Metadata Additional Properties schema. |
| `CreatedOn` | `DateTime?` | Optional | Timestamp when the resource was created. |
| `UpdatedOn` | `DateTime?` | Optional | Timestamp when the resource was last updated. |
| `LastUsedOn` | `DateTime?` | Optional | Timestamp when the token was last used. |
| `PaymentType` | `string` | Required, Constant | Payment method type. Always `konbini` for this variant.<br><br>**Value**: `"konbini"` |
| `Data` | [`TokenResponseKonbiniData`](../../doc/models/token-response-konbini-data.md) | Required | Token Response Konbini Data schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

KonbiniTransactionToken konbiniTransactionToken = new KonbiniTransactionToken
{
    PaymentType = "konbini",
    Data = new TokenResponseKonbiniData
    {
        CustomerName = "Taro Yamada",
        ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
        ExpirationPeriod = "P7D",
        ExpirationTimeShift = null,
        PhoneNumber = new TokenResponsePhoneNumber
        {
            CountryCode = 81,
            LocalNumber = "08012341234",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Id = new Guid("6426bbd2-17bd-41bf-883b-1fe970db48ee"),
    StoreId = new Guid("fc264608-9a9e-495e-844e-a08129a81af4"),
    Email = "test@univapay.com",
    Active = true,
    Mode = TransactionTokenMode.Live,
    Type = TransactionTokenType.OneTime,
    UsageLimit = "example",
    Confirmed = true,
    Metadata = new Dictionary<string, TransactionTokenMetadataAdditionalProperties>
    {
        ["customer_id"] = TransactionTokenMetadataAdditionalProperties.FromString("cust_12345"),
    },
    CreatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedOn = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastUsedOn = DateTime.ParseExact("2026-04-09T07:35:50.000000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

