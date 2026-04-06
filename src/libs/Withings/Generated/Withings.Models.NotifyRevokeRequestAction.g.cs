
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotifyRevokeRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Revoke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotifyRevokeRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotifyRevokeRequestAction value)
        {
            return value switch
            {
                NotifyRevokeRequestAction.Revoke => "revoke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotifyRevokeRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "revoke" => NotifyRevokeRequestAction.Revoke,
                _ => null,
            };
        }
    }
}