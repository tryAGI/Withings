#nullable enable

namespace Withings
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get workout data<br/>
        /// Retrieves workout sessions with calories, duration, heart rate, distance, and sport type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.GetWorkoutsResponse> Measurev2GetworkoutsAsync(

            global::Withings.Measurev2GetworkoutsRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workout data<br/>
        /// Retrieves workout sessions with calories, duration, heart rate, distance, and sport type.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startdateymd">
        /// Start date in YYYY-MM-DD format
        /// </param>
        /// <param name="enddateymd">
        /// End date in YYYY-MM-DD format
        /// </param>
        /// <param name="lastupdate"></param>
        /// <param name="offset"></param>
        /// <param name="dataFields">
        /// Comma-separated fields: calories,effduration,intensity,manual_distance,manual_calories,hr_average,hr_min,hr_max,hr_zone_0,hr_zone_1,hr_zone_2,hr_zone_3,pause_duration,spo2_average,steps,distance,elevation,pool_laps,strokes,pool_length
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.GetWorkoutsResponse> Measurev2GetworkoutsAsync(
            global::Withings.Measurev2GetworkoutsRequestAction action = default,
            string? startdateymd = default,
            string? enddateymd = default,
            int? lastupdate = default,
            int? offset = default,
            string? dataFields = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}