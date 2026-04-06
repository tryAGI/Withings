
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotifyUpdateRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotifyUpdateRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotifyUpdateRequestAction value)
        {
            return value switch
            {
                NotifyUpdateRequestAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotifyUpdateRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "update" => NotifyUpdateRequestAction.Update,
                _ => null,
            };
        }
    }
}