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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyGetAsync(

            global::Withings.NotifyGetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook subscription details<br/>
        /// Retrieves details of a specific webhook notification subscription.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callbackurl"></param>
        /// <param name="appli"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.NotifyListResponse> NotifyGetAsync(
            string callbackurl,
            int appli,
            global::Withings.NotifyGetRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}