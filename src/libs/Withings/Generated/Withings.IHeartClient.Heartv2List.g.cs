#nullable enable

namespace Withings
{
    public partial interface IHeartClient
    {
        /// <summary>
        /// List heart measurements<br/>
        /// Retrieves a list of ECG recordings and blood pressure measurements<br/>
        /// including atrial fibrillation detection results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.HeartListResponse> Heartv2ListAsync(

            global::Withings.Heartv2ListRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List heart measurements<br/>
        /// Retrieves a list of ECG recordings and blood pressure measurements<br/>
        /// including atrial fibrillation detection results.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="startdate">
        /// Start date as Unix timestamp
        /// </param>
        /// <param name="enddate">
        /// End date as Unix timestamp
        /// </param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.HeartListResponse> Heartv2ListAsync(
            global::Withings.Heartv2ListRequestAction action = default,
            global::System.DateTimeOffset? startdate = default,
            global::System.DateTimeOffset? enddate = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}