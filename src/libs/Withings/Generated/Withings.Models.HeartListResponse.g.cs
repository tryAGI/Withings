
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartListResponse
    {
        /// <summary>
        /// API status code. 0 = success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::Withings.HeartListResponseBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// API status code. 0 = success.
        /// </param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartListResponse(
            int? status,
            global::Withings.HeartListResponseBody? body)
        {
            this.Status = status;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartListResponse" /> class.
        /// </summary>
        public HeartListResponse()
        {
        }
    }
}