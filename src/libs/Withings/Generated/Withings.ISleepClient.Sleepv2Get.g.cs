#nullable enable

namespace Withings
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get detailed sleep data<br/>
        /// Retrieves detailed sleep data including sleep states (awake, light, deep, REM),<br/>
        /// heart rate, respiration rate, snoring, and HRV time series.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SleepGetResponse> Sleepv2GetAsync(

            global::Withings.Sleepv2GetRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed sleep data<br/>
        /// Retrieves detailed sleep data including sleep states (awake, light, deep, REM),<br/>
        /// heart rate, respiration rate, snoring, and HRV time series.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="dataFields">
        /// Comma-separated fields: hr,rr,snoring,sdnn_1,rmssd
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SleepGetResponse> Sleepv2GetAsync(
            global::System.DateTimeOffset startdate,
            global::System.DateTimeOffset enddate,
            global::Withings.Sleepv2GetRequestAction action = default,
            string? dataFields = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}