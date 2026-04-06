#nullable enable

namespace Withings
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Subscribe to webhook notifications<br/>
        /// Creates a webhook subscription to receive notifications when new data is available.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifySubscribeAsync(

            global::Withings.NotifySubscribeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Subscribe to webhook notifications<br/>
        /// Creates a webhook subscription to receive notifications when new data is available.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callbackurl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="appli">
        /// Data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </param>
        /// <param name="comment">
        /// Optional comment for the subscription
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifySubscribeAsync(
            string callbackurl,
            int appli,
            global::Withings.NotifySubscribeRequestAction action = default,
            string? comment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}