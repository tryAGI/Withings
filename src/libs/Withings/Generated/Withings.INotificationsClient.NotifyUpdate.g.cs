#nullable enable

namespace Withings
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Update webhook subscription<br/>
        /// Updates an existing webhook notification subscription with a new callback URL or comment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifyUpdateAsync(

            global::Withings.NotifyUpdateRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook subscription<br/>
        /// Updates an existing webhook notification subscription with a new callback URL or comment.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callbackurl">
        /// Current callback URL of the subscription
        /// </param>
        /// <param name="newCallbackurl">
        /// New callback URL to update to
        /// </param>
        /// <param name="appli">
        /// Data type of the subscription
        /// </param>
        /// <param name="newAppli">
        /// New data type to update to
        /// </param>
        /// <param name="comment">
        /// Updated comment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.SuccessResponse> NotifyUpdateAsync(
            string callbackurl,
            int appli,
            global::Withings.NotifyUpdateRequestAction action = default,
            string? newCallbackurl = default,
            int? newAppli = default,
            string? comment = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}