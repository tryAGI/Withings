#nullable enable

namespace Withings
{
    public partial interface IHeartClient
    {
        /// <summary>
        /// Get ECG signal data<br/>
        /// Retrieves the raw ECG signal data for a specific recording identified by signalid.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.HeartGetResponse> Heartv2GetAsync(

            global::Withings.Heartv2GetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get ECG signal data<br/>
        /// Retrieves the raw ECG signal data for a specific recording identified by signalid.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="signalid">
        /// Signal ID from heart list response
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.HeartGetResponse> Heartv2GetAsync(
            int signalid,
            global::Withings.Heartv2GetRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}