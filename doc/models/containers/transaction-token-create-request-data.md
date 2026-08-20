
# Transaction Token Create Request Data

Transaction Token Create Request Data schema.

## Class Name

`TransactionTokenCreateRequestData`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`TokenCreateCardData`](../../../doc/models/token-create-card-data.md) | TransactionTokenCreateRequestData.FromTokenCreateCardData(TokenCreateCardData tokenCreateCardData) |
| [`TokenCreateKonbiniData`](../../../doc/models/token-create-konbini-data.md) | TransactionTokenCreateRequestData.FromTokenCreateKonbiniData(TokenCreateKonbiniData tokenCreateKonbiniData) |
| [`TokenCreateOnlineData`](../../../doc/models/token-create-online-data.md) | TransactionTokenCreateRequestData.FromTokenCreateOnlineData(TokenCreateOnlineData tokenCreateOnlineData) |
| [`TokenCreateBankTransferData`](../../../doc/models/token-create-bank-transfer-data.md) | TransactionTokenCreateRequestData.FromTokenCreateBankTransferData(TokenCreateBankTransferData tokenCreateBankTransferData) |
| [`TokenCreatePaidyData`](../../../doc/models/token-create-paidy-data.md) | TransactionTokenCreateRequestData.FromTokenCreatePaidyData(TokenCreatePaidyData tokenCreatePaidyData) |
| [`TokenCreateQrScanData`](../../../doc/models/token-create-qr-scan-data.md) | TransactionTokenCreateRequestData.FromTokenCreateQrScanData(TokenCreateQrScanData tokenCreateQrScanData) |
| [`TokenCreateQrMerchantData`](../../../doc/models/token-create-qr-merchant-data.md) | TransactionTokenCreateRequestData.FromTokenCreateQrMerchantData(TokenCreateQrMerchantData tokenCreateQrMerchantData) |

## TokenCreateCardData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateCardData(
    new TokenCreateCardData
    {
        CardNumber = "4242424242424242",
        ExpMonth = "12",
        ExpYear = "2026",
    }
);
```

## TokenCreateKonbiniData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateKonbiniData(
    new TokenCreateKonbiniData
    {
        CustomerName = "Taro Yamada",
        ConvenienceStore = BaseKonbiniDataConvenienceStore.SevenEleven,
        PhoneNumber = new TokenCreatePhoneNumber
        {
            CountryCode = "81",
            LocalNumber = "08012341234",
        },
        ExpirationPeriod = "P7D",
        ExpirationTimeShift = "23:59:59+09:00",
    }
);
```

## TokenCreateOnlineData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateOnlineData(
    new TokenCreateOnlineData
    {
        Brand = BaseOnlineDataBrand.WeChatOnline,
        CallMethod = BaseOnlineDataCallMethod.Web,
        UserIdentifier = "wechat_open_id_12345",
    }
);
```

## TokenCreateBankTransferData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateBankTransferData(
    new TokenCreateBankTransferData
    {
        Brand = "aozora_bank",
        ExpirationPeriod = "PT168H",
        ExpirationTimeShift = "23:59:59+09:00",
        Name = "Taro Yamada",
    }
);
```

## TokenCreatePaidyData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreatePaidyData(
    new TokenCreatePaidyData
    {
        PaidyToken = "paidy-token-abc123",
        ShippingAddress = new TokenCreatePaidyDataShippingAddress
        {
            Zip = "105-0011",
            Line1 = "1-1-1",
            City = "Minato",
            State = "Tokyo",
        },
        PhoneNumber = "08012341234",
    }
);
```

## TokenCreateQrScanData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateQrScanData(
    new TokenCreateQrScanData
    {
        ScannedQr = "091234567890123456789012345",
    }
);
```

## TokenCreateQrMerchantData

### Initialization Code

#### Example

```csharp
TransactionTokenCreateRequestData value = TransactionTokenCreateRequestData.FromTokenCreateQrMerchantData(
    new TokenCreateQrMerchantData
    {
        Brand = "pay_pay_merchant",
    }
);
```

