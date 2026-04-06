
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sleepv2GetsummaryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Sleepv2GetsummaryRequestActionJsonConverter))]
        public global::Withings.Sleepv2GetsummaryRequestAction Action { get; set; }

        /// <summary>
        /// Start date in YYYY-MM-DD format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startdateymd")]
        public string? Startdateymd { get; set; }

        /// <summary>
        /// End date in YYYY-MM-DD format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enddateymd")]
        public string? Enddateymd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastupdate")]
        public int? Lastupdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Comma-separated fields: breathing_disturbances_intensity,deepsleepduration,lightsleepduration,remsleepduration,wakeupduration,durationtosleep,durationtowakeup,hr_average,hr_max,hr_min,rr_average,rr_max,rr_min,sleep_score,snoring,snoringepisodecount,wakeupcount,out_of_bed_count,total_sleep_time,total_timeinbed,sleep_efficiency,sleep_latency,wakeup_latency,nb_rem_episodes,apnea_hypopnea_index,night_events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public string? DataFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleepv2GetsummaryRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleepv2GetsummaryRequest(
            global::Withings.Sleepv2GetsummaryRequestAction action,
            string? startdateymd,
            string? enddateymd,
            int? lastupdate,
            int? offset,
            string? dataFields)
        {
            this.Action = action;
            this.Startdateymd = startdateymd;
            this.Enddateymd = enddateymd;
            this.Lastupdate = lastupdate;
            this.Offset = offset;
            this.DataFields = dataFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleepv2GetsummaryRequest" /> class.
        /// </summary>
        public Sleepv2GetsummaryRequest()
        {
        }
    }
}