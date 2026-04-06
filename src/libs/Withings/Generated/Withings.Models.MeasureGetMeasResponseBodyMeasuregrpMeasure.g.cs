
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasureGetMeasResponseBodyMeasuregrpMeasure
    {
        /// <summary>
        /// Value (multiply by 10^unit to get real value)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// 1=Weight, 4=Height, 5=FatFreeMass, 6=FatRatio, 8=FatMassWeight, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 12=Temperature, 54=SpO2, 71=BodyTemp, 73=SkinTemp, 76=MuscleMass, 77=Hydration, 88=BoneMass, 91=PulseWaveVelocity, 123=VO2Max, 135=QRSInterval, 136=PRInterval, 137=QTInterval, 138=CorrectedQTInterval, 139=AtrialFibrillation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// Power of 10 to multiply value by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public int? Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        public int? Algo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fm")]
        public int? Fm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBodyMeasuregrpMeasure" /> class.
        /// </summary>
        /// <param name="value">
        /// Value (multiply by 10^unit to get real value)
        /// </param>
        /// <param name="type">
        /// 1=Weight, 4=Height, 5=FatFreeMass, 6=FatRatio, 8=FatMassWeight, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 12=Temperature, 54=SpO2, 71=BodyTemp, 73=SkinTemp, 76=MuscleMass, 77=Hydration, 88=BoneMass, 91=PulseWaveVelocity, 123=VO2Max, 135=QRSInterval, 136=PRInterval, 137=QTInterval, 138=CorrectedQTInterval, 139=AtrialFibrillation
        /// </param>
        /// <param name="unit">
        /// Power of 10 to multiply value by
        /// </param>
        /// <param name="algo"></param>
        /// <param name="fm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasureGetMeasResponseBodyMeasuregrpMeasure(
            int? value,
            int? type,
            int? unit,
            int? algo,
            int? fm)
        {
            this.Value = value;
            this.Type = type;
            this.Unit = unit;
            this.Algo = algo;
            this.Fm = fm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasureGetMeasResponseBodyMeasuregrpMeasure" /> class.
        /// </summary>
        public MeasureGetMeasResponseBodyMeasuregrpMeasure()
        {
        }
    }
}