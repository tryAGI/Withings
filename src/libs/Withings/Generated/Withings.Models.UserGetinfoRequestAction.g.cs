
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserGetinfoRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getinfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGetinfoRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetinfoRequestAction value)
        {
            return value switch
            {
                UserGetinfoRequestAction.Getinfo => "getinfo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetinfoRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getinfo" => UserGetinfoRequestAction.Getinfo,
                _ => null,
            };
        }
    }
}