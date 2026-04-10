#nullable enable

namespace Withings
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Get webhook subscription details<br/>
        /// Retrieves details of a specific webhook notification subscription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyGetAsync(

            global::Withings.NotifyGetRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook subscription details<br/>
        /// Retrieves details of a specific webhook notification subscription.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callbackurl"></param>
        /// <param name="appli"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyGetAsync(
            string callbackurl,
            int appli,
            global::Withings.NotifyGetRequestAction action = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}