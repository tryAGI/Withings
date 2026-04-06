#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace tryAGI.Withings;

/// <summary>
/// MEAI AIFunction tool extensions for WithingsClient.
/// </summary>
[System.CLSCompliant(false)]
public static class WithingsClientExtensions
{
    /// <summary>
    /// Returns all Withings tools as a list of AIFunction instances.
    /// </summary>
    public static IList<AIFunction> AsTools(this global::Withings.WithingsClient client)
    {
        return
        [
            client.AsGetBodyMeasurementsTool(),
            client.AsGetDailyActivityTool(),
            client.AsGetSleepSummaryTool(),
            client.AsGetHeartMeasurementsTool(),
            client.AsGetWorkoutsTool(),
            client.AsGetDevicesTool(),
        ];
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves body measurements (weight, BP, temperature, SpO2, etc.).
    /// </summary>
    public static AIFunction AsGetBodyMeasurementsTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startdate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? enddate,
                   [Description("Measurement type ID to filter (1=Weight, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 54=SpO2) (optional)")] int? meastype,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Measure.MeasureGetmeasAsync(
                    action: global::Withings.MeasureGetmeasRequestAction.Getmeas,
                    startdate: startdate is not null ? new DateTimeOffset(DateTime.Parse(startdate, System.Globalization.CultureInfo.InvariantCulture), TimeSpan.Zero) : null,
                    enddate: enddate is not null ? new DateTimeOffset(DateTime.Parse(enddate, System.Globalization.CultureInfo.InvariantCulture), TimeSpan.Zero) : null,
                    meastype: meastype,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    MeasureGroups = response.Body?.Measuregrps?.Select(g => new
                    {
                        g.Date,
                        g.Category,
                        Measures = g.Measures?.Select(m => new
                        {
                            m.Type,
                            m.Value,
                            m.Unit,
                        }).ToList(),
                    }).ToList(),
                    response.Body?.More,
                    response.Body?.Offset,
                };
            },
            name: "Withings_GetBodyMeasurements",
            description: "Get body measurements from Withings devices including weight, body composition, blood pressure, heart rate, temperature, and SpO2. Values need to be multiplied by 10^unit to get real values.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves daily activity summaries.
    /// </summary>
    public static AIFunction AsGetDailyActivityTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Start date in YYYY-MM-DD format (optional)")] string? startdateymd,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? enddateymd,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Activity.Measurev2GetactivityAsync(
                    action: global::Withings.Measurev2GetactivityRequestAction.Getactivity,
                    startdateymd: startdateymd,
                    enddateymd: enddateymd,
                    dataFields: "steps,distance,elevation,soft,moderate,intense,active,calories,totalcalories,hr_average,hr_min,hr_max",
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    Activities = response.Body?.Activities?.Select(a => new
                    {
                        a.Date,
                        a.Steps,
                        a.Distance,
                        a.Calories,
                        a.Totalcalories,
                        a.Soft,
                        a.Moderate,
                        a.Intense,
                        a.Active,
                        a.HrAverage,
                        a.HrMin,
                        a.HrMax,
                        a.Elevation,
                    }).ToList(),
                };
            },
            name: "Withings_GetDailyActivity",
            description: "Get daily activity summaries from Withings including steps, distance, calories burned, activity intensity durations, heart rate, and elevation.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves sleep summary data.
    /// </summary>
    public static AIFunction AsGetSleepSummaryTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Start date in YYYY-MM-DD format (optional)")] string? startdateymd,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? enddateymd,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Sleep.Sleepv2GetsummaryAsync(
                    action: global::Withings.Sleepv2GetsummaryRequestAction.Getsummary,
                    startdateymd: startdateymd,
                    enddateymd: enddateymd,
                    dataFields: "deepsleepduration,lightsleepduration,remsleepduration,wakeupduration,durationtosleep,hr_average,hr_min,hr_max,rr_average,sleep_score,snoring,snoringepisodecount,wakeupcount,sleep_efficiency,total_sleep_time,total_timeinbed,apnea_hypopnea_index",
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    SleepSessions = response.Body?.Series?.Select(s => new
                    {
                        s.Date,
                        s.Data?.SleepScore,
                        s.Data?.SleepEfficiency,
                        s.Data?.TotalSleepTime,
                        s.Data?.TotalTimeinbed,
                        s.Data?.Deepsleepduration,
                        s.Data?.Lightsleepduration,
                        s.Data?.Remsleepduration,
                        s.Data?.Wakeupduration,
                        s.Data?.Durationtosleep,
                        s.Data?.HrAverage,
                        s.Data?.HrMin,
                        s.Data?.HrMax,
                        s.Data?.RrAverage,
                        s.Data?.Snoring,
                        s.Data?.Snoringepisodecount,
                        s.Data?.Wakeupcount,
                        s.Data?.ApneaHypopneaIndex,
                    }).ToList(),
                };
            },
            name: "Withings_GetSleepSummary",
            description: "Get sleep summary data from Withings including sleep score, sleep efficiency, stage durations (deep, light, REM), heart rate, respiration rate, snoring, and sleep apnea index.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves heart/ECG measurements.
    /// </summary>
    public static AIFunction AsGetHeartMeasurementsTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startdate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? enddate,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Heart.Heartv2ListAsync(
                    action: global::Withings.Heartv2ListRequestAction.List,
                    startdate: startdate is not null ? new DateTimeOffset(DateTime.Parse(startdate, System.Globalization.CultureInfo.InvariantCulture), TimeSpan.Zero) : null,
                    enddate: enddate is not null ? new DateTimeOffset(DateTime.Parse(enddate, System.Globalization.CultureInfo.InvariantCulture), TimeSpan.Zero) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    Measurements = response.Body?.Series?.Select(m => new
                    {
                        m.Timestamp,
                        m.HeartRate,
                        Systole = m.Bloodpressure?.Systole,
                        Diastole = m.Bloodpressure?.Diastole,
                        EcgSignalId = m.Ecg?.Signalid,
                        AtrialFibrillation = m.Ecg?.Afib,
                    }).ToList(),
                };
            },
            name: "Withings_GetHeartMeasurements",
            description: "Get heart measurements from Withings including blood pressure (systolic/diastolic), heart rate, ECG recordings, and atrial fibrillation detection results.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves workout data.
    /// </summary>
    public static AIFunction AsGetWorkoutsTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Start date in YYYY-MM-DD format (optional)")] string? startdateymd,
                   [Description("End date in YYYY-MM-DD format (optional)")] string? enddateymd,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Activity.Measurev2GetworkoutsAsync(
                    action: global::Withings.Measurev2GetworkoutsRequestAction.Getworkouts,
                    startdateymd: startdateymd,
                    enddateymd: enddateymd,
                    dataFields: "calories,effduration,hr_average,hr_min,hr_max,steps,distance,elevation,spo2_average",
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    Workouts = response.Body?.Series?.Select(w => new
                    {
                        w.Category,
                        w.Date,
                        w.Startdate,
                        w.Enddate,
                        w.Data?.Calories,
                        w.Data?.Effduration,
                        w.Data?.HrAverage,
                        w.Data?.HrMin,
                        w.Data?.HrMax,
                        w.Data?.Steps,
                        w.Data?.Distance,
                        w.Data?.Elevation,
                        w.Data?.Spo2Average,
                    }).ToList(),
                };
            },
            name: "Withings_GetWorkouts",
            description: "Get workout data from Withings including sport category, calories, duration, heart rate, distance, elevation, and SpO2.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves user devices.
    /// </summary>
    public static AIFunction AsGetDevicesTool(this global::Withings.WithingsClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.User.UserGetdeviceAsync(
                    action: global::Withings.UserGetdeviceRequestAction.Getdevice,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Status,
                    Devices = response.Body?.Devices?.Select(d => new
                    {
                        d.Type,
                        d.Model,
                        d.ModelId,
                        d.Battery,
                        d.Timezone,
                        d.LastSessionDate,
                    }).ToList(),
                };
            },
            name: "Withings_GetDevices",
            description: "Get a list of Withings devices associated with the authenticated user including device type, model, battery level, and last session date.");
    }
}
