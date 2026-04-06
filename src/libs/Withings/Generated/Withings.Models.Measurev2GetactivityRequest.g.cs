
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Measurev2GetactivityRequest
    {
        /// <summary>
        /// Action to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Measurev2GetactivityRequestActionJsonConverter))]
        public global::Withings.Measurev2GetactivityRequestAction Action { get; set; }

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
        /// Unix timestamp for delta updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastupdate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Lastupdate { get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Comma-separated fields: steps,distance,elevation,soft,moderate,intense,active,calories,totalcalories,hr_average,hr_min,hr_max,hr_zone_0,hr_zone_1,hr_zone_2,hr_zone_3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public string? DataFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Measurev2GetactivityRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Measurev2GetactivityRequest(
            global::Withings.Measurev2GetactivityRequestAction action,
            string? startdateymd,
            string? enddateymd,
            global::System.DateTimeOffset? lastupdate,
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
        /// Initializes a new instance of the <see cref="Measurev2GetactivityRequest" /> class.
        /// </summary>
        public Measurev2GetactivityRequest()
        {
        }
    }
}