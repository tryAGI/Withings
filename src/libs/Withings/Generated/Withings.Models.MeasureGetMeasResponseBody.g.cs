
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasureGetMeasResponseBody
    {
        /// <summary>
        /// Unix timestamp of last update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatetime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Updatetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 1 if more data available, 0 otherwise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("more")]
        public int? More { get; set; }

        /// <summary>
        /// Offset for next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measuregrps")]
        public global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrp>? Measuregrps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBody" /> class.
        /// </summary>
        /// <param name="updatetime">
        /// Unix timestamp of last update
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="more">
        /// 1 if more data available, 0 otherwise
        /// </param>
        /// <param name="offset">
        /// Offset for next page
        /// </param>
        /// <param name="measuregrps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasureGetMeasResponseBody(
            global::System.DateTimeOffset? updatetime,
            string? timezone,
            int? more,
            int? offset,
            global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrp>? measuregrps)
        {
            this.Updatetime = updatetime;
            this.Timezone = timezone;
            this.More = more;
            this.Offset = offset;
            this.Measuregrps = measuregrps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBody" /> class.
        /// </summary>
        public MeasureGetMeasResponseBody()
        {
        }
    }
}