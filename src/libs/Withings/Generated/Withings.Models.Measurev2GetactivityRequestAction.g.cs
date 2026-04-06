
#nullable enable

namespace Withings
{
    /// <summary>
    /// Action to perform
    /// </summary>
    public enum Measurev2GetactivityRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getactivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Measurev2GetactivityRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Measurev2GetactivityRequestAction value)
        {
            return value switch
            {
                Measurev2GetactivityRequestAction.Getactivity => "getactivity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Measurev2GetactivityRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getactivity" => Measurev2GetactivityRequestAction.Getactivity,
                _ => null,
            };
        }
    }
}