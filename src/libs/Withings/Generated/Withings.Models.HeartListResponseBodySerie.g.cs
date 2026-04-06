
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartListResponseBodySerie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceid")]
        public string? Deviceid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public int? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecg")]
        public global::Withings.HeartListResponseBodySerieEcg? Ecg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bloodpressure")]
        public global::Withings.HeartListResponseBodySerieBloodpressure? Bloodpressure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public int? HeartRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerie" /> class.
        /// </summary>
        /// <param name="deviceid"></param>
        /// <param name="model"></param>
        /// <param name="ecg"></param>
        /// <param name="bloodpressure"></param>
        /// <param name="heartRate"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartListResponseBodySerie(
            string? deviceid,
            int? model,
            global::Withings.HeartListResponseBodySerieEcg? ecg,
            global::Withings.HeartListResponseBodySerieBloodpressure? bloodpressure,
            int? heartRate,
            int? timestamp)
        {
            this.Deviceid = deviceid;
            this.Model = model;
            this.Ecg = ecg;
            this.Bloodpressure = bloodpressure;
            this.HeartRate = heartRate;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerie" /> class.
        /// </summary>
        public HeartListResponseBodySerie()
        {
        }
    }
}