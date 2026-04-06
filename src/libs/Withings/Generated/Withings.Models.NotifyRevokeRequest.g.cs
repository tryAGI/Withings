
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyRevokeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.NotifyRevokeRequestActionJsonConverter))]
        public global::Withings.NotifyRevokeRequestAction Action { get; set; }

        /// <summary>
        /// URL of the subscription to revoke
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackurl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Callbackurl { get; set; }

        /// <summary>
        /// Data type of the subscription to revoke
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
        /// Initializes a new instance of the <see cref="NotifyRevokeRequest" /> class.
        /// </summary>
        /// <param name="callbackurl">
        /// URL of the subscription to revoke
        /// </param>
        /// <param name="appli">
        /// Data type of the subscription to revoke
        /// </param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyRevokeRequest(
            string callbackurl,
            int appli,
            global::Withings.NotifyRevokeRequestAction action)
        {
            this.Action = action;
            this.Callbackurl = callbackurl ?? throw new global::System.ArgumentNullException(nameof(callbackurl));
            this.Appli = appli;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyRevokeRequest" /> class.
        /// </summary>
        public NotifyRevokeRequest()
        {
        }
    }
}