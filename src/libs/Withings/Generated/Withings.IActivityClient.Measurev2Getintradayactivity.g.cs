#nullable enable

namespace Withings
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get intraday activity data<br/>
        /// Retrieves high-frequency intraday activity data including steps, heart rate,<br/>
        /// calories, distance at sub-daily granularity.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.GetIntradayActivityResponse> Measurev2GetintradayactivityAsync(

            global::Withings.Measurev2GetintradayactivityRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get intraday activity data<br/>
        /// Retrieves high-frequency intraday activity data including steps, heart rate,<br/>
        /// calories, distance at sub-daily granularity.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="dataFields">
        /// Comma-separated fields: steps,elevation,calories,distance,stroke,pool_lap,duration,heart_rate,spo2_auto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.GetIntradayActivityResponse> Measurev2GetintradayactivityAsync(
            global::System.DateTimeOffset startdate,
            global::System.DateTimeOffset enddate,
            global::Withings.Measurev2GetintradayactivityRequestAction action = default,
            string? dataFields = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}