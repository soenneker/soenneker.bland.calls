using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Calls.Responses;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Bland.Calls.Abstract;

/// <summary>
/// A .NET typesafe implementation of Bland.ai's Calls API
/// </summary>
public interface IBlandCallUtil
{
    /// <summary>
    /// Sends a call request to the Bland AI API.
    /// </summary>
    /// <param name="request">The call request containing details such as the target phone number and conversation configuration.</param>
    /// <param name="cancellationToken"></param>
    /// <returns>A <see cref="CreateCallResponse"/> containing information about the call.</returns>
    ValueTask<CreateCallResponse?> Create(CreateCallRequest request, CancellationToken cancellationToken = default);

    ValueTask<CallDetailsResponse?> Get(string id, CancellationToken cancellationToken = default);

    ValueTask<CallsResponse?> Get(CallFilterRequest filter, CancellationToken cancellationToken = default);

    ValueTask<CallStatusResponse?> Stop(string id, CancellationToken cancellationToken = default);

    ValueTask<CallStatusResponse?> StopAllActive(CancellationToken cancellationToken = default);
}
