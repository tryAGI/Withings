
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepGetSummaryResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("more")]
        public bool? More { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::Withings.SleepGetSummaryResponseBodySerie>? Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBody" /> class.
        /// </summary>
        /// <param name="more"></param>
        /// <param name="offset"></param>
        /// <param name="series"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepGetSummaryResponseBody(
            bool? more,
            int? offset,
            global::System.Collections.Generic.IList<global::Withings.SleepGetSummaryResponseBodySerie>? series)
        {
            this.More = more;
            this.Offset = offset;
            this.Series = series;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepGetSummaryResponseBody" /> class.
        /// </summary>
        public SleepGetSummaryResponseBody()
        {
        }
    }
}