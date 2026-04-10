#nullable enable

namespace Withings
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Revoke webhook subscription<br/>
        /// Removes an existing webhook notification subscription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifyRevokeAsync(

            global::Withings.NotifyRevokeRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke webhook subscription<br/>
        /// Removes an existing webhook notification subscription.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callbackurl">
        /// URL of the subscription to revoke
        /// </param>
        /// <param name="appli">
        /// Data type of the subscription to revoke
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifyRevokeAsync(
            string callbackurl,
            int appli,
            global::Withings.NotifyRevokeRequestAction action = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}