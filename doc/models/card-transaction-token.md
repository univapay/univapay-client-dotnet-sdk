
# Card Transaction Token

Stored transaction token resource for a `card` payment type.

*This model accepts additional fields of type object.*

## Structure

`CardTransactionToken`

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
| `PaymentType` | `string` | Required, Constant | Payment method type. Always `card` for this variant.<br><br>**Value**: `"card"` |
| `Data` | [`TokenResponseCardData`](../../doc/models/token-response-card-data.md) | Required | Token Response Card Data schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using System.Collections.Generic;
using System.Globalization;
using UnivaPay.Models;
using UnivaPay.Models.Containers;
using UnivaPay.Utilities;

CardTransactionToken cardTransactionToken = new CardTransactionToken
{
    PaymentType = "card",
    Data = new TokenResponseCardData
    {
        Card = new TokenResponseCardDataCard
        {
            Cardholder = "TARO YAMADA",
            ExpMonth = 12,
            ExpYear = 2026,
            CardBin = "424242",
            LastFour = "4242",
            Brand = "visa",
            CardType = "credit",
            Country = "JP",
            Category = "standard",
            Issuer = null,
            SubBrand = "none",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Billing = new TokenResponseCardDataBilling
        {
            Line1 = "1-1-1",
            Line2 = "Shibakoen",
            State = "Tokyo",
            City = "Minato",
            Country = "JP",
            Zip = "105-0011",
            PhoneNumber = new TokenResponsePhoneNumber
            {
                CountryCode = 81,
                LocalNumber = "08012341234",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        CvvAuthorize = new TokenResponseCardDataCvvAuthorize
        {
            Enabled = true,
            Status = "successful",
            ChargeId = null,
            CredentialsId = null,
            Currency = "JPY",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        CvvAuthorizeCheck = new TokenResponseCardDataCvvAuthorizeCheck
        {
            Status = "successful",
            ChargeId = null,
            Date = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        ThreeDs = new TokenResponseCardDataThreeDs
        {
            Enabled = true,
            Status = TokenResponseCardDataThreeDsStatus.Successful,
            RedirectEndpoint = null,
            RedirectId = null,
            Exempted = false,
            Error = null,
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

