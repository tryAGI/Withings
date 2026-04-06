
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotifySubscribeRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Subscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotifySubscribeRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotifySubscribeRequestAction value)
        {
            return value switch
            {
                NotifySubscribeRequestAction.Subscribe => "subscribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotifySubscribeRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "subscribe" => NotifySubscribeRequestAction.Subscribe,
                _ => null,
            };
        }
    }
}