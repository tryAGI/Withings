
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Heartv2GetRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Heartv2GetRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Heartv2GetRequestAction value)
        {
            return value switch
            {
                Heartv2GetRequestAction.Get => "get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Heartv2GetRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "get" => Heartv2GetRequestAction.Get,
                _ => null,
            };
        }
    }
}