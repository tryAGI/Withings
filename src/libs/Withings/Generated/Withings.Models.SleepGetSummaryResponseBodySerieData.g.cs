
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepGetSummaryResponseBodySerieData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breathing_disturbances_intensity")]
        public double? BreathingDisturbancesIntensity { get; set; }

        /// <summary>
        /// Deep sleep duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepsleepduration")]
        public int? Deepsleepduration { get; set; }

        /// <summary>
        /// Light sleep duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lightsleepduration")]
        public int? Lightsleepduration { get; set; }

        /// <summary>
        /// REM sleep duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remsleepduration")]
        public int? Remsleepduration { get; set; }

        /// <summary>
        /// Time awake in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeupduration")]
        public int? Wakeupduration { get; set; }

        /// <summary>
        /// Time to fall asleep in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationtosleep")]
        public int? Durationtosleep { get; set; }

        /// <summary>
        /// Time to wake up in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationtowakeup")]
        public int? Durationtowakeup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_average")]
        public int? HrAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_max")]
        public int? HrMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_min")]
        public int? HrMin { get; set; }

        /// <summary>
        /// Average respiration rate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr_average")]
        public int? RrAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr_max")]
        public int? RrMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr_min")]
        public int? RrMin { get; set; }

        /// <summary>
        /// Sleep score 0-100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score")]
        public int? SleepScore { get; set; }

        /// <summary>
        /// Total snoring duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoring")]
        public int? Snoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoringepisodecount")]
        public int? Snoringepisodecount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeupcount")]
        public int? Wakeupcount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_of_bed_count")]
        public int? OutOfBedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_sleep_time")]
        public int? TotalSleepTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_timeinbed")]
        public int? TotalTimeinbed { get; set; }

        /// <summary>
        /// Sleep efficiency percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_efficiency")]
        public double? SleepEfficiency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_latency")]
        public int? SleepLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeup_latency")]
        public int? WakeupLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asleepduration")]
        public int? Asleepduration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("night_events")]
        public int? NightEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_rem_episodes")]
        public int? NbRemEpisodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apnea_hypopnea_index")]
        public double? ApneaHypopneaIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBodySerieData" /> class.
        /// </summary>
        /// <param name="breathingDisturbancesIntensity"></param>
        /// <param name="deepsleepduration">
        /// Deep sleep duration in seconds
        /// </param>
        /// <param name="lightsleepduration">
        /// Light sleep duration in seconds
        /// </param>
        /// <param name="remsleepduration">
        /// REM sleep duration in seconds
        /// </param>
        /// <param name="wakeupduration">
        /// Time awake in seconds
        /// </param>
        /// <param name="durationtosleep">
        /// Time to fall asleep in seconds
        /// </param>
        /// <param name="durationtowakeup">
        /// Time to wake up in seconds
        /// </param>
        /// <param name="hrAverage"></param>
        /// <param name="hrMax"></param>
        /// <param name="hrMin"></param>
        /// <param name="rrAverage">
        /// Average respiration rate
        /// </param>
        /// <param name="rrMax"></param>
        /// <param name="rrMin"></param>
        /// <param name="sleepScore">
        /// Sleep score 0-100
        /// </param>
        /// <param name="snoring">
        /// Total snoring duration in seconds
        /// </param>
        /// <param name="snoringepisodecount"></param>
        /// <param name="wakeupcount"></param>
        /// <param name="outOfBedCount"></param>
        /// <param name="totalSleepTime"></param>
        /// <param name="totalTimeinbed"></param>
        /// <param name="sleepEfficiency">
        /// Sleep efficiency percentage
        /// </param>
        /// <param name="sleepLatency"></param>
        /// <param name="wakeupLatency"></param>
        /// <param name="asleepduration"></param>
        /// <param name="nightEvents"></param>
        /// <param name="nbRemEpisodes"></param>
        /// <param name="apneaHypopneaIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepGetSummaryResponseBodySerieData(
            double? breathingDisturbancesIntensity,
            int? deepsleepduration,
            int? lightsleepduration,
            int? remsleepduration,
            int? wakeupduration,
            int? durationtosleep,
            int? durationtowakeup,
            int? hrAverage,
            int? hrMax,
            int? hrMin,
            int? rrAverage,
            int? rrMax,
            int? rrMin,
            int? sleepScore,
            int? snoring,
            int? snoringepisodecount,
            int? wakeupcount,
            int? outOfBedCount,
            int? totalSleepTime,
            int? totalTimeinbed,
            double? sleepEfficiency,
            int? sleepLatency,
            int? wakeupLatency,
            int? asleepduration,
            int? nightEvents,
            int? nbRemEpisodes,
            double? apneaHypopneaIndex)
        {
            this.BreathingDisturbancesIntensity = breathingDisturbancesIntensity;
            this.Deepsleepduration = deepsleepduration;
            this.Lightsleepduration = lightsleepduration;
            this.Remsleepduration = remsleepduration;
            this.Wakeupduration = wakeupduration;
            this.Durationtosleep = durationtosleep;
            this.Durationtowakeup = durationtowakeup;
            this.HrAverage = hrAverage;
            this.HrMax = hrMax;
            this.HrMin = hrMin;
            this.RrAverage = rrAverage;
            this.RrMax = rrMax;
            this.RrMin = rrMin;
            this.SleepScore = sleepScore;
            this.Snoring = snoring;
            this.Snoringepisodecount = snoringepisodecount;
            this.Wakeupcount = wakeupcount;
            this.OutOfBedCount = outOfBedCount;
            this.TotalSleepTime = totalSleepTime;
            this.TotalTimeinbed = totalTimeinbed;
            this.SleepEfficiency = sleepEfficiency;
            this.SleepLatency = sleepLatency;
            this.WakeupLatency = wakeupLatency;
            this.Asleepduration = asleepduration;
            this.NightEvents = nightEvents;
            this.NbRemEpisodes = nbRemEpisodes;
            this.ApneaHypopneaIndex = apneaHypopneaIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBodySerieData" /> class.
        /// </summary>
        public SleepGetSummaryResponseBodySerieData()
        {
        }
    }
}