
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetDeviceResponseBodyDevice
    {
        /// <summary>
        /// Device type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Device model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public int? ModelId { get; set; }

        /// <summary>
        /// Battery level (high, medium, low)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("battery")]
        public string? Battery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceid")]
        public string? Deviceid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash_deviceid")]
        public string? HashDeviceid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_session_date")]
        public int? LastSessionDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetDeviceResponseBodyDevice" /> class.
        /// </summary>
        /// <param name="type">
        /// Device type
        /// </param>
        /// <param name="model">
        /// Device model name
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="battery">
        /// Battery level (high, medium, low)
        /// </param>
        /// <param name="deviceid"></param>
        /// <param name="hashDeviceid"></param>
        /// <param name="timezone"></param>
        /// <param name="lastSessionDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetDeviceResponseBodyDevice(
            string? type,
            string? model,
            int? modelId,
            string? battery,
            string? deviceid,
            string? hashDeviceid,
            string? timezone,
            int? lastSessionDate)
        {
            this.Type = type;
            this.Model = model;
            this.ModelId = modelId;
            this.Battery = battery;
            this.Deviceid = deviceid;
            this.HashDeviceid = hashDeviceid;
            this.Timezone = timezone;
            this.LastSessionDate = lastSessionDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetDeviceResponseBodyDevice" /> class.
        /// </summary>
        public UserGetDeviceResponseBodyDevice()
        {
        }
    }
}