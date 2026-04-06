
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserGetdeviceRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getdevice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGetdeviceRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetdeviceRequestAction value)
        {
            return value switch
            {
                UserGetdeviceRequestAction.Getdevice => "getdevice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetdeviceRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getdevice" => UserGetdeviceRequestAction.Getdevice,
                _ => null,
            };
        }
    }
}