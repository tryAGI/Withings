
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Heartv2GetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.Heartv2GetRequestActionJsonConverter))]
        public global::Withings.Heartv2GetRequestAction Action { get; set; }

        /// <summary>
        /// Signal ID from heart list response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signalid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Signalid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Heartv2GetRequest" /> class.
        /// </summary>
        /// <param name="signalid">
        /// Signal ID from heart list response
        /// </param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Heartv2GetRequest(
            int signalid,
            global::Withings.Heartv2GetRequestAction action)
        {
            this.Action = action;
            this.Signalid = signalid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heartv2GetRequest" /> class.
        /// </summary>
        public Heartv2GetRequest()
        {
        }
    }
}