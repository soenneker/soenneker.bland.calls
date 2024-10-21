using Microsoft.Extensions.Logging;
using Soenneker.Bland.Calls.Abstract;
using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Calls.Responses;
using Soenneker.Bland.Client.Abstract;
using Soenneker.Extensions.HttpClient;
using Soenneker.Extensions.ValueTask;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Bland.Calls;

/// <inheritdoc cref="IBlandCallUtil"/>
public class BlandCallUtil: IBlandCallUtil
{
    private readonly IBlandClient _blandClient;
    private readonly ILogger<BlandCallUtil> _logger;

    public BlandCallUtil(IBlandClient blandClient, ILogger<BlandCallUtil> logger)
    {
        _blandClient = blandClient;
        _logger = logger;
    }

    public async ValueTask<CallResponse?> Create(CallRequest request, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        CallResponse? result = await client.SendToType<CallResponse>(HttpMethod.Post, "calls", request, _logger, cancellationToken).NoSync();

        return result;
    }
}
