
# Transaction Token

Stored transaction token resource. `payment_type` discriminates which variant applies — and therefore the concrete shape of `data` — per the mapping above.

## Class Name

`TransactionToken`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`CardTransactionToken`](../../../doc/models/card-transaction-token.md) | TransactionToken.FromCardTransactionToken(CardTransactionToken cardTransactionToken) |
| [`KonbiniTransactionToken`](../../../doc/models/konbini-transaction-token.md) | TransactionToken.FromKonbiniTransactionToken(KonbiniTransactionToken konbiniTransactionToken) |
| [`OnlineTransactionToken`](../../../doc/models/online-transaction-token.md) | TransactionToken.FromOnlineTransactionToken(OnlineTransactionToken onlineTransactionToken) |
| [`BankTransferTransactionToken`](../../../doc/models/bank-transfer-transaction-token.md) | TransactionToken.FromBankTransferTransactionToken(BankTransferTransactionToken bankTransferTransactionToken) |
| [`PaidyTransactionToken`](../../../doc/models/paidy-transaction-token.md) | TransactionToken.FromPaidyTransactionToken(PaidyTransactionToken paidyTransactionToken) |
| [`QrScanTransactionToken`](../../../doc/models/qr-scan-transaction-token.md) | TransactionToken.FromQrScanTransactionToken(QrScanTransactionToken qrScanTransactionToken) |
| [`QrMerchantTransactionToken`](../../../doc/models/qr-merchant-transaction-token.md) | TransactionToken.FromQrMerchantTransactionToken(QrMerchantTransactionToken qrMerchantTransactionToken) |

## CardTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromCardTransactionToken(
    new CardTransactionToken
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
                },
            },
            CvvAuthorize = new TokenResponseCardDataCvvAuthorize
            {
                Enabled = true,
                Status = "successful",
                ChargeId = null,
                CredentialsId = null,
                Currency = "JPY",
            },
            CvvAuthorizeCheck = new TokenResponseCardDataCvvAuthorizeCheck
            {
                Status = "successful",
                ChargeId = null,
                Date = DateTime.ParseExact("2026-04-09T07:35:50Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                    provider: CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind),
            },
            ThreeDs = new TokenResponseCardDataThreeDs
            {
                Enabled = true,
                Status = TokenResponseCardDataThreeDsStatus.Successful,
                RedirectEndpoint = null,
                RedirectId = null,
                Exempted = false,
                Error = null,
            },
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
    }
);
```

## KonbiniTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromKonbiniTransactionToken(
    new KonbiniTransactionToken
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
            },
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
    }
);
```

## OnlineTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromOnlineTransactionToken(
    new OnlineTransactionToken
    {
        PaymentType = "online",
        Data = new TokenResponseOnlineData
        {
            Brand = BaseOnlineDataBrand.WeChatOnline,
            CallMethod = BaseOnlineDataCallMethod.Web,
            UserIdentifier = "wechat_open_id_12345",
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
    }
);
```

## BankTransferTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromBankTransferTransactionToken(
    new BankTransferTransactionToken
    {
        PaymentType = "bank_transfer",
        Data = new TokenResponseBankTransferData
        {
            Brand = "aozora_bank",
            ExpirationPeriod = "PT168H",
            ExpirationTimeShift = "23:59:59+09:00",
            BankCode = "0310",
            BankName = "GMOあおぞらネット銀行",
            BranchCode = "123",
            BranchName = "Test Branch",
            AccountNumber = "1234567",
            AccountHolderName = "TARO YAMADA",
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
    }
);
```

## PaidyTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromPaidyTransactionToken(
    new PaidyTransactionToken
    {
        PaymentType = "paidy",
        Data = new TokenResponsePaidyData
        {
            PaidyToken = "paidy-token-abc123",
            PhoneNumber = "08012341234",
            ShippingAddress = new TokenResponsePaidyDataShippingAddress
            {
                Zip = "105-0011",
                Line1 = "1-1-1",
                City = "Minato",
                State = "Tokyo",
            },
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
    }
);
```

## QrScanTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromQrScanTransactionToken(
    new QrScanTransactionToken
    {
        PaymentType = "qr_scan",
        Data = new TokenResponseQrScanData
        {
            Brand = "pay_pay",
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
    }
);
```

## QrMerchantTransactionToken

### Initialization Code

#### Example

```csharp
TransactionToken value = TransactionToken.FromQrMerchantTransactionToken(
    new QrMerchantTransactionToken
    {
        PaymentType = "qr_merchant",
        Data = new TokenResponseQrMerchantData
        {
            QrImageUrl = "71001234567890202604141200450",
            Brand = "pay_pay_merchant",
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
    }
);
```

