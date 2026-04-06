#nullable enable

namespace Withings
{
    public partial interface IMeasureClient
    {
        /// <summary>
        /// Get body measurements<br/>
        /// Retrieves body measurements including weight, body composition, blood pressure,<br/>
        /// heart rate, temperature, SpO2, and more.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.MeasureGetMeasResponse> MeasureGetmeasAsync(

            global::Withings.MeasureGetmeasRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get body measurements<br/>
        /// Retrieves body measurements including weight, body composition, blood pressure,<br/>
        /// heart rate, temperature, SpO2, and more.
        /// </summary>
        /// <param name="action">
        /// Must be "getmeas"
        /// </param>
        /// <param name="meastype">
        /// Filter by measurement type (1=Weight, 4=Height, 9=DiastolicBP, 10=SystolicBP, 11=HeartPulse, 54=SpO2, etc.)
        /// </param>
        /// <param name="meastypes">
        /// Comma-separated list of measurement type IDs
        /// </param>
        /// <param name="category">
        /// 1=real measures, 2=user objectives
        /// </param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="lastupdate">
        /// Unix timestamp to get data updated after this time
        /// </param>
        /// <param name="offset">
        /// Pagination offset (from previous response)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.MeasureGetMeasResponse> MeasureGetmeasAsync(
            global::Withings.MeasureGetmeasRequestAction action = default,
            int? meastype = default,
            string? meastypes = default,
            int? category = default,
            global::System.DateTimeOffset? startdate = default,
            global::System.DateTimeOffset? enddate = default,
            global::System.DateTimeOffset? lastupdate = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}