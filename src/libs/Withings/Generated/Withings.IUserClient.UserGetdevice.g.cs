#nullable enable

namespace Withings
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get user devices<br/>
        /// Retrieves a list of devices associated with the authenticated user<br/>
        /// including battery status, model, and timezone.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Withings.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.UserGetDeviceResponse> UserGetdeviceAsync(

            global::Withings.UserGetdeviceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user devices<br/>
        /// Retrieves a list of devices associated with the authenticated user<br/>
        /// including battery status, model, and timezone.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Withings.UserGetDeviceResponse> UserGetdeviceAsync(
            global::Withings.UserGetdeviceRequestAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}