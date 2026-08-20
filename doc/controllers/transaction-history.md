# Transaction History

```csharp
TransactionHistoryApi transactionHistoryApi = client.TransactionHistoryApi;
```

## Class Name

`TransactionHistoryApi`

## Methods

* [List Transaction History](../../doc/controllers/transaction-history.md#list-transaction-history)
* [List Store Transaction History](../../doc/controllers/transaction-history.md#list-store-transaction-history)


# List Transaction History

Returns a paginated, searchable history of charges and refunds across all of the merchant's stores, combining both resource types into a single unified row shape.

```csharp
ListTransactionHistoryAsync(
    Models.TransactionHistoryMode? mode = null,
    string shortId = null,
    string from = null,
    string to = null,
    Models.TransactionHistoryStatus? status = null,
    Models.TransactionHistoryType? type = null,
    string search = null,
    string email = null,
    Guid? id = null,
    string metadata = null,
    string cardExp = null,
    string cardLastFour = null,
    string cardholder = null,
    List<string> cardBrand = null,
    List<string> brand = null,
    List<string> brands = null,
    string currency = null,
    Models.TransactionHistoryServiceProvider? serviceProvider = null,
    List<Models.TransactionHistoryServiceProvider> serviceProviders = null,
    string gatewayTransactionId = null,
    List<Models.BankTransferPaymentStatus> bankTransferPaymentStatuses = null,
    string bankTransferLatestDepositDateFrom = null,
    string bankTransferLatestDepositDateTo = null,
    int? limit = 10,
    Guid? cursor = null,
    Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mode` | [`TransactionHistoryMode?`](../../doc/models/transaction-history-mode.md) | Query, Optional | Filter by environment mode. |
| `shortId` | `string` | Query, Optional | Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters. |
| `from` | `string` | Query, Optional | Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`. |
| `to` | `string` | Query, Optional | Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`. |
| `status` | [`TransactionHistoryStatus?`](../../doc/models/transaction-history-status.md) | Query, Optional | Filter by status. Accepts any charge or refund status value. |
| `type` | [`TransactionHistoryType?`](../../doc/models/transaction-history-type.md) | Query, Optional | Filter by row type. |
| `search` | `string` | Query, Optional | Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially. |
| `email` | `string` | Query, Optional | Filter by email address. |
| `id` | `Guid?` | Query, Optional | Filter by exact charge or refund ID. |
| `metadata` | `string` | Query, Optional | Filter by metadata. |
| `cardExp` | `string` | Query, Optional | Filter by card expiration, in `yyyy-MM` format. |
| `cardLastFour` | `string` | Query, Optional | Filter by the last 4 digits of the card. Must be exactly 4 characters. |
| `cardholder` | `string` | Query, Optional | Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match. |
| `cardBrand` | `List<string>` | Query, Optional | Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `brand` | `List<string>` | Query, Optional | Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `brands` | `List<string>` | Query, Optional | Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `currency` | `string` | Query, Optional | Filter by currency (ISO-4217). |
| `serviceProvider` | [`TransactionHistoryServiceProvider?`](../../doc/models/transaction-history-service-provider.md) | Query, Optional | Filter by service provider. |
| `serviceProviders` | [`List<TransactionHistoryServiceProvider>`](../../doc/models/transaction-history-service-provider.md) | Query, Optional | Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated. |
| `gatewayTransactionId` | `string` | Query, Optional | Filter by the gateway's own transaction ID (free text). |
| `bankTransferPaymentStatuses` | [`List<BankTransferPaymentStatus>`](../../doc/models/bank-transfer-payment-status.md) | Query, Optional | Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`). |
| `bankTransferLatestDepositDateFrom` | `string` | Query, Optional | Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time. |
| `bankTransferLatestDepositDateTo` | `string` | Query, Optional | End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time. |
| `limit` | `int?` | Query, Optional | Maximum number of resources to return in one page.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 100` |
| `cursor` | `Guid?` | Query, Optional | Cursor pointing to the resource after which pagination should continue. |
| `cursorDirection` | [`CursorDirectionQuery?`](../../doc/models/cursor-direction-query.md) | Query, Optional | Pagination direction relative to the supplied cursor.<br><br>**Default**: `CursorDirectionQuery.desc` |

## Response Type

**200**: Paginated transaction history.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionHistoryList](../../doc/models/transaction-history-list.md).

## Example Usage

```csharp
TransactionHistoryMode? mode = TransactionHistoryMode.Test;
string shortId = "8bfc29";
string from = "04/01/2026 00:00:00";
string to = "04/30/2026 23:59:59";
TransactionHistoryStatus? status = TransactionHistoryStatus.Successful;
TransactionHistoryType? type = TransactionHistoryType.Charge;
string search = "Taro Yamada";
string email = "user@example.com";
Guid? id = new Guid("11ef0000-0000-4000-8000-000000000070");
string metadata = "order_id: 12345";
string cardExp = "2026-04";
string cardLastFour = "4242";
string cardholder = "TARO YAMADA";
List<string> cardBrand = Liquid error: Value cannot be null. (Parameter 'key');

List<string> brand = Liquid error: Value cannot be null. (Parameter 'key');

List<string> brands = Liquid error: Value cannot be null. (Parameter 'key');

string currency = "JPY";
TransactionHistoryServiceProvider? serviceProvider = TransactionHistoryServiceProvider.Credit;
List<TransactionHistoryServiceProvider> serviceProviders = Liquid error: Value cannot be null. (Parameter 'key');

string gatewayTransactionId = "gw-txn-00123456";
List<BankTransferPaymentStatus> bankTransferPaymentStatuses = Liquid error: Value cannot be null. (Parameter 'key');

string bankTransferLatestDepositDateFrom = "04/01/2026 00:00:00";
string bankTransferLatestDepositDateTo = "04/30/2026 23:59:59";
int? limit = 10;
Guid? cursor = new Guid("3541d4fa-596d-428e-8a36-f274e1b3d505");
CursorDirectionQuery? cursorDirection = CursorDirectionQuery.Asc;
try
{
    ApiResponse<TransactionHistoryList> result = await transactionHistoryApi.ListTransactionHistoryAsync(
        mode,
        shortId,
        from,
        to,
        status,
        type,
        search,
        email,
        id,
        metadata,
        cardExp,
        cardLastFour,
        cardholder,
        cardBrand,
        brand,
        brands,
        currency,
        serviceProvider,
        serviceProviders,
        gatewayTransactionId,
        bankTransferPaymentStatuses,
        bankTransferLatestDepositDateFrom,
        bankTransferLatestDepositDateTo,
        limit,
        cursor,
        cursorDirection
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "items": [
    {
      "store_id": "11edf541-c42d-653c-8c3d-dfe0a55f95c0",
      "resource_id": "11ef0000-0000-4000-8000-000000000070",
      "charge_id": null,
      "amount": 1000,
      "currency": "JPY",
      "amount_formatted": 1000,
      "type": "charge",
      "status": "successful",
      "metadata": {},
      "created_on": "2024-05-01T12:34:56.789Z",
      "mode": "test",
      "merchant_name": "Test merchant",
      "store_name": "Test store",
      "payment_type": "card",
      "user_data": {
        "type": "charge",
        "cardholder_name": "Some Guy",
        "cardholder_email_address": "test4@univapay.com",
        "brand": "visa",
        "gateway": "test",
        "service_provider": "credit",
        "refunds": [
          {
            "refund_id": "11ef0000-0000-4000-8000-000000000010",
            "amount": 500,
            "currency": "JPY",
            "amount_formatted": 500,
            "status": "successful"
          }
        ]
      },
      "bank_transfer_payment_status": null,
      "bank_transfer_latest_deposit_date": null,
      "mcp_token_id": null,
      "charge_type": "normal"
    },
    {
      "store_id": "11edf541-c42d-653c-8c3d-dfe0a55f95c0",
      "resource_id": "11ef0000-0000-4000-8000-000000000010",
      "charge_id": "11ef0000-0000-4000-8000-000000000070",
      "amount": 500,
      "currency": "JPY",
      "amount_formatted": 500,
      "type": "refund",
      "status": "successful",
      "metadata": {},
      "created_on": "2024-05-01T13:00:00.000000Z",
      "mode": "test",
      "merchant_name": "Test merchant",
      "store_name": "Test store",
      "payment_type": "card",
      "user_data": {
        "type": "refund",
        "reason": "customer_request"
      },
      "bank_transfer_payment_status": null,
      "bank_transfer_latest_deposit_date": null,
      "mcp_token_id": null,
      "charge_type": null
    }
  ],
  "has_more": false,
  "total_hits": 2
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |


# List Store Transaction History

Returns a paginated, searchable history of charges and refunds for a single store, combining both resource types into a single unified row shape.

```csharp
ListStoreTransactionHistoryAsync(
    Guid storeId,
    Models.TransactionHistoryMode? mode = null,
    string shortId = null,
    string from = null,
    string to = null,
    Models.TransactionHistoryStatus? status = null,
    Models.TransactionHistoryType? type = null,
    string search = null,
    string email = null,
    Guid? id = null,
    string metadata = null,
    string cardExp = null,
    string cardLastFour = null,
    string cardholder = null,
    List<string> cardBrand = null,
    List<string> brand = null,
    List<string> brands = null,
    string currency = null,
    Models.TransactionHistoryServiceProvider? serviceProvider = null,
    List<Models.TransactionHistoryServiceProvider> serviceProviders = null,
    string gatewayTransactionId = null,
    List<Models.BankTransferPaymentStatus> bankTransferPaymentStatuses = null,
    string bankTransferLatestDepositDateFrom = null,
    string bankTransferLatestDepositDateTo = null,
    int? limit = 10,
    Guid? cursor = null,
    Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc)
```

## Authentication

This endpoint requires [JWT_TOKEN](../../doc/auth/oauth-2-bearer-token.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storeId` | `Guid` | Template, Required | The unique identifier of the store. |
| `mode` | [`TransactionHistoryMode?`](../../doc/models/transaction-history-mode.md) | Query, Optional | Filter by environment mode. |
| `shortId` | `string` | Query, Optional | Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters. |
| `from` | `string` | Query, Optional | Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`. |
| `to` | `string` | Query, Optional | Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`. |
| `status` | [`TransactionHistoryStatus?`](../../doc/models/transaction-history-status.md) | Query, Optional | Filter by status. Accepts any charge or refund status value. |
| `type` | [`TransactionHistoryType?`](../../doc/models/transaction-history-type.md) | Query, Optional | Filter by row type. |
| `search` | `string` | Query, Optional | Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially. |
| `email` | `string` | Query, Optional | Filter by email address. |
| `id` | `Guid?` | Query, Optional | Filter by exact charge or refund ID. |
| `metadata` | `string` | Query, Optional | Filter by metadata. |
| `cardExp` | `string` | Query, Optional | Filter by card expiration, in `yyyy-MM` format. |
| `cardLastFour` | `string` | Query, Optional | Filter by the last 4 digits of the card. Must be exactly 4 characters. |
| `cardholder` | `string` | Query, Optional | Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match. |
| `cardBrand` | `List<string>` | Query, Optional | Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `brand` | `List<string>` | Query, Optional | Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `brands` | `List<string>` | Query, Optional | Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response. |
| `currency` | `string` | Query, Optional | Filter by currency (ISO-4217). |
| `serviceProvider` | [`TransactionHistoryServiceProvider?`](../../doc/models/transaction-history-service-provider.md) | Query, Optional | Filter by service provider. |
| `serviceProviders` | [`List<TransactionHistoryServiceProvider>`](../../doc/models/transaction-history-service-provider.md) | Query, Optional | Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated. |
| `gatewayTransactionId` | `string` | Query, Optional | Filter by the gateway's own transaction ID (free text). |
| `bankTransferPaymentStatuses` | [`List<BankTransferPaymentStatus>`](../../doc/models/bank-transfer-payment-status.md) | Query, Optional | Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`). |
| `bankTransferLatestDepositDateFrom` | `string` | Query, Optional | Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time. |
| `bankTransferLatestDepositDateTo` | `string` | Query, Optional | End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time. |
| `limit` | `int?` | Query, Optional | Maximum number of resources to return in one page.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 100` |
| `cursor` | `Guid?` | Query, Optional | Cursor pointing to the resource after which pagination should continue. |
| `cursorDirection` | [`CursorDirectionQuery?`](../../doc/models/cursor-direction-query.md) | Query, Optional | Pagination direction relative to the supplied cursor.<br><br>**Default**: `CursorDirectionQuery.desc` |

## Response Type

**200**: Paginated transaction history for the store.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TransactionHistoryList](../../doc/models/transaction-history-list.md).

