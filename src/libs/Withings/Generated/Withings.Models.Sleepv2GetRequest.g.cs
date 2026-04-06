
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sleepv2GetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Sleepv2GetRequestActionJsonConverter))]
        public global::Withings.Sleepv2GetRequestAction Action { get; set; }

        /// <summary>
        /// Start date as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startdate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Startdate { get; set; }

        /// <summary>
        /// End date as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enddate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Enddate { get; set; }

        /// <summary>
        /// Comma-separated fields: hr,rr,snoring,sdnn_1,rmssd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_fields")]
        public string? DataFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleepv2GetRequest" /> class.
        /// </summary>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="action"></param>
        /// <param name="dataFields">
        /// Comma-separated fields: hr,rr,snoring,sdnn_1,rmssd
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleepv2GetRequest(
            global::System.DateTimeOffset startdate,
            global::System.DateTimeOffset enddate,
            global::Withings.Sleepv2GetRequestAction action,
            string? dataFields)
        {
            this.Action = action;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.DataFields = dataFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleepv2GetRequest" /> class.
        /// </summary>
        public Sleepv2GetRequest()
        {
        }
    }
}