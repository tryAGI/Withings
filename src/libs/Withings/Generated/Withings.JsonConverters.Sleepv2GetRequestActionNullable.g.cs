#nullable enable

namespace Withings.JsonConverters
{
    /// <inheritdoc />
    public sealed class Sleepv2GetRequestActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Withings.Sleepv2GetRequestAction?>
    {
        /// <inheritdoc />
        public override global::Withings.Sleepv2GetRequestAction? Read(
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
                        return global::Withings.Sleepv2GetRequestActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Withings.Sleepv2GetRequestAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Withings.Sleepv2GetRequestAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Withings.Sleepv2GetRequestAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Withings.Sleepv2GetRequestActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
