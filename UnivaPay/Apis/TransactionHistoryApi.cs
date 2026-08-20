// <copyright file="TransactionHistoryApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Exceptions;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// TransactionHistoryApi.
    /// </summary>
    public class TransactionHistoryApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionHistoryApi"/> class.
        /// </summary>
        internal TransactionHistoryApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds across all of the merchant's stores, combining both resource types into a single unified row shape.
        /// </summary>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="shortId">Optional parameter: Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters..</param>
        /// <param name="from">Optional parameter: Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`..</param>
        /// <param name="to">Optional parameter: Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`..</param>
        /// <param name="status">Optional parameter: Filter by status. Accepts any charge or refund status value..</param>
        /// <param name="type">Optional parameter: Filter by row type..</param>
        /// <param name="search">Optional parameter: Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="id">Optional parameter: Filter by exact charge or refund ID..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="cardExp">Optional parameter: Filter by card expiration, in `yyyy-MM` format..</param>
        /// <param name="cardLastFour">Optional parameter: Filter by the last 4 digits of the card. Must be exactly 4 characters..</param>
        /// <param name="cardholder">Optional parameter: Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match..</param>
        /// <param name="cardBrand"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brand"><![CDATA[Optional parameter: Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brands"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="serviceProvider">Optional parameter: Filter by service provider..</param>
        /// <param name="serviceProviders"><![CDATA[Optional parameter: Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated..]]></param>
        /// <param name="gatewayTransactionId">Optional parameter: Filter by the gateway's own transaction ID (free text)..</param>
        /// <param name="bankTransferPaymentStatuses"><![CDATA[Optional parameter: Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`)..]]></param>
        /// <param name="bankTransferLatestDepositDateFrom">Optional parameter: Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="bankTransferLatestDepositDateTo">Optional parameter: End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionHistoryList response from the API call.</returns>
        public ApiResponse<Models.TransactionHistoryList> ListTransactionHistory(
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
            => CoreHelper.RunTask(ListTransactionHistoryAsync(mode, shortId, from, to, status, type, search, email, id, metadata, cardExp, cardLastFour, cardholder, cardBrand, brand, brands, currency, serviceProvider, serviceProviders, gatewayTransactionId, bankTransferPaymentStatuses, bankTransferLatestDepositDateFrom, bankTransferLatestDepositDateTo, limit, cursor, cursorDirection));

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds across all of the merchant's stores, combining both resource types into a single unified row shape.
        /// </summary>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="shortId">Optional parameter: Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters..</param>
        /// <param name="from">Optional parameter: Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`..</param>
        /// <param name="to">Optional parameter: Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`..</param>
        /// <param name="status">Optional parameter: Filter by status. Accepts any charge or refund status value..</param>
        /// <param name="type">Optional parameter: Filter by row type..</param>
        /// <param name="search">Optional parameter: Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="id">Optional parameter: Filter by exact charge or refund ID..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="cardExp">Optional parameter: Filter by card expiration, in `yyyy-MM` format..</param>
        /// <param name="cardLastFour">Optional parameter: Filter by the last 4 digits of the card. Must be exactly 4 characters..</param>
        /// <param name="cardholder">Optional parameter: Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match..</param>
        /// <param name="cardBrand"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brand"><![CDATA[Optional parameter: Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brands"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="serviceProvider">Optional parameter: Filter by service provider..</param>
        /// <param name="serviceProviders"><![CDATA[Optional parameter: Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated..]]></param>
        /// <param name="gatewayTransactionId">Optional parameter: Filter by the gateway's own transaction ID (free text)..</param>
        /// <param name="bankTransferPaymentStatuses"><![CDATA[Optional parameter: Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`)..]]></param>
        /// <param name="bankTransferLatestDepositDateFrom">Optional parameter: Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="bankTransferLatestDepositDateTo">Optional parameter: End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionHistoryList response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionHistoryList>> ListTransactionHistoryAsync(
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
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionHistoryList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/transaction_history")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("mode", (mode.HasValue) ? CoreHelper.JsonSerialize(mode.Value).Trim('\"') : null))
                      .Query(query => query.Setup("short_id", shortId))
                      .Query(query => query.Setup("from", from))
                      .Query(query => query.Setup("to", to))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("type", (type.HasValue) ? CoreHelper.JsonSerialize(type.Value).Trim('\"') : null))
                      .Query(query => query.Setup("search", search))
                      .Query(query => query.Setup("email", email))
                      .Query(query => query.Setup("id", id))
                      .Query(query => query.Setup("metadata", metadata))
                      .Query(query => query.Setup("card_exp", cardExp))
                      .Query(query => query.Setup("card_last_four", cardLastFour))
                      .Query(query => query.Setup("cardholder", cardholder))
                      .Query(query => query.Setup("card_brand[]", cardBrand))
                      .Query(query => query.Setup("brand[]", brand))
                      .Query(query => query.Setup("brands[]", brands))
                      .Query(query => query.Setup("currency", currency))
                      .Query(query => query.Setup("service_provider", (serviceProvider.HasValue) ? CoreHelper.JsonSerialize(serviceProvider.Value).Trim('\"') : null))
                      .Query(query => query.Setup("service_providers[]", serviceProviders?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("gateway_transaction_id", gatewayTransactionId))
                      .Query(query => query.Setup("bank_transfer_payment_statuses[]", bankTransferPaymentStatuses?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("bank_transfer_latest_deposit_date.from", bankTransferLatestDepositDateFrom))
                      .Query(query => query.Setup("bank_transfer_latest_deposit_date.to", bankTransferLatestDepositDateTo))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds for a single store, combining both resource types into a single unified row shape.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="shortId">Optional parameter: Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters..</param>
        /// <param name="from">Optional parameter: Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`..</param>
        /// <param name="to">Optional parameter: Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`..</param>
        /// <param name="status">Optional parameter: Filter by status. Accepts any charge or refund status value..</param>
        /// <param name="type">Optional parameter: Filter by row type..</param>
        /// <param name="search">Optional parameter: Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="id">Optional parameter: Filter by exact charge or refund ID..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="cardExp">Optional parameter: Filter by card expiration, in `yyyy-MM` format..</param>
        /// <param name="cardLastFour">Optional parameter: Filter by the last 4 digits of the card. Must be exactly 4 characters..</param>
        /// <param name="cardholder">Optional parameter: Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match..</param>
        /// <param name="cardBrand"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brand"><![CDATA[Optional parameter: Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brands"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="serviceProvider">Optional parameter: Filter by service provider..</param>
        /// <param name="serviceProviders"><![CDATA[Optional parameter: Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated..]]></param>
        /// <param name="gatewayTransactionId">Optional parameter: Filter by the gateway's own transaction ID (free text)..</param>
        /// <param name="bankTransferPaymentStatuses"><![CDATA[Optional parameter: Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`)..]]></param>
        /// <param name="bankTransferLatestDepositDateFrom">Optional parameter: Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="bankTransferLatestDepositDateTo">Optional parameter: End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionHistoryList response from the API call.</returns>
        public ApiResponse<Models.TransactionHistoryList> ListStoreTransactionHistory(
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
            => CoreHelper.RunTask(ListStoreTransactionHistoryAsync(storeId, mode, shortId, from, to, status, type, search, email, id, metadata, cardExp, cardLastFour, cardholder, cardBrand, brand, brands, currency, serviceProvider, serviceProviders, gatewayTransactionId, bankTransferPaymentStatuses, bankTransferLatestDepositDateFrom, bankTransferLatestDepositDateTo, limit, cursor, cursorDirection));

        /// <summary>
        /// Returns a paginated, searchable history of charges and refunds for a single store, combining both resource types into a single unified row shape.
        /// </summary>
        /// <param name="storeId">Required parameter: The unique identifier of the store..</param>
        /// <param name="mode">Optional parameter: Filter by environment mode..</param>
        /// <param name="shortId">Optional parameter: Filter by the last 6 characters of a resource's UUID. Must be exactly 6 characters..</param>
        /// <param name="from">Optional parameter: Show rows created on or after this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be later than `to`..</param>
        /// <param name="to">Optional parameter: Show rows created on or before this date. Accepts epoch-millis or an ISO-8601 date-time. Must not be earlier than `from`..</param>
        /// <param name="status">Optional parameter: Filter by status. Accepts any charge or refund status value..</param>
        /// <param name="type">Optional parameter: Filter by row type..</param>
        /// <param name="search">Optional parameter: Free-text search across cardholder/customer name and email. Wrap a value in quotes (`"first last"`) for an exact-phrase match; an unquoted value matches partially..</param>
        /// <param name="email">Optional parameter: Filter by email address..</param>
        /// <param name="id">Optional parameter: Filter by exact charge or refund ID..</param>
        /// <param name="metadata">Optional parameter: Filter by metadata..</param>
        /// <param name="cardExp">Optional parameter: Filter by card expiration, in `yyyy-MM` format..</param>
        /// <param name="cardLastFour">Optional parameter: Filter by the last 4 digits of the card. Must be exactly 4 characters..</param>
        /// <param name="cardholder">Optional parameter: Filter by cardholder name. Partial match by default; wrap in quotes for an exact-phrase match..</param>
        /// <param name="cardBrand"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `card_brand[]=visa&card_brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brand"><![CDATA[Optional parameter: Filter by brand. Repeatable via the `[]` suffix (e.g. `brand[]=visa&brand[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="brands"><![CDATA[Optional parameter: Deprecated legacy alias of `brand`; use `brand` instead. Repeatable via the `[]` suffix (e.g. `brands[]=visa&brands[]=jcb`). Raw brand identifiers vary by payment type — see the `user_data.brand` field on this endpoint's response..]]></param>
        /// <param name="currency">Optional parameter: Filter by currency (ISO-4217)..</param>
        /// <param name="serviceProvider">Optional parameter: Filter by service provider..</param>
        /// <param name="serviceProviders"><![CDATA[Optional parameter: Filter by service provider. Repeatable via the `[]` suffix (e.g. `service_providers[]=credit&service_providers[]=paidy`). Must not be empty; duplicate values are deduplicated..]]></param>
        /// <param name="gatewayTransactionId">Optional parameter: Filter by the gateway's own transaction ID (free text)..</param>
        /// <param name="bankTransferPaymentStatuses"><![CDATA[Optional parameter: Filter bank transfer rows by payment status. Repeatable via the `[]` suffix (e.g. `bank_transfer_payment_statuses[]=unpaid&bank_transfer_payment_statuses[]=exact`)..]]></param>
        /// <param name="bankTransferLatestDepositDateFrom">Optional parameter: Start of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="bankTransferLatestDepositDateTo">Optional parameter: End of the range (inclusive) for `bank_transfer_latest_deposit_date`. Accepts epoch-millis or an ISO-8601 date-time..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionHistoryList response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionHistoryList>> ListStoreTransactionHistoryAsync(
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
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionHistoryList>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stores/{storeId}/transaction_history")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("storeId", storeId))
                      .Query(query => query.Setup("mode", (mode.HasValue) ? CoreHelper.JsonSerialize(mode.Value).Trim('\"') : null))
                      .Query(query => query.Setup("short_id", shortId))
                      .Query(query => query.Setup("from", from))
                      .Query(query => query.Setup("to", to))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))
                      .Query(query => query.Setup("type", (type.HasValue) ? CoreHelper.JsonSerialize(type.Value).Trim('\"') : null))
                      .Query(query => query.Setup("search", search))
                      .Query(query => query.Setup("email", email))
                      .Query(query => query.Setup("id", id))
                      .Query(query => query.Setup("metadata", metadata))
                      .Query(query => query.Setup("card_exp", cardExp))
                      .Query(query => query.Setup("card_last_four", cardLastFour))
                      .Query(query => query.Setup("cardholder", cardholder))
                      .Query(query => query.Setup("card_brand[]", cardBrand))
                      .Query(query => query.Setup("brand[]", brand))
                      .Query(query => query.Setup("brands[]", brands))
                      .Query(query => query.Setup("currency", currency))
                      .Query(query => query.Setup("service_provider", (serviceProvider.HasValue) ? CoreHelper.JsonSerialize(serviceProvider.Value).Trim('\"') : null))
                      .Query(query => query.Setup("service_providers[]", serviceProviders?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("gateway_transaction_id", gatewayTransactionId))
                      .Query(query => query.Setup("bank_transfer_payment_statuses[]", bankTransferPaymentStatuses?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("bank_transfer_latest_deposit_date.from", bankTransferLatestDepositDateFrom))
                      .Query(query => query.Setup("bank_transfer_latest_deposit_date.to", bankTransferLatestDepositDateTo))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}