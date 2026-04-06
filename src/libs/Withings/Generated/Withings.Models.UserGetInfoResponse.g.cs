
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetInfoResponse
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
        public global::Withings.UserGetInfoResponseBody? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// API status code. 0 = success.
        /// </param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetInfoResponse(
            int? status,
            global::Withings.UserGetInfoResponseBody? body)
        {
            this.Status = status;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponse" /> class.
        /// </summary>
        public UserGetInfoResponse()
        {
        }
    }
}