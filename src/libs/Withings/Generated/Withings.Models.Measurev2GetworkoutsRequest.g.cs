
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Measurev2GetworkoutsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Measurev2GetworkoutsRequestActionJsonConverter))]
        public global::Withings.Measurev2GetworkoutsRequestAction Action { get; set; }

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
        /// Comma-separated fields: calories,effduration,intensity,manual_distance,manual_calories,hr_average,hr_min,hr_max,hr_zone_0,hr_zone_1,hr_zone_2,hr_zone_3,pause_duration,spo2_average,steps,distance,elevation,pool_laps,strokes,pool_length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public string? DataFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Measurev2GetworkoutsRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Measurev2GetworkoutsRequest(
            global::Withings.Measurev2GetworkoutsRequestAction action,
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
        /// Initializes a new instance of the <see cref="Measurev2GetworkoutsRequest" /> class.
        /// </summary>
        public Measurev2GetworkoutsRequest()
        {
        }
    }
}