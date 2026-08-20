// <copyright file="DirectDebitApi.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnivaPay.Exceptions;
using UnivaPay.Http.Response;

namespace UnivaPay.Apis
{
    /// <summary>
    /// DirectDebitApi.
    /// </summary>
    public class DirectDebitApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitApi"/> class.
        /// </summary>
        internal DirectDebitApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the merchant's direct debit configuration — whether direct debit is enabled and which monthly debit cycle applies.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitMerchantConfiguration response from the API call.</returns>
        public ApiResponse<Models.DirectDebitMerchantConfiguration> GetDirectDebitConfiguration(
                Guid merchantId)
            => CoreHelper.RunTask(GetDirectDebitConfigurationAsync(merchantId));

        /// <summary>
        /// Retrieves the merchant's direct debit configuration — whether direct debit is enabled and which monthly debit cycle applies.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitMerchantConfiguration response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitMerchantConfiguration>> GetDirectDebitConfigurationAsync(
                Guid merchantId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitMerchantConfiguration>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/configuration")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves which direct debit email notifications the merchant has opted into.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitNotificationConfiguration response from the API call.</returns>
        public ApiResponse<Models.DirectDebitNotificationConfiguration> GetDirectDebitNotificationConfiguration(
                Guid merchantId)
            => CoreHelper.RunTask(GetDirectDebitNotificationConfigurationAsync(merchantId));

        /// <summary>
        /// Retrieves which direct debit email notifications the merchant has opted into.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitNotificationConfiguration response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitNotificationConfiguration>> GetDirectDebitNotificationConfigurationAsync(
                Guid merchantId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitNotificationConfiguration>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/notification-configuration")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the key dates for the debit cycle currently in progress, based on the merchant's configured cycle. Compare `merchant_bank_transfer_upload_deadline` against today to decide whether transfers can still be registered or edited this month.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitSchedule response from the API call.</returns>
        public ApiResponse<Models.DirectDebitSchedule> GetDirectDebitCurrentSchedule(
                Guid merchantId)
            => CoreHelper.RunTask(GetDirectDebitCurrentScheduleAsync(merchantId));

