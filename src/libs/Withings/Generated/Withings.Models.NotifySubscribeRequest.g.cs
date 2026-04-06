
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifySubscribeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.NotifySubscribeRequestActionJsonConverter))]
        public global::Withings.NotifySubscribeRequestAction Action { get; set; }

        /// <summary>
        /// URL to receive webhook notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackurl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Callbackurl { get; set; }

        /// <summary>
        /// Data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appli")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Appli { get; set; }

        /// <summary>
        /// Optional comment for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifySubscribeRequest" /> class.
        /// </summary>
        /// <param name="callbackurl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="appli">
        /// Data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </param>
        /// <param name="action"></param>
        /// <param name="comment">
        /// Optional comment for the subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifySubscribeRequest(
            string callbackurl,
            int appli,
            global::Withings.NotifySubscribeRequestAction action,
            string? comment)
        {
            this.Action = action;
            this.Callbackurl = callbackurl ?? throw new global::System.ArgumentNullException(nameof(callbackurl));
            this.Appli = appli;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifySubscribeRequest" /> class.
        /// </summary>
        public NotifySubscribeRequest()
        {
        }
    }
}