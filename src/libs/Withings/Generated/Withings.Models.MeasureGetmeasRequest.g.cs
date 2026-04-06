
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasureGetmeasRequest
    {
        /// <summary>
        /// Must be "getmeas"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.MeasureGetmeasRequestActionJsonConverter))]
        public global::Withings.MeasureGetmeasRequestAction Action { get; set; }

        /// <summary>
        /// Filter by measurement type (1=Weight, 4=Height, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 54=SpO2, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meastype")]
        public int? Meastype { get; set; }

        /// <summary>
        /// Comma-separated list of measurement type IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meastypes")]
        public string? Meastypes { get; set; }

        /// <summary>
        /// 1=real measures, 2=user objectives
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public int? Category { get; set; }

        /// <summary>
        /// Start date as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startdate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// End date as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enddate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// Unix timestamp to get data updated after this time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastupdate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Lastupdate { get; set; }

        /// <summary>
        /// Pagination offset (from previous response)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetmeasRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Must be "getmeas"
        /// </param>
        /// <param name="meastype">
        /// Filter by measurement type (1=Weight, 4=Height, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 54=SpO2, etc.)
        /// </param>
        /// <param name="meastypes">
        /// Comma-separated list of measurement type IDs
        /// </param>
        /// <param name="category">
        /// 1=real measures, 2=user objectives
        /// </param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="lastupdate">
        /// Unix timestamp to get data updated after this time
        /// </param>
        /// <param name="offset">
        /// Pagination offset (from previous response)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasureGetmeasRequest(
            global::Withings.MeasureGetmeasRequestAction action,
            int? meastype,
            string? meastypes,
            int? category,
            global::System.DateTimeOffset? startdate,
            global::System.DateTimeOffset? enddate,
            global::System.DateTimeOffset? lastupdate,
            int? offset)
        {
            this.Action = action;
            this.Meastype = meastype;
            this.Meastypes = meastypes;
            this.Category = category;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Lastupdate = lastupdate;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetmeasRequest" /> class.
        /// </summary>
        public MeasureGetmeasRequest()
        {
        }
    }
}