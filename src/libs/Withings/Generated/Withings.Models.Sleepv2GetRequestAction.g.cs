
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Sleepv2GetRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Sleepv2GetRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sleepv2GetRequestAction value)
        {
            return value switch
            {
                Sleepv2GetRequestAction.Get => "get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sleepv2GetRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "get" => Sleepv2GetRequestAction.Get,
                _ => null,
            };
        }
    }
}