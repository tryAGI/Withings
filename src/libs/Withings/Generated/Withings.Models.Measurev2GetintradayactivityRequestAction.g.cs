
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Measurev2GetintradayactivityRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getintradayactivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Measurev2GetintradayactivityRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Measurev2GetintradayactivityRequestAction value)
        {
            return value switch
            {
                Measurev2GetintradayactivityRequestAction.Getintradayactivity => "getintradayactivity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Measurev2GetintradayactivityRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getintradayactivity" => Measurev2GetintradayactivityRequestAction.Getintradayactivity,
                _ => null,
            };
        }
    }
}