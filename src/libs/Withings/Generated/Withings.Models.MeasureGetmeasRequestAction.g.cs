
#nullable enable

namespace Withings
{
    /// <summary>
    /// Must be "getmeas"
    /// </summary>
    public enum MeasureGetmeasRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getmeas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MeasureGetmeasRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MeasureGetmeasRequestAction value)
        {
            return value switch
            {
                MeasureGetmeasRequestAction.Getmeas => "getmeas",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MeasureGetmeasRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getmeas" => MeasureGetmeasRequestAction.Getmeas,
                _ => null,
            };
        }
    }
}