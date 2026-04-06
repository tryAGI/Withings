
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.NotifyUpdateRequestActionJsonConverter))]
        public global::Withings.NotifyUpdateRequestAction Action { get; set; }

        /// <summary>
        /// Current callback URL of the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackurl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Callbackurl { get; set; }

        /// <summary>
        /// New callback URL to update to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_callbackurl")]
        public string? NewCallbackurl { get; set; }

        /// <summary>
        /// Data type of the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Appli { get; set; }

        /// <summary>
        /// New data type to update to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_appli")]
        public int? NewAppli { get; set; }

        /// <summary>
        /// Updated comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyUpdateRequest" /> class.
        /// </summary>
        /// <param name="callbackurl">
        /// Current callback URL of the subscription
        /// </param>
        /// <param name="appli">
        /// Data type of the subscription
        /// </param>
        /// <param name="action"></param>
        /// <param name="newCallbackurl">
        /// New callback URL to update to
        /// </param>
        /// <param name="newAppli">
        /// New data type to update to
        /// </param>
        /// <param name="comment">
        /// Updated comment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyUpdateRequest(
            string callbackurl,
            int appli,
            global::Withings.NotifyUpdateRequestAction action,
            string? newCallbackurl,
            int? newAppli,
            string? comment)
        {
            this.Action = action;
            this.Callbackurl = callbackurl ?? throw new global::System.ArgumentNullException(nameof(callbackurl));
            this.NewCallbackurl = newCallbackurl;
            this.Appli = appli;
            this.NewAppli = newAppli;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyUpdateRequest" /> class.
        /// </summary>
        public NotifyUpdateRequest()
        {
        }
    }
}