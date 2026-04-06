
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetActivityResponseBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("activities")]
        public global::System.Collections.Generic.IList<global::Withings.GetActivityResponseBodyActivitie>? Activities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActivityResponseBody" /> class.
        /// </summary>
        /// <param name="more"></param>
        /// <param name="offset"></param>
        /// <param name="activities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetActivityResponseBody(
            bool? more,
            int? offset,
            global::System.Collections.Generic.IList<global::Withings.GetActivityResponseBodyActivitie>? activities)
        {
            this.More = more;
            this.Offset = offset;
            this.Activities = activities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActivityResponseBody" /> class.
        /// </summary>
        public GetActivityResponseBody()
        {
        }
    }
}