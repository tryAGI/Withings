
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyListRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.NotifyListRequestActionJsonConverter))]
        public global::Withings.NotifyListRequestAction Action { get; set; }

        /// <summary>
        /// Filter by data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appli")]
        public int? Appli { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="appli">
        /// Filter by data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyListRequest(
            global::Withings.NotifyListRequestAction action,
            int? appli)
        {
            this.Action = action;
            this.Appli = appli;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListRequest" /> class.
        /// </summary>
        public NotifyListRequest()
        {
        }
    }
}