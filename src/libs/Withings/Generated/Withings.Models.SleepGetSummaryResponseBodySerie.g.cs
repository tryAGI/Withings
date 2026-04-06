
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepGetSummaryResponseBodySerie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Withings.SleepGetSummaryResponseBodySerieData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBodySerie" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timezone"></param>
        /// <param name="model"></param>
        /// <param name="modelId"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="date"></param>
        /// <param name="modified"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepGetSummaryResponseBodySerie(
            int? id,
            string? timezone,
            int? model,
            int? modelId,
            string? hashDeviceid,
            int? startdate,
            int? enddate,
            string? date,
            int? modified,
            global::Withings.SleepGetSummaryResponseBodySerieData? data)
        {
            this.Id = id;
            this.Timezone = timezone;
            this.Model = model;
            this.ModelId = modelId;
            this.HashDeviceid = hashDeviceid;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Date = date;
            this.Modified = modified;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBodySerie" /> class.
        /// </summary>
        public SleepGetSummaryResponseBodySerie()
        {
        }
    }
}