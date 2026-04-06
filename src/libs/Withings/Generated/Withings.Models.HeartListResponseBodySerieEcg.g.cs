
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartListResponseBodySerieEcg
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signalid")]
        public int? Signalid { get; set; }

        /// <summary>
        /// 0=negative, 1=positive, 2=inconclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afib")]
        public int? Afib { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerieEcg" /> class.
        /// </summary>
        /// <param name="signalid"></param>
        /// <param name="afib">
        /// 0=negative, 1=positive, 2=inconclusive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartListResponseBodySerieEcg(
            int? signalid,
            int? afib)
        {
            this.Signalid = signalid;
            this.Afib = afib;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerieEcg" /> class.
        /// </summary>
        public HeartListResponseBodySerieEcg()
        {
        }
    }
}