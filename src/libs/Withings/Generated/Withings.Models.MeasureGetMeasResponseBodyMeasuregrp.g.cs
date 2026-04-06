
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasureGetMeasResponseBodyMeasuregrp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grpid")]
        public int? Grpid { get; set; }

        /// <summary>
        /// 0=device, 1=device ambiguous, 2=manual, 4=manual creation, 5=auto, 7=confirmed, 8=device v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attrib")]
        public int? Attrib { get; set; }

        /// <summary>
        /// Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        public int? Modified { get; set; }

        /// <summary>
        /// 1=real measures, 2=user objectives
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public int? Category { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("measures")]
        public global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrpMeasure>? Measures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBodyMeasuregrp" /> class.
        /// </summary>
        /// <param name="grpid"></param>
        /// <param name="attrib">
        /// 0=device, 1=device ambiguous, 2=manual, 4=manual creation, 5=auto, 7=confirmed, 8=device v2
        /// </param>
        /// <param name="date">
        /// Unix timestamp
        /// </param>
        /// <param name="created"></param>
        /// <param name="modified"></param>
        /// <param name="category">
        /// 1=real measures, 2=user objectives
        /// </param>
        /// <param name="deviceid"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="measures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasureGetMeasResponseBodyMeasuregrp(
            int? grpid,
            int? attrib,
            global::System.DateTimeOffset? date,
            int? created,
            int? modified,
            int? category,
            string? deviceid,
            string? hashDeviceid,
            global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrpMeasure>? measures)
        {
            this.Grpid = grpid;
            this.Attrib = attrib;
            this.Date = date;
            this.Created = created;
            this.Modified = modified;
            this.Category = category;
            this.Deviceid = deviceid;
            this.HashDeviceid = hashDeviceid;
            this.Measures = measures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBodyMeasuregrp" /> class.
        /// </summary>
        public MeasureGetMeasResponseBodyMeasuregrp()
        {
        }
    }
}