
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyListResponseBodyProfile
    {
        /// <summary>
        /// 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User info, 50=Bed in/out, 51=ECG, 52=SpO2, 54=Walking speed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appli")]
        public int? Appli { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackurl")]
        public string? Callbackurl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires")]
        public int? Expires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListResponseBodyProfile" /> class.
        /// </summary>
        /// <param name="appli">
        /// 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User info, 50=Bed in/out, 51=ECG, 52=SpO2, 54=Walking speed
        /// </param>
        /// <param name="callbackurl"></param>
        /// <param name="expires"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyListResponseBodyProfile(
            int? appli,
            string? callbackurl,
            int? expires,
            string? comment)
        {
            this.Appli = appli;
            this.Callbackurl = callbackurl;
            this.Expires = expires;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListResponseBodyProfile" /> class.
        /// </summary>
        public NotifyListResponseBodyProfile()
        {
        }
    }
}