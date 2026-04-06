
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActivityResponseBodyActivitie
    {
        /// <summary>
        /// Date in YYYY-MM-DD format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceid")]
        public string? Deviceid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash_deviceid")]
        public string? HashDeviceid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        public int? Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tracker")]
        public bool? IsTracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Distance in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Elevation in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        public double? Elevation { get; set; }

        /// <summary>
        /// Light activity duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft")]
        public int? Soft { get; set; }

        /// <summary>
        /// Moderate activity duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderate")]
        public int? Moderate { get; set; }

        /// <summary>
        /// Intense activity duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intense")]
        public int? Intense { get; set; }

        /// <summary>
        /// Total active duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public int? Active { get; set; }

        /// <summary>
        /// Active calories burned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// Total calories including BMR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalcalories")]
        public double? Totalcalories { get; set; }

        /// <summary>
        /// Average heart rate
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
        /// Duration in light HR zone (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_0")]
        public int? HrZone0 { get; set; }

        /// <summary>
        /// Duration in moderate HR zone (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_1")]
        public int? HrZone1 { get; set; }

        /// <summary>
        /// Duration in intense HR zone (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_2")]
        public int? HrZone2 { get; set; }

        /// <summary>
        /// Duration in peak HR zone (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_3")]
        public int? HrZone3 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActivityResponseBodyActivitie" /> class.
        /// </summary>
        /// <param name="date">
        /// Date in YYYY-MM-DD format
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="deviceid"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="brand"></param>
        /// <param name="isTracker"></param>
        /// <param name="steps"></param>
        /// <param name="distance">
        /// Distance in meters
        /// </param>
        /// <param name="elevation">
        /// Elevation in meters
        /// </param>
        /// <param name="soft">
        /// Light activity duration in seconds
        /// </param>
        /// <param name="moderate">
        /// Moderate activity duration in seconds
        /// </param>
        /// <param name="intense">
        /// Intense activity duration in seconds
        /// </param>
        /// <param name="active">
        /// Total active duration in seconds
        /// </param>
        /// <param name="calories">
        /// Active calories burned
        /// </param>
        /// <param name="totalcalories">
        /// Total calories including BMR
        /// </param>
        /// <param name="hrAverage">
        /// Average heart rate
        /// </param>
        /// <param name="hrMin"></param>
        /// <param name="hrMax"></param>
        /// <param name="hrZone0">
        /// Duration in light HR zone (seconds)
        /// </param>
        /// <param name="hrZone1">
        /// Duration in moderate HR zone (seconds)
        /// </param>
        /// <param name="hrZone2">
        /// Duration in intense HR zone (seconds)
        /// </param>
        /// <param name="hrZone3">
        /// Duration in peak HR zone (seconds)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActivityResponseBodyActivitie(
            string? date,
            string? timezone,
            string? deviceid,
            string? hashDeviceid,
            int? brand,
            bool? isTracker,
            int? steps,
            double? distance,
            double? elevation,
            int? soft,
            int? moderate,
            int? intense,
            int? active,
            double? calories,
            double? totalcalories,
            int? hrAverage,
            int? hrMin,
            int? hrMax,
            int? hrZone0,
            int? hrZone1,
            int? hrZone2,
            int? hrZone3)
        {
            this.Date = date;
            this.Timezone = timezone;
            this.Deviceid = deviceid;
            this.HashDeviceid = hashDeviceid;
            this.Brand = brand;
            this.IsTracker = isTracker;
            this.Steps = steps;
            this.Distance = distance;
            this.Elevation = elevation;
            this.Soft = soft;
            this.Moderate = moderate;
            this.Intense = intense;
            this.Active = active;
            this.Calories = calories;
            this.Totalcalories = totalcalories;
            this.HrAverage = hrAverage;
            this.HrMin = hrMin;
            this.HrMax = hrMax;
            this.HrZone0 = hrZone0;
            this.HrZone1 = hrZone1;
            this.HrZone2 = hrZone2;
            this.HrZone3 = hrZone3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActivityResponseBodyActivitie" /> class.
        /// </summary>
        public GetActivityResponseBodyActivitie()
        {
        }
    }
}