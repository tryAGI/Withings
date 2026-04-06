
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartGetResponseBody
    {
        /// <summary>
        /// Raw ECG signal values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signal")]
        public global::System.Collections.Generic.IList<int>? Signal { get; set; }

        /// <summary>
        /// Sampling frequency in Hz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_frequency")]
        public int? SamplingFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wearposition")]
        public int? Wearposition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartGetResponseBody" /> class.
        /// </summary>
        /// <param name="signal">
        /// Raw ECG signal values
        /// </param>
        /// <param name="samplingFrequency">
        /// Sampling frequency in Hz
        /// </param>
        /// <param name="wearposition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartGetResponseBody(
            global::System.Collections.Generic.IList<int>? signal,
            int? samplingFrequency,
            int? wearposition)
        {
            this.Signal = signal;
            this.SamplingFrequency = samplingFrequency;
            this.Wearposition = wearposition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartGetResponseBody" /> class.
        /// </summary>
        public HeartGetResponseBody()
        {
        }
    }
}