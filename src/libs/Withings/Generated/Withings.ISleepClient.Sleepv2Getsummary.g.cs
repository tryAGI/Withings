#nullable enable

namespace Withings
{
    public partial interface ISleepClient
    {
        /// <summary>
        /// Get sleep summary data<br/>
        /// Retrieves sleep summary data including sleep score, stage durations,<br/>
        /// heart rate stats, respiration stats, snoring, and sleep efficiency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SleepGetSummaryResponse> Sleepv2GetsummaryAsync(

            global::Withings.Sleepv2GetsummaryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sleep summary data<br/>
        /// Retrieves sleep summary data including sleep score, stage durations,<br/>
        /// heart rate stats, respiration stats, snoring, and sleep efficiency.
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
        /// Comma-separated fields: breathing_disturbances_intensity,deepsleepduration,lightsleepduration,remsleepduration,wakeupduration,durationtosleep,durationtowakeup,hr_average,hr_max,hr_min,rr_average,rr_max,rr_min,sleep_score,snoring,snoringepisodecount,wakeupcount,out_of_bed_count,total_sleep_time,total_timeinbed,sleep_efficiency,sleep_latency,wakeup_latency,nb_rem_episodes,apnea_hypopnea_index,night_events
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SleepGetSummaryResponse> Sleepv2GetsummaryAsync(
            global::Withings.Sleepv2GetsummaryRequestAction action = default,
            string? startdateymd = default,
            string? enddateymd = default,
            int? lastupdate = default,
            int? offset = default,
            string? dataFields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}