
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkoutsResponseBodySerieData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// Effective duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effduration")]
        public int? Effduration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_distance")]
        public double? ManualDistance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_calories")]
        public double? ManualCalories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_average")]
        public int? HrAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_min")]
        public int? HrMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_max")]
        public int? HrMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_0")]
        public int? HrZone0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_1")]
        public int? HrZone1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_2")]
        public int? HrZone2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_3")]
        public int? HrZone3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_duration")]
        public int? PauseDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_average")]
        public double? Spo2Average { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        public double? Elevation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_laps")]
        public int? PoolLaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strokes")]
        public int? Strokes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length")]
        public int? PoolLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkoutsResponseBodySerieData" /> class.
        /// </summary>
        /// <param name="calories"></param>
        /// <param name="effduration">
        /// Effective duration in seconds
        /// </param>
        /// <param name="intensity"></param>
        /// <param name="manualDistance"></param>
        /// <param name="manualCalories"></param>
        /// <param name="hrAverage"></param>
        /// <param name="hrMin"></param>
        /// <param name="hrMax"></param>
        /// <param name="hrZone0"></param>
        /// <param name="hrZone1"></param>
        /// <param name="hrZone2"></param>
        /// <param name="hrZone3"></param>
        /// <param name="pauseDuration"></param>
        /// <param name="spo2Average"></param>
        /// <param name="steps"></param>
        /// <param name="distance"></param>
        /// <param name="elevation"></param>
        /// <param name="poolLaps"></param>
        /// <param name="strokes"></param>
        /// <param name="poolLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkoutsResponseBodySerieData(
            double? calories,
            int? effduration,
            int? intensity,
            double? manualDistance,
            double? manualCalories,
            int? hrAverage,
            int? hrMin,
            int? hrMax,
            int? hrZone0,
            int? hrZone1,
            int? hrZone2,
            int? hrZone3,
            int? pauseDuration,
            double? spo2Average,
            int? steps,
            double? distance,
            double? elevation,
            int? poolLaps,
            int? strokes,
            int? poolLength)
        {
            this.Calories = calories;
            this.Effduration = effduration;
            this.Intensity = intensity;
            this.ManualDistance = manualDistance;
            this.ManualCalories = manualCalories;
            this.HrAverage = hrAverage;
            this.HrMin = hrMin;
            this.HrMax = hrMax;
            this.HrZone0 = hrZone0;
            this.HrZone1 = hrZone1;
            this.HrZone2 = hrZone2;
            this.HrZone3 = hrZone3;
            this.PauseDuration = pauseDuration;
            this.Spo2Average = spo2Average;
            this.Steps = steps;
            this.Distance = distance;
            this.Elevation = elevation;
            this.PoolLaps = poolLaps;
            this.Strokes = strokes;
            this.PoolLength = poolLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkoutsResponseBodySerieData" /> class.
        /// </summary>
        public GetWorkoutsResponseBodySerieData()
        {
        }
    }
}