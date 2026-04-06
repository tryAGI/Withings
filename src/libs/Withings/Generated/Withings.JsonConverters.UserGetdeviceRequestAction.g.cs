#nullable enable

namespace Withings.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserGetdeviceRequestActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Withings.UserGetdeviceRequestAction>
    {
        /// <inheritdoc />
        public override global::Withings.UserGetdeviceRequestAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Withings.UserGetdeviceRequestActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Withings.UserGetdeviceRequestAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Withings.UserGetdeviceRequestAction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Withings.UserGetdeviceRequestAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Withings.UserGetdeviceRequestActionExtensions.ToValueString(value));
        }
    }
}
