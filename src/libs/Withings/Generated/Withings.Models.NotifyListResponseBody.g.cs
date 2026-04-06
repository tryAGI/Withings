
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotifyListResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::System.Collections.Generic.IList<global::Withings.NotifyListResponseBodyProfile>? Profiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListResponseBody" /> class.
        /// </summary>
        /// <param name="profiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotifyListResponseBody(
            global::System.Collections.Generic.IList<global::Withings.NotifyListResponseBodyProfile>? profiles)
        {
            this.Profiles = profiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyListResponseBody" /> class.
        /// </summary>
        public NotifyListResponseBody()
        {
        }
    }
}