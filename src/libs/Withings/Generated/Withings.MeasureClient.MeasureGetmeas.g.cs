
#nullable enable

namespace Withings
{
    public partial class MeasureClient
    {


        private static readonly global::Withings.EndPointSecurityRequirement s_MeasureGetmeasSecurityRequirement0 =
            new global::Withings.EndPointSecurityRequirement
            {
                Authorizations = new global::Withings.EndPointAuthorizationRequirement[]
                {                    new global::Withings.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Withings.EndPointSecurityRequirement[] s_MeasureGetmeasSecurityRequirements =
            new global::Withings.EndPointSecurityRequirement[]
            {                s_MeasureGetmeasSecurityRequirement0,
            };
        partial void PrepareMeasureGetmeasArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Withings.MeasureGetmeasRequest request);
        partial void PrepareMeasureGetmeasRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Withings.MeasureGetmeasRequest request);
        partial void ProcessMeasureGetmeasResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMeasureGetmeasResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get body measurements<br/>
        /// Retrieves body measurements including weight, body composition, blood pressure,<br/>
        /// heart rate, temperature, SpO2, and more.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Withings.MeasureGetMeasResponse> MeasureGetmeasAsync(

            global::Withings.MeasureGetmeasRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await MeasureGetmeasAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get body measurements<br/>
        /// Retrieves body measurements including weight, body composition, blood pressure,<br/>
        /// heart rate, temperature, SpO2, and more.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Withings.AutoSDKHttpResponse<global::Withings.MeasureGetMeasResponse>> MeasureGetmeasAsResponseAsync(

            global::Withings.MeasureGetmeasRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMeasureGetmeasArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Withings.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MeasureGetmeasSecurityRequirements,
                operationName: "MeasureGetmeasAsync");

            using var __timeoutCancellationTokenSource = global::Withings.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Withings.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Withings.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Withings.PathBuilder(
                                path: "/measure",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Withings.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __formValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
                            if (request.Action != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "action",
                                    request.Action.ToValueString()));
                            }
                            if (request.Meastype != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "meastype",
                                    global::System.Convert.ToString(request.Meastype, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty));
                            }
                            if (request.Meastypes != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "meastypes",
                                    request.Meastypes ?? string.Empty));
                            }
                            if (request.Category != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "category",
                                    global::System.Convert.ToString(request.Category, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty));
                            }
                            if (request.Startdate != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "startdate",
                                    request.Startdate.ToString() ?? string.Empty));
                            }
                            if (request.Enddate != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "enddate",
                                    request.Enddate.ToString() ?? string.Empty));
                            }
                            if (request.Lastupdate != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "lastupdate",
                                    request.Lastupdate.ToString() ?? string.Empty));
                            }
                            if (request.Offset != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "offset",
                                    global::System.Convert.ToString(request.Offset, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty));
                            }
                            var __httpRequestContent = new global::System.Net.Http.FormUrlEncodedContent(__formValues);
                            __httpRequest.Content = __httpRequestContent;

                global::Withings.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareMeasureGetmeasRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Withings.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Withings.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MeasureGetmeas",
                                methodName: "MeasureGetmeasAsync",
                                pathTemplate: "\"/measure\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Withings.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Withings.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Withings.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MeasureGetmeas",
                                methodName: "MeasureGetmeasAsync",
                                pathTemplate: "\"/measure\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Withings.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Withings.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Withings.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Withings.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Withings.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MeasureGetmeas",
                                methodName: "MeasureGetmeasAsync",
                                pathTemplate: "\"/measure\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Withings.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessMeasureGetmeasResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Withings.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Withings.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MeasureGetmeas",
                                methodName: "MeasureGetmeasAsync",
                                pathTemplate: "\"/measure\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Withings.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Withings.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "MeasureGetmeas",
                                methodName: "MeasureGetmeasAsync",
                                pathTemplate: "\"/measure\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessMeasureGetmeasResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Withings.MeasureGetMeasResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Withings.AutoSDKHttpResponse<global::Withings.MeasureGetMeasResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Withings.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Withings.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Withings.MeasureGetMeasResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Withings.AutoSDKHttpResponse<global::Withings.MeasureGetMeasResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Withings.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Withings.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Get body measurements<br/>
        /// Retrieves body measurements including weight, body composition, blood pressure,<br/>
        /// heart rate, temperature, SpO2, and more.
        /// </summary>
        /// <param name="action">
        /// Must be "getmeas"
        /// </param>
        /// <param name="meastype">
        /// Filter by measurement type (1=Weight, 4=Height, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 54=SpO2, etc.)
        /// </param>
        /// <param name="meastypes">
        /// Comma-separated list of measurement type IDs
        /// </param>
        /// <param name="category">
        /// 1=real measures, 2=user objectives
        /// </param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="lastupdate">
        /// Unix timestamp to get data updated after this time
        /// </param>
        /// <param name="offset">
        /// Pagination offset (from previous response)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Withings.MeasureGetMeasResponse> MeasureGetmeasAsync(
            global::Withings.MeasureGetmeasRequestAction action = default,
            int? meastype = default,
            string? meastypes = default,
            int? category = default,
            global::System.DateTimeOffset? startdate = default,
            global::System.DateTimeOffset? enddate = default,
            global::System.DateTimeOffset? lastupdate = default,
            int? offset = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Withings.MeasureGetmeasRequest
            {
                Action = action,
                Meastype = meastype,
                Meastypes = meastypes,
                Category = category,
                Startdate = startdate,
                Enddate = enddate,
                Lastupdate = lastupdate,
                Offset = offset,
            };

            return await MeasureGetmeasAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}