## Example Usage

```csharp
Guid storeId = new Guid("0cab399b-5621-425b-993b-f8507eba1e78");
TransactionHistoryMode? mode = TransactionHistoryMode.Test;
string shortId = "8bfc29";
string from = "04/01/2026 00:00:00";
string to = "04/30/2026 23:59:59";
TransactionHistoryStatus? status = TransactionHistoryStatus.Successful;
TransactionHistoryType? type = TransactionHistoryType.Charge;
string search = "Taro Yamada";
string email = "user@example.com";
Guid? id = new Guid("11ef0000-0000-4000-8000-000000000070");
string metadata = "order_id: 12345";
string cardExp = "2026-04";
string cardLastFour = "4242";
string cardholder = "TARO YAMADA";
List<string> cardBrand = Liquid error: Value cannot be null. (Parameter 'key');

List<string> brand = Liquid error: Value cannot be null. (Parameter 'key');

List<string> brands = Liquid error: Value cannot be null. (Parameter 'key');

string currency = "JPY";
TransactionHistoryServiceProvider? serviceProvider = TransactionHistoryServiceProvider.Credit;
List<TransactionHistoryServiceProvider> serviceProviders = Liquid error: Value cannot be null. (Parameter 'key');

string gatewayTransactionId = "gw-txn-00123456";
List<BankTransferPaymentStatus> bankTransferPaymentStatuses = Liquid error: Value cannot be null. (Parameter 'key');

string bankTransferLatestDepositDateFrom = "04/01/2026 00:00:00";
string bankTransferLatestDepositDateTo = "04/30/2026 23:59:59";
int? limit = 10;
Guid? cursor = new Guid("3541d4fa-596d-428e-8a36-f274e1b3d505");
CursorDirectionQuery? cursorDirection = CursorDirectionQuery.Asc;
try
{
    ApiResponse<TransactionHistoryList> result = await transactionHistoryApi.ListStoreTransactionHistoryAsync(
        storeId,
        mode,
        shortId,
        from,
        to,
        status,
        type,
        search,
        email,
        id,
        metadata,
        cardExp,
        cardLastFour,
        cardholder,
        cardBrand,
        brand,
        brands,
        currency,
        serviceProvider,
        serviceProviders,
        gatewayTransactionId,
        bankTransferPaymentStatuses,
        bankTransferLatestDepositDateFrom,
        bankTransferLatestDepositDateTo,
        limit,
        cursor,
        cursorDirection
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ApiErrorException)
    {
       // TODO: Handle ApiErrorException exception here
    }
}
```

