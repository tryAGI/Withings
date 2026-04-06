
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Heartv2ListRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Heartv2ListRequestActionJsonConverter))]
        public global::Withings.Heartv2ListRequestAction Action { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Heartv2ListRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="offset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Heartv2ListRequest(
            global::Withings.Heartv2ListRequestAction action,
            global::System.DateTimeOffset? startdate,
            global::System.DateTimeOffset? enddate,
            int? offset)
        {
            this.Action = action;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heartv2ListRequest" /> class.
        /// </summary>
        public Heartv2ListRequest()
        {
        }
    }
}