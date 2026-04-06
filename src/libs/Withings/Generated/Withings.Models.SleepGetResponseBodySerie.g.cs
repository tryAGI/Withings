
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepGetResponseBodySerie
    {
        /// <summary>
        /// Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startdate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enddate")]
        public int? Enddate { get; set; }

        /// <summary>
        /// 0=Awake, 1=Light Sleep, 2=Deep Sleep, 3=REM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public int? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public int? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash_deviceid")]
        public string? HashDeviceid { get; set; }

        /// <summary>
        /// Heart rate time series (timestamp -&gt; HR)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr")]
        public global::System.Collections.Generic.Dictionary<string, int>? Hr { get; set; }

        /// <summary>
        /// Respiration rate time series
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr")]
        public global::System.Collections.Generic.Dictionary<string, int>? Rr { get; set; }

        /// <summary>
        /// Snoring intensity time series
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoring")]
        public global::System.Collections.Generic.Dictionary<string, int>? Snoring { get; set; }

        /// <summary>
        /// HRV SDNN time series
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdnn_1")]
        public global::System.Collections.Generic.Dictionary<string, double>? Sdnn1 { get; set; }

        /// <summary>
        /// HRV RMSSD time series
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rmssd")]
        public global::System.Collections.Generic.Dictionary<string, double>? Rmssd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetResponseBodySerie" /> class.
        /// </summary>
        /// <param name="startdate">
        /// Unix timestamp
        /// </param>
        /// <param name="enddate"></param>
        /// <param name="state">
        /// 0=Awake, 1=Light Sleep, 2=Deep Sleep, 3=REM
        /// </param>
        /// <param name="model"></param>
        /// <param name="modelId"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="hr">
        /// Heart rate time series (timestamp -&gt; HR)
        /// </param>
        /// <param name="rr">
        /// Respiration rate time series
        /// </param>
        /// <param name="snoring">
        /// Snoring intensity time series
        /// </param>
        /// <param name="sdnn1">
        /// HRV SDNN time series
        /// </param>
        /// <param name="rmssd">
        /// HRV RMSSD time series
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepGetResponseBodySerie(
            global::System.DateTimeOffset? startdate,
            int? enddate,
            int? state,
            int? model,
            int? modelId,
            string? hashDeviceid,
            global::System.Collections.Generic.Dictionary<string, int>? hr,
            global::System.Collections.Generic.Dictionary<string, int>? rr,
            global::System.Collections.Generic.Dictionary<string, int>? snoring,
            global::System.Collections.Generic.Dictionary<string, double>? sdnn1,
            global::System.Collections.Generic.Dictionary<string, double>? rmssd)
        {
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.State = state;
            this.Model = model;
            this.ModelId = modelId;
            this.HashDeviceid = hashDeviceid;
            this.Hr = hr;
            this.Rr = rr;
            this.Snoring = snoring;
            this.Sdnn1 = sdnn1;
            this.Rmssd = rmssd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetResponseBodySerie" /> class.
        /// </summary>
        public SleepGetResponseBodySerie()
        {
        }
    }
}