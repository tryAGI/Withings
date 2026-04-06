#nullable enable

using System.Text.Json.Serialization;

namespace tryAGI.Withings;

/// <summary>
/// Represents a webhook notification payload sent by Withings to your callback URL.
/// Withings sends POST requests with application/x-www-form-urlencoded body.
/// </summary>
public sealed class WithingsWebhookPayload
{
    /// <summary>
    /// The user ID (userid) associated with the notification.
    /// </summary>
    [JsonPropertyName("userid")]
    public int Userid { get; set; }

    /// <summary>
    /// The notification category (appli) indicating the data type that changed.
    /// </summary>
    [JsonPropertyName("appli")]
    public int Appli { get; set; }

    /// <summary>
    /// Start date of the affected data range (Unix timestamp).
    /// </summary>
    [JsonPropertyName("startdate")]
    public long? Startdate { get; set; }

    /// <summary>
    /// End date of the affected data range (Unix timestamp).
    /// </summary>
    [JsonPropertyName("enddate")]
    public long? Enddate { get; set; }

    /// <summary>
    /// Date of the affected data (Unix timestamp). Used for some notification types.
    /// </summary>
    [JsonPropertyName("date")]
    public long? Date { get; set; }
}

/// <summary>
/// Withings notification categories (appli values) for webhook subscriptions.
/// </summary>
public static class WithingsNotificationCategory
{
    /// <summary>Weight and body measurements (scale data).</summary>
    public const int Weight = 1;

    /// <summary>Temperature measurements.</summary>
    public const int Temperature = 2;

    /// <summary>Blood pressure measurements.</summary>
    public const int BloodPressure = 4;

    /// <summary>Activity data (steps, distance, calories).</summary>
    public const int Activity = 16;

    /// <summary>Sleep data (sleep stages, duration).</summary>
    public const int Sleep = 44;

    /// <summary>User info changes (profile updates).</summary>
    public const int UserInfo = 46;

    /// <summary>ECG recordings.</summary>
    public const int Ecg = 51;

    /// <summary>SpO2 measurements.</summary>
    public const int SpO2 = 54;
}
