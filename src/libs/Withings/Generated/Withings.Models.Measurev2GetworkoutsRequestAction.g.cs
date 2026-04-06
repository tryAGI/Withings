
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public enum Measurev2GetworkoutsRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Getworkouts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Measurev2GetworkoutsRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Measurev2GetworkoutsRequestAction value)
        {
            return value switch
            {
                Measurev2GetworkoutsRequestAction.Getworkouts => "getworkouts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Measurev2GetworkoutsRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "getworkouts" => Measurev2GetworkoutsRequestAction.Getworkouts,
                _ => null,
            };
        }
    }
}