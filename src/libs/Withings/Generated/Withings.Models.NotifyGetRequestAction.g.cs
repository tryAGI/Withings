
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotifyGetRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotifyGetRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotifyGetRequestAction value)
        {
            return value switch
            {
                NotifyGetRequestAction.Get => "get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotifyGetRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "get" => NotifyGetRequestAction.Get,
                _ => null,
            };
        }
    }
}