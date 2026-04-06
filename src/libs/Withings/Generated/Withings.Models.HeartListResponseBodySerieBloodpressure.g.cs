
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartListResponseBodySerieBloodpressure
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diastole")]
        public int? Diastole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systole")]
        public int? Systole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerieBloodpressure" /> class.
        /// </summary>
        /// <param name="diastole"></param>
        /// <param name="systole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartListResponseBodySerieBloodpressure(
            int? diastole,
            int? systole)
        {
            this.Diastole = diastole;
            this.Systole = systole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponseBodySerieBloodpressure" /> class.
        /// </summary>
        public HeartListResponseBodySerieBloodpressure()
        {
        }
    }
}