        /// <summary>
        /// Retrieves the key dates for the debit cycle currently in progress, based on the merchant's configured cycle. Compare `merchant_bank_transfer_upload_deadline` against today to decide whether transfers can still be registered or edited this month.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitSchedule response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitSchedule>> GetDirectDebitCurrentScheduleAsync(
                Guid merchantId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitSchedule>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/schedules/current")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the consumer bank accounts registered for direct debit under this merchant.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="userNumber">Optional parameter: Filter by the merchant's own membership number for the consumer (会員番号)..</param>
        /// <param name="bankAccountId">Optional parameter: Filter by a single bank account ID..</param>
        /// <param name="bankCode">Optional parameter: Filter by the 4-digit bank code (銀行コード)..</param>
        /// <param name="bankName">Optional parameter: Filter by bank name in half-width katakana (銀行名)..</param>
        /// <param name="branchCode">Optional parameter: Filter by the 3-digit branch code (支店コード)..</param>
        /// <param name="bankAccountType">Optional parameter: Filter by deposit account type (預金種類)..</param>
        /// <param name="bankAccountNumber">Optional parameter: Filter by the 7-digit account number (口座番号)..</param>
        /// <param name="bankAccountName">Optional parameter: Filter by account holder name in half-width katakana (口座名義)..</param>
        /// <param name="registrationOrigin">Optional parameter: Filter by where the bank account was registered from..</param>
        /// <param name="bankAccountStatus">Optional parameter: Filter by bank account status. Omit to return every status..</param>
        /// <param name="from">Optional parameter: Show bank accounts created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show bank accounts created before this date (ISO-8601)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccountList response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccountList> ListDirectDebitBankAccounts(
                Guid merchantId,
                int? limit = 10,
                string cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string userNumber = null,
                string bankAccountId = null,
                string bankCode = null,
                string bankName = null,
                string branchCode = null,
                Models.DirectDebitBankAccountType? bankAccountType = null,
                string bankAccountNumber = null,
                string bankAccountName = null,
                Models.DirectDebitRegistrationOrigin? registrationOrigin = null,
                Models.DirectDebitBankAccountStatus? bankAccountStatus = null,
                string from = null,
                string to = null)
            => CoreHelper.RunTask(ListDirectDebitBankAccountsAsync(merchantId, limit, cursor, cursorDirection, userNumber, bankAccountId, bankCode, bankName, branchCode, bankAccountType, bankAccountNumber, bankAccountName, registrationOrigin, bankAccountStatus, from, to));

        /// <summary>
        /// Lists the consumer bank accounts registered for direct debit under this merchant.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="userNumber">Optional parameter: Filter by the merchant's own membership number for the consumer (会員番号)..</param>
        /// <param name="bankAccountId">Optional parameter: Filter by a single bank account ID..</param>
        /// <param name="bankCode">Optional parameter: Filter by the 4-digit bank code (銀行コード)..</param>
        /// <param name="bankName">Optional parameter: Filter by bank name in half-width katakana (銀行名)..</param>
        /// <param name="branchCode">Optional parameter: Filter by the 3-digit branch code (支店コード)..</param>
        /// <param name="bankAccountType">Optional parameter: Filter by deposit account type (預金種類)..</param>
        /// <param name="bankAccountNumber">Optional parameter: Filter by the 7-digit account number (口座番号)..</param>
        /// <param name="bankAccountName">Optional parameter: Filter by account holder name in half-width katakana (口座名義)..</param>
        /// <param name="registrationOrigin">Optional parameter: Filter by where the bank account was registered from..</param>
        /// <param name="bankAccountStatus">Optional parameter: Filter by bank account status. Omit to return every status..</param>
        /// <param name="from">Optional parameter: Show bank accounts created on or after this date (ISO-8601)..</param>
        /// <param name="to">Optional parameter: Show bank accounts created before this date (ISO-8601)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccountList response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccountList>> ListDirectDebitBankAccountsAsync(
                Guid merchantId,
                int? limit = 10,
                string cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string userNumber = null,
                string bankAccountId = null,
                string bankCode = null,
                string bankName = null,
                string branchCode = null,
                Models.DirectDebitBankAccountType? bankAccountType = null,
                string bankAccountNumber = null,
                string bankAccountName = null,
                Models.DirectDebitRegistrationOrigin? registrationOrigin = null,
                Models.DirectDebitBankAccountStatus? bankAccountStatus = null,
                string from = null,
                string to = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccountList>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/bank-accounts")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("user_number", userNumber))
                      .Query(query => query.Setup("bank_account_id", bankAccountId))
                      .Query(query => query.Setup("bank_code", bankCode))
                      .Query(query => query.Setup("bank_name", bankName))
                      .Query(query => query.Setup("branch_code", branchCode))
                      .Query(query => query.Setup("bank_account_type", (bankAccountType.HasValue) ? CoreHelper.JsonSerialize(bankAccountType.Value).Trim('\"') : null))
                      .Query(query => query.Setup("bank_account_number", bankAccountNumber))
                      .Query(query => query.Setup("bank_account_name", bankAccountName))
                      .Query(query => query.Setup("registration_origin", (registrationOrigin.HasValue) ? CoreHelper.JsonSerialize(registrationOrigin.Value).Trim('\"') : null))
                      .Query(query => query.Setup("bank_account_status", (bankAccountStatus.HasValue) ? CoreHelper.JsonSerialize(bankAccountStatus.Value).Trim('\"') : null))
                      .Query(query => query.Setup("from", from))
                      .Query(query => query.Setup("to", to))))
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
        /// Registers a consumer bank account for direct debit. The account is created and then verified against the bank, so it starts out unusable — poll its `status` until it becomes `active` (or `registration_failed`) before scheduling transfers against it.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="body">Required parameter: Request payload for registering a consumer bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccount> CreateDirectDebitBankAccount(
                Guid merchantId,
                Models.DirectDebitBankAccountCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateDirectDebitBankAccountAsync(merchantId, body, idempotencyKey));

        /// <summary>
        /// Registers a consumer bank account for direct debit. The account is created and then verified against the bank, so it starts out unusable — poll its `status` until it becomes `active` (or `registration_failed`) before scheduling transfers against it.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="body">Required parameter: Request payload for registering a consumer bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccount>> CreateDirectDebitBankAccountAsync(
                Guid merchantId,
                Models.DirectDebitBankAccountCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccount>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/merchants/{merchantId}/bank-accounts")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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
        /// Retrieves a single registered bank account, including its current verification status.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccount> GetDirectDebitBankAccount(
                Guid merchantId,
                string bankAccountId)
            => CoreHelper.RunTask(GetDirectDebitBankAccountAsync(merchantId, bankAccountId));

        /// <summary>
        /// Retrieves a single registered bank account, including its current verification status.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccount>> GetDirectDebitBankAccountAsync(
                Guid merchantId,
                string bankAccountId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccount>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/bank-accounts/{bankAccountId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankAccountId", bankAccountId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates a registered bank account. Changing bank details re-triggers verification with the bank. Transfers already registered keep the details they were created with.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="body">Required parameter: Request payload for updating a registered bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccount> UpdateDirectDebitBankAccount(
                Guid merchantId,
                string bankAccountId,
                Models.DirectDebitBankAccountUpdateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateDirectDebitBankAccountAsync(merchantId, bankAccountId, body, idempotencyKey));

        /// <summary>
        /// Updates a registered bank account. Changing bank details re-triggers verification with the bank. Transfers already registered keep the details they were created with.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="body">Required parameter: Request payload for updating a registered bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccount>> UpdateDirectDebitBankAccountAsync(
                Guid merchantId,
                string bankAccountId,
                Models.DirectDebitBankAccountUpdateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccount>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/merchants/{merchantId}/bank-accounts/{bankAccountId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankAccountId", bankAccountId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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

        /// <summary>
        /// Deactivates a bank account so no further transfers can be registered against it. The record is retained (status becomes `inactive`) rather than deleted, and can be re-enabled later.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccount> DeactivateDirectDebitBankAccount(
                Guid merchantId,
                string bankAccountId)
            => CoreHelper.RunTask(DeactivateDirectDebitBankAccountAsync(merchantId, bankAccountId));

        /// <summary>
        /// Deactivates a bank account so no further transfers can be registered against it. The record is retained (status becomes `inactive`) rather than deleted, and can be re-enabled later.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccount>> DeactivateDirectDebitBankAccountAsync(
                Guid merchantId,
                string bankAccountId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccount>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/merchants/{merchantId}/bank-accounts/{bankAccountId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankAccountId", bankAccountId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a deactivated bank account to `active` so transfers can be registered against it again. The account must currently be `inactive`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankAccount> ReenableDirectDebitBankAccount(
                Guid merchantId,
                string bankAccountId,
                string idempotencyKey = null)
            => CoreHelper.RunTask(ReenableDirectDebitBankAccountAsync(merchantId, bankAccountId, idempotencyKey));

        /// <summary>
        /// Returns a deactivated bank account to `active` so transfers can be registered against it again. The account must currently be `inactive`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankAccount response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankAccount>> ReenableDirectDebitBankAccountAsync(
                Guid merchantId,
                string bankAccountId,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankAccount>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/merchants/{merchantId}/bank-accounts/{bankAccountId}/re-enable")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankAccountId", bankAccountId).Required())
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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

        /// <summary>
        /// Schedules a pull of funds from an active bank account. The transfer is queued for the merchant's next debit cycle and stays editable until that cycle's upload deadline passes.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="body">Required parameter: Request payload for scheduling a transfer, in JPY..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankTransfer> CreateDirectDebitBankTransfer(
                Guid merchantId,
                string bankAccountId,
                Models.DirectDebitBankTransferCreateRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateDirectDebitBankTransferAsync(merchantId, bankAccountId, body, idempotencyKey));

        /// <summary>
        /// Schedules a pull of funds from an active bank account. The transfer is queued for the merchant's next debit cycle and stays editable until that cycle's upload deadline passes.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankAccountId">Required parameter: The unique identifier of the direct debit bank account..</param>
        /// <param name="body">Required parameter: Request payload for scheduling a transfer, in JPY..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankTransfer>> CreateDirectDebitBankTransferAsync(
                Guid merchantId,
                string bankAccountId,
                Models.DirectDebitBankTransferCreateRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankTransfer>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/merchants/{merchantId}/bank-accounts/{bankAccountId}/bank-transfers")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankAccountId", bankAccountId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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

        /// <summary>
        /// Lists the direct debit transfers registered under this merchant, across all bank accounts.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="bankTransferId">Optional parameter: Filter by a single bank transfer ID..</param>
        /// <param name="bankTransferStart">Optional parameter: Start of the year-month range in which the transfer is scheduled to occur..</param>
        /// <param name="bankTransferEnd">Optional parameter: End of the year-month range in which the transfer is scheduled to occur..</param>
        /// <param name="debitDate">Optional parameter: Filter by monthly debit cycle..</param>
        /// <param name="userNumber">Optional parameter: Filter by the merchant's own membership number for the consumer (会員番号)..</param>
        /// <param name="bankAccountNumber">Optional parameter: Filter by the 7-digit account number (口座番号)..</param>
        /// <param name="bankAccountName">Optional parameter: Filter by account holder name in half-width katakana (口座名義)..</param>
        /// <param name="lockStatus">Optional parameter: Filter by lock status. Omit to return both locked and unlocked transfers..</param>
        /// <param name="bankTransferStatus">Optional parameter: Filter by transfer status. Omit to return every status..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransferList response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankTransferList> ListDirectDebitBankTransfers(
                Guid merchantId,
                int? limit = 10,
                string cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string bankTransferId = null,
                string bankTransferStart = null,
                string bankTransferEnd = null,
                Models.DirectDebitDebitDate? debitDate = null,
                string userNumber = null,
                string bankAccountNumber = null,
                string bankAccountName = null,
                Models.DirectDebitBankTransferLock? lockStatus = null,
                Models.DirectDebitBankTransferStatus? bankTransferStatus = null)
            => CoreHelper.RunTask(ListDirectDebitBankTransfersAsync(merchantId, limit, cursor, cursorDirection, bankTransferId, bankTransferStart, bankTransferEnd, debitDate, userNumber, bankAccountNumber, bankAccountName, lockStatus, bankTransferStatus));

        /// <summary>
        /// Lists the direct debit transfers registered under this merchant, across all bank accounts.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="limit">Optional parameter: Maximum number of resources to return in one page..</param>
        /// <param name="cursor">Optional parameter: Cursor pointing to the resource after which pagination should continue..</param>
        /// <param name="cursorDirection">Optional parameter: Pagination direction relative to the supplied cursor..</param>
        /// <param name="bankTransferId">Optional parameter: Filter by a single bank transfer ID..</param>
        /// <param name="bankTransferStart">Optional parameter: Start of the year-month range in which the transfer is scheduled to occur..</param>
        /// <param name="bankTransferEnd">Optional parameter: End of the year-month range in which the transfer is scheduled to occur..</param>
        /// <param name="debitDate">Optional parameter: Filter by monthly debit cycle..</param>
        /// <param name="userNumber">Optional parameter: Filter by the merchant's own membership number for the consumer (会員番号)..</param>
        /// <param name="bankAccountNumber">Optional parameter: Filter by the 7-digit account number (口座番号)..</param>
        /// <param name="bankAccountName">Optional parameter: Filter by account holder name in half-width katakana (口座名義)..</param>
        /// <param name="lockStatus">Optional parameter: Filter by lock status. Omit to return both locked and unlocked transfers..</param>
        /// <param name="bankTransferStatus">Optional parameter: Filter by transfer status. Omit to return every status..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransferList response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankTransferList>> ListDirectDebitBankTransfersAsync(
                Guid merchantId,
                int? limit = 10,
                string cursor = null,
                Models.CursorDirectionQuery? cursorDirection = Models.CursorDirectionQuery.Desc,
                string bankTransferId = null,
                string bankTransferStart = null,
                string bankTransferEnd = null,
                Models.DirectDebitDebitDate? debitDate = null,
                string userNumber = null,
                string bankAccountNumber = null,
                string bankAccountName = null,
                Models.DirectDebitBankTransferLock? lockStatus = null,
                Models.DirectDebitBankTransferStatus? bankTransferStatus = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankTransferList>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/bank-transfers")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Query(query => query.Setup("limit", limit ?? 10))
                      .Query(query => query.Setup("cursor", cursor))
                      .Query(query => query.Setup("cursor_direction", (cursorDirection.HasValue) ? CoreHelper.JsonSerialize(cursorDirection.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("bank_transfer_id", bankTransferId))
                      .Query(query => query.Setup("bank_transfer_start", bankTransferStart))
                      .Query(query => query.Setup("bank_transfer_end", bankTransferEnd))
                      .Query(query => query.Setup("debit_date", (debitDate.HasValue) ? CoreHelper.JsonSerialize(debitDate.Value).Trim('\"') : null))
                      .Query(query => query.Setup("user_number", userNumber))
                      .Query(query => query.Setup("bank_account_number", bankAccountNumber))
                      .Query(query => query.Setup("bank_account_name", bankAccountName))
                      .Query(query => query.Setup("lock_status", (lockStatus.HasValue) ? CoreHelper.JsonSerialize(lockStatus.Value).Trim('\"') : null))
                      .Query(query => query.Setup("bank_transfer_status", (bankTransferStatus.HasValue) ? CoreHelper.JsonSerialize(bankTransferStatus.Value).Trim('\"') : null))))
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
        /// Retrieves a single transfer. Poll this after the cycle's result registration date to pick up the outcome and, on failure, the bank's reason.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankTransfer> GetDirectDebitBankTransfer(
                Guid merchantId,
                string bankTransferId)
            => CoreHelper.RunTask(GetDirectDebitBankTransferAsync(merchantId, bankTransferId));

        /// <summary>
        /// Retrieves a single transfer. Poll this after the cycle's result registration date to pick up the outcome and, on failure, the bank's reason.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankTransfer>> GetDirectDebitBankTransferAsync(
                Guid merchantId,
                string bankTransferId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankTransfer>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/merchants/{merchantId}/bank-transfers/{bankTransferId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankTransferId", bankTransferId).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("403", CreateErrorCase("HTTP 403 Forbidden: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("404", CreateErrorCase("HTTP 404 Not Found: {$response.body#/code}", (errorReason, context) => new ApiErrorException(errorReason, context), true))
                  .ErrorCase("429", CreateErrorCase("HTTP 429 Rate Limited: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("409", CreateErrorCase("HTTP 409 Conflict: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("500", CreateErrorCase("HTTP 500 Server Error: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("503", CreateErrorCase("HTTP 503 Unavailable: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("504", CreateErrorCase("HTTP 504 Timeout: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("0", CreateErrorCase("HTTP {$statusCode}: {$response.body#/code}", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Changes a scheduled transfer's amount. Only permitted while the transfer is `unlocked` — once its cycle's upload deadline passes the amount is fixed.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        /// <param name="body">Required parameter: Request payload for changing the transfer amount..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public ApiResponse<Models.DirectDebitBankTransfer> UpdateDirectDebitBankTransfer(
                Guid merchantId,
                string bankTransferId,
                Models.DirectDebitBankTransferPatchRequest body,
                string idempotencyKey = null)
            => CoreHelper.RunTask(UpdateDirectDebitBankTransferAsync(merchantId, bankTransferId, body, idempotencyKey));

        /// <summary>
        /// Changes a scheduled transfer's amount. Only permitted while the transfer is `unlocked` — once its cycle's upload deadline passes the amount is fixed.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        /// <param name="body">Required parameter: Request payload for changing the transfer amount..</param>
        /// <param name="idempotencyKey">Optional parameter: An optional idempotency key to prevent double charges and duplicate operations. We recommend a randomly generated UUID (v4)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DirectDebitBankTransfer response from the API call.</returns>
        public async Task<ApiResponse<Models.DirectDebitBankTransfer>> UpdateDirectDebitBankTransferAsync(
                Guid merchantId,
                string bankTransferId,
                Models.DirectDebitBankTransferPatchRequest body,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DirectDebitBankTransfer>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/merchants/{merchantId}/bank-transfers/{bankTransferId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body).Required())
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankTransferId", bankTransferId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Header(header => header.Setup("Idempotency-Key", idempotencyKey))))
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

        /// <summary>
        /// Cancels a scheduled transfer so it is not sent to the bank. Only permitted while the transfer is `unlocked`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        public void DeleteDirectDebitBankTransfer(
                Guid merchantId,
                string bankTransferId)
            => CoreHelper.RunVoidTask(DeleteDirectDebitBankTransferAsync(merchantId, bankTransferId));

        /// <summary>
        /// Cancels a scheduled transfer so it is not sent to the bank. Only permitted while the transfer is `unlocked`.
        /// </summary>
        /// <param name="merchantId">Required parameter: The unique identifier of the merchant..</param>
        /// <param name="bankTransferId">Required parameter: The unique identifier of the direct debit bank transfer..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteDirectDebitBankTransferAsync(
                Guid merchantId,
                string bankTransferId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.DirectDebit)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/merchants/{merchantId}/bank-transfers/{bankTransferId}")
                  .WithAuth("JWT_TOKEN")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("merchantId", merchantId))
                      .Template(template => template.Setup("bankTransferId", bankTransferId).Required())))
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