
#nullable enable

namespace Withings
{
    public partial class ActivityClient
    {


        private static readonly global::Withings.EndPointSecurityRequirement s_Measurev2GetactivitySecurityRequirement0 =
            new global::Withings.EndPointSecurityRequirement
            {
                Authorizations = new global::Withings.EndPointAuthorizationRequirement[]
                {                    new global::Withings.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Withings.EndPointSecurityRequirement[] s_Measurev2GetactivitySecurityRequirements =
            new global::Withings.EndPointSecurityRequirement[]
            {                s_Measurev2GetactivitySecurityRequirement0,
            };
        partial void PrepareMeasurev2GetactivityArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Withings.Measurev2GetactivityRequest request);
        partial void PrepareMeasurev2GetactivityRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Withings.Measurev2GetactivityRequest request);
        partial void ProcessMeasurev2GetactivityResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMeasurev2GetactivityResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get daily activity data<br/>
        /// Retrieves daily activity summaries including steps, distance, calories,<br/>
        /// heart rate zones, and activity durations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Withings.GetActivityResponse> Measurev2GetactivityAsync(

            global::Withings.Measurev2GetactivityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMeasurev2GetactivityArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Withings.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Measurev2GetactivitySecurityRequirements,
                operationName: "Measurev2GetactivityAsync");

            var __pathBuilder = new global::Withings.PathBuilder(
                path: "/v2/measure",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/x-www-form-urlencoded");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMeasurev2GetactivityRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMeasurev2GetactivityResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessMeasurev2GetactivityResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Withings.GetActivityResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Withings.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Withings.GetActivityResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Withings.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Get daily activity data<br/>
        /// Retrieves daily activity summaries including steps, distance, calories,<br/>
        /// heart rate zones, and activity durations.
        /// </summary>
        /// <param name="action">
        /// Action to perform
        /// </param>
        /// <param name="startdateymd">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="enddateymd">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="lastupdate">
        /// Unix timestamp for delta updates
        /// </param>
        /// <param name="offset">
        /// Pagination offset
        /// </param>
        /// <param name="dataFields">
        /// Comma-separated fields: steps,distance,elevation,soft,moderate,intense,active,calories,totalcalories,hr_average,hr_min,hr_max,hr_zone_0,hr_zone_1,hr_zone_2,hr_zone_3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Withings.GetActivityResponse> Measurev2GetactivityAsync(
            global::Withings.Measurev2GetactivityRequestAction action = default,
            string? startdateymd = default,
            string? enddateymd = default,
            global::System.DateTimeOffset? lastupdate = default,
            int? offset = default,
            string? dataFields = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Withings.Measurev2GetactivityRequest
            {
                Action = action,
                Startdateymd = startdateymd,
                Enddateymd = enddateymd,
                Lastupdate = lastupdate,
                Offset = offset,
                DataFields = dataFields,
            };

            return await Measurev2GetactivityAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}