#nullable enable

namespace Withings
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// List webhook subscriptions<br/>
        /// Lists all active webhook notification subscriptions for the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyListAsync(

            global::Withings.NotifyListRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook subscriptions<br/>
        /// Lists all active webhook notification subscriptions for the authenticated user.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="appli">
        /// Filter by data type: 1=Weight, 2=Temperature, 4=Blood pressure, 16=Activity, 44=Sleep, 46=User, 50=Bed in/out, 51=ECG, 52=SpO2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyListAsync(
            global::Withings.NotifyListRequestAction action = default,
            int? appli = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}