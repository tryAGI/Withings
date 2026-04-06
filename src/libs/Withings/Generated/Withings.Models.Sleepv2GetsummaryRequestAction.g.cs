
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Sleepv2GetsummaryRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getsummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Sleepv2GetsummaryRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sleepv2GetsummaryRequestAction value)
        {
            return value switch
            {
                Sleepv2GetsummaryRequestAction.Getsummary => "getsummary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sleepv2GetsummaryRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getsummary" => Sleepv2GetsummaryRequestAction.Getsummary,
                _ => null,
            };
        }
    }
}