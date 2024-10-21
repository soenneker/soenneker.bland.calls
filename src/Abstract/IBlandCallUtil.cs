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
    /// <returns>A <see cref="CallResponse"/> containing information about the call.</returns>
    ValueTask<CallResponse?> Create(CallRequest request, CancellationToken cancellationToken = default);
}
