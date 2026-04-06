
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Withings.JsonConverters.MeasureGetmeasRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.MeasureGetmeasRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetactivityRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetactivityRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetintradayactivityRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetintradayactivityRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetworkoutsRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Measurev2GetworkoutsRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Sleepv2GetRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Sleepv2GetRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Sleepv2GetsummaryRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Sleepv2GetsummaryRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Heartv2ListRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Heartv2ListRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.Heartv2GetRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.Heartv2GetRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.UserGetdeviceRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.UserGetdeviceRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyListRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyListRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.NotifySubscribeRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.NotifySubscribeRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyRevokeRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyRevokeRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyGetRequestActionJsonConverter),

            typeof(global::Withings.JsonConverters.NotifyGetRequestActionNullableJsonConverter),

            typeof(global::Withings.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetMeasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetMeasResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetMeasResponseBodyMeasuregrp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.MeasureGetMeasResponseBodyMeasuregrpMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetMeasResponseBodyMeasuregrpMeasure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetActivityResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.GetActivityResponseBodyActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetActivityResponseBodyActivitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetIntradayActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetIntradayActivityResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Withings.GetIntradayActivityResponseBodySeries2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetIntradayActivityResponseBodySeries2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetWorkoutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetWorkoutsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.GetWorkoutsResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetWorkoutsResponseBodySerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.GetWorkoutsResponseBodySerieData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.SleepGetResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetResponseBodySerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetSummaryResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.SleepGetSummaryResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetSummaryResponseBodySerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SleepGetSummaryResponseBodySerieData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartListResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.HeartListResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartListResponseBodySerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartListResponseBodySerieEcg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartListResponseBodySerieBloodpressure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.HeartGetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.UserGetDeviceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.UserGetDeviceResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.UserGetDeviceResponseBodyDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.UserGetDeviceResponseBodyDevice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyListResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Withings.NotifyListResponseBodyProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyListResponseBodyProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.SuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetmeasRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.MeasureGetmeasRequestAction), TypeInfoPropertyName = "MeasureGetmeasRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetactivityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetactivityRequestAction), TypeInfoPropertyName = "Measurev2GetactivityRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetintradayactivityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetintradayactivityRequestAction), TypeInfoPropertyName = "Measurev2GetintradayactivityRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetworkoutsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Measurev2GetworkoutsRequestAction), TypeInfoPropertyName = "Measurev2GetworkoutsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Sleepv2GetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Sleepv2GetRequestAction), TypeInfoPropertyName = "Sleepv2GetRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Sleepv2GetsummaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Sleepv2GetsummaryRequestAction), TypeInfoPropertyName = "Sleepv2GetsummaryRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Heartv2ListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Heartv2ListRequestAction), TypeInfoPropertyName = "Heartv2ListRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Heartv2GetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.Heartv2GetRequestAction), TypeInfoPropertyName = "Heartv2GetRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.UserGetdeviceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.UserGetdeviceRequestAction), TypeInfoPropertyName = "UserGetdeviceRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyListRequestAction), TypeInfoPropertyName = "NotifyListRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifySubscribeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifySubscribeRequestAction), TypeInfoPropertyName = "NotifySubscribeRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyRevokeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyRevokeRequestAction), TypeInfoPropertyName = "NotifyRevokeRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyGetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Withings.NotifyGetRequestAction), TypeInfoPropertyName = "NotifyGetRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.MeasureGetMeasResponseBodyMeasuregrp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.MeasureGetMeasResponseBodyMeasuregrpMeasure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.GetActivityResponseBodyActivitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.GetWorkoutsResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.SleepGetResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.SleepGetSummaryResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.HeartListResponseBodySerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.UserGetDeviceResponseBodyDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Withings.NotifyListResponseBodyProfile>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}