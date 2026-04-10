#nullable enable

namespace Withings
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get user personal info<br/>
        /// Retrieves the authenticated user's personal information including name,<br/>
        /// email, gender, birthdate, timezone, and unit preferences.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.UserGetInfoResponse> UserGetinfoAsync(

            global::Withings.UserGetinfoRequest request,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user personal info<br/>
        /// Retrieves the authenticated user's personal information including name,<br/>
        /// email, gender, birthdate, timezone, and unit preferences.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.UserGetInfoResponse> UserGetinfoAsync(
            global::Withings.UserGetinfoRequestAction action = default,
            global::Withings.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}