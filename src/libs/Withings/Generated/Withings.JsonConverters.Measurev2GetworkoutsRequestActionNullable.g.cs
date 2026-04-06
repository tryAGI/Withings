#nullable enable

namespace Withings.JsonConverters
{
    /// <inheritdoc />
    public sealed class Measurev2GetworkoutsRequestActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Withings.Measurev2GetworkoutsRequestAction?>
    {
        /// <inheritdoc />
        public override global::Withings.Measurev2GetworkoutsRequestAction? Read(
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
                        return global::Withings.Measurev2GetworkoutsRequestActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Withings.Measurev2GetworkoutsRequestAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Withings.Measurev2GetworkoutsRequestAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Withings.Measurev2GetworkoutsRequestAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Withings.Measurev2GetworkoutsRequestActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
