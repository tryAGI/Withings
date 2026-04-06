
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Heartv2ListRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Heartv2ListRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Heartv2ListRequestAction value)
        {
            return value switch
            {
                Heartv2ListRequestAction.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Heartv2ListRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "list" => Heartv2ListRequestAction.List,
                _ => null,
            };
        }
    }
}