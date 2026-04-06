
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetinfoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Withings.JsonConverters.UserGetinfoRequestActionJsonConverter))]
        public global::Withings.UserGetinfoRequestAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetinfoRequest" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetinfoRequest(
            global::Withings.UserGetinfoRequestAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetinfoRequest" /> class.
        /// </summary>
        public UserGetinfoRequest()
        {
        }
    }
}