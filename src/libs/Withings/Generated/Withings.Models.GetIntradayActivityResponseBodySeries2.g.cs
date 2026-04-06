
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntradayActivityResponseBodySeries2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        public double? Elevation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        public int? Stroke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_lap")]
        public int? PoolLap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public int? HeartRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_auto")]
        public double? Spo2Auto { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntradayActivityResponseBodySeries2" /> class.
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="elevation"></param>
        /// <param name="calories"></param>
        /// <param name="distance"></param>
        /// <param name="stroke"></param>
        /// <param name="poolLap"></param>
        /// <param name="duration"></param>
        /// <param name="heartRate"></param>
        /// <param name="spo2Auto"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntradayActivityResponseBodySeries2(
            int? steps,
            double? elevation,
            double? calories,
            double? distance,
            int? stroke,
            int? poolLap,
            int? duration,
            int? heartRate,
            double? spo2Auto)
        {
            this.Steps = steps;
            this.Elevation = elevation;
            this.Calories = calories;
            this.Distance = distance;
            this.Stroke = stroke;
            this.PoolLap = poolLap;
            this.Duration = duration;
            this.HeartRate = heartRate;
            this.Spo2Auto = spo2Auto;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntradayActivityResponseBodySeries2" /> class.
        /// </summary>
        public GetIntradayActivityResponseBodySeries2()
        {
        }
    }
}