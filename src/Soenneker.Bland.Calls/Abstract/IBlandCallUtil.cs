using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Calls.Responses;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Bland.Calls.Abstract;

/// <summary>
/// Creates, retrieves, filters, and stops calls through Bland.ai's Calls API.
/// </summary>
public interface IBlandCallUtil
{
    /// <summary>
    /// Sends a call request to the Bland AI API.
    /// </summary>
    /// <param name="request">The call request containing details such as the target phone number and conversation configuration.</param>
    /// <param name="cancellationToken">Token used to cancel the request.</param>
    /// <returns>A <see cref="CreateCallResponse"/> containing information about the call.</returns>
    ValueTask<CreateCallResponse?> Create(CreateCallRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets one call by its identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<CallDetailsResponse?> Get(string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets calls matching the supplied filter.
    /// </summary>
    /// <param name="filter">The filter.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<CallsResponse?> Get(CallFilterRequest filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stops one active call.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<CallStatusResponse?> Stop(string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stops all active calls for the authenticated account.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<CallStatusResponse?> StopAllActive(CancellationToken cancellationToken = default);
}
