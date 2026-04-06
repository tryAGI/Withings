
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetInfoResponseBodyUserUnitPref
    {
        /// <summary>
        /// 1=kg, 2=lbs, 14=stones
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// 6=cm, 7=ft/in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 6=km, 7=miles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int? Distance { get; set; }

        /// <summary>
        /// 11=Celsius, 13=Fahrenheit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public int? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponseBodyUserUnitPref" /> class.
        /// </summary>
        /// <param name="weight">
        /// 1=kg, 2=lbs, 14=stones
        /// </param>
        /// <param name="height">
        /// 6=cm, 7=ft/in
        /// </param>
        /// <param name="distance">
        /// 6=km, 7=miles
        /// </param>
        /// <param name="temperature">
        /// 11=Celsius, 13=Fahrenheit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetInfoResponseBodyUserUnitPref(
            int? weight,
            int? height,
            int? distance,
            int? temperature)
        {
            this.Weight = weight;
            this.Height = height;
            this.Distance = distance;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponseBodyUserUnitPref" /> class.
        /// </summary>
        public UserGetInfoResponseBodyUserUnitPref()
        {
        }
    }
}