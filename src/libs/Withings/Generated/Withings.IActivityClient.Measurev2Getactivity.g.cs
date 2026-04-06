#nullable enable

namespace Withings
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get daily activity data<br/>
        /// Retrieves daily activity summaries including steps, distance, calories,<br/>
        /// heart rate zones, and activity durations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.GetActivityResponse> Measurev2GetactivityAsync(

            global::Withings.Measurev2GetactivityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Withings.GetActivityResponse> Measurev2GetactivityAsync(
            global::Withings.Measurev2GetactivityRequestAction action = default,
            string? startdateymd = default,
            string? enddateymd = default,
            global::System.DateTimeOffset? lastupdate = default,
            int? offset = default,
            string? dataFields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}