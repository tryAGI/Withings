
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyGetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.NotifyGetRequestActionJsonConverter))]
        public global::Withings.NotifyGetRequestAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackurl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Callbackurl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Appli { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyGetRequest" /> class.
        /// </summary>
        /// <param name="callbackurl"></param>
        /// <param name="appli"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyGetRequest(
            string callbackurl,
            int appli,
            global::Withings.NotifyGetRequestAction action)
        {
            this.Action = action;
            this.Callbackurl = callbackurl ?? throw new global::System.ArgumentNullException(nameof(callbackurl));
            this.Appli = appli;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyGetRequest" /> class.
        /// </summary>
        public NotifyGetRequest()
        {
        }
    }
}