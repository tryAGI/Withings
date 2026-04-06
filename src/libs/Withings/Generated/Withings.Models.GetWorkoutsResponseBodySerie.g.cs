
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkoutsResponseBodySerie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 1=Walk, 2=Run, 3=Hiking, 4=Skating, 5=BMX, 6=Bicycling, 7=Swimming, 8=Surfing, 12=Tennis, 13=Basketball, 14=Soccer, 16=Football, 18=Yoga, 28=Boxing, 30=Skiing, 35=Snowboarding, 36=Climbing, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public int? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startdate")]
        public int? Startdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enddate")]
        public int? Enddate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public int? Modified { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Withings.GetWorkoutsResponseBodySerieData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkoutsResponseBodySerie" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category">
        /// 1=Walk, 2=Run, 3=Hiking, 4=Skating, 5=BMX, 6=Bicycling, 7=Swimming, 8=Surfing, 12=Tennis, 13=Basketball, 14=Soccer, 16=Football, 18=Yoga, 28=Boxing, 30=Skiing, 35=Snowboarding, 36=Climbing, etc.
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="date"></param>
        /// <param name="modified"></param>
        /// <param name="deviceid"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkoutsResponseBodySerie(
            int? id,
            int? category,
            string? timezone,
            int? startdate,
            int? enddate,
            string? date,
            int? modified,
            string? deviceid,
            string? hashDeviceid,
            global::Withings.GetWorkoutsResponseBodySerieData? data)
        {
            this.Id = id;
            this.Category = category;
            this.Timezone = timezone;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Date = date;
            this.Modified = modified;
            this.Deviceid = deviceid;
            this.HashDeviceid = hashDeviceid;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkoutsResponseBodySerie" /> class.
        /// </summary>
        public GetWorkoutsResponseBodySerie()
        {
        }
    }
}