## Example Response *(as JSON)*

```json
{
  "items": [
    {
      "store_id": "11edf541-c42d-653c-8c3d-dfe0a55f95c0",
      "resource_id": "11ef0000-0000-4000-8000-000000000072",
      "charge_id": null,
      "amount": 2500,
      "currency": "JPY",
      "amount_formatted": 2500,
      "type": "charge",
      "status": "awaiting",
      "metadata": {},
      "created_on": "2024-05-03T10:00:00.000000Z",
      "mode": "live",
      "merchant_name": "Test merchant",
      "store_name": "Test store",
      "payment_type": "bank_transfer",
      "user_data": {
        "type": "charge",
        "cardholder_email_address": "test_bank_transfer@test.com",
        "brand": "aozora_bank",
        "gateway": "aozora_bank",
        "service_provider": "bank_transfer",
        "refunds": []
      },
      "bank_transfer_payment_status": "unpaid",
      "bank_transfer_latest_deposit_date": null,
      "mcp_token_id": null,
      "charge_type": "normal"
    }
  ],
  "has_more": false,
  "total_hits": 1
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request (400). The request was invalid or could not be processed.  Common codes: VALIDATION_ERROR, INVALID_TOKEN_TYPE, NOT_SUPPORTED_BY_PROCESSOR. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 401 | Unauthorized (401). Authentication failed.  Common codes: AUTH_HEADER_MISSING, INVALID_APP_TOKEN, INVALID_CREDENTIALS. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden (403). The request is understood, but access is refused.  This occurs if permissions are insufficient or if a security lock is triggered. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found (404). The requested resource (e.g., Store ID or Token ID) does not exist. | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 429 | Too Many Requests (429). Rate limit exceeded. Returns an empty JSON object in this spec. | `ApiException` |

