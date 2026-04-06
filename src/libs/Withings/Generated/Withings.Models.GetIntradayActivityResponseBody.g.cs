
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetIntradayActivityResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.Dictionary<string, global::Withings.GetIntradayActivityResponseBodySeries2>? Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntradayActivityResponseBody" /> class.
        /// </summary>
        /// <param name="series"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntradayActivityResponseBody(
            global::System.Collections.Generic.Dictionary<string, global::Withings.GetIntradayActivityResponseBodySeries2>? series)
        {
            this.Series = series;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntradayActivityResponseBody" /> class.
        /// </summary>
        public GetIntradayActivityResponseBody()
        {
        }
    }
}