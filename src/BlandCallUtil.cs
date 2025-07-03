using System;
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
using Soenneker.Extensions.Object;

namespace Soenneker.Bland.Calls;

/// <inheritdoc cref="IBlandCallUtil"/>
public sealed class BlandCallUtil : IBlandCallUtil
{
    private readonly IBlandClientUtil _blandClientUtil;
    private readonly ILogger<BlandCallUtil> _logger;

    public BlandCallUtil(IBlandClientUtil blandClientUtil, ILogger<BlandCallUtil> logger)
    {
        _blandClientUtil = blandClientUtil;
        _logger = logger;
    }

    public async ValueTask<CreateCallResponse?> Create(CreateCallRequest request, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClientUtil.Get(cancellationToken).NoSync();

        return await client.SendToType<CreateCallResponse>(HttpMethod.Post, "calls", request, _logger, cancellationToken).NoSync();
    }

    public async ValueTask<CallDetailsResponse?> Get(string id, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClientUtil.Get(cancellationToken).NoSync();

        return await client.SendToType<CallDetailsResponse>($"calls/{id}", _logger, cancellationToken).NoSync();
    }

    public async ValueTask<CallsResponse?> Get(CallFilterRequest filter, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClientUtil.Get(cancellationToken).NoSync();

        var uri = new UriBuilder
        {
            Path = "calls",
            Query = filter.ToQueryString()
        };

        return await client.SendToType<CallsResponse>(uri.ToString(), _logger, cancellationToken).NoSync();
    }

    public async ValueTask<CallStatusResponse?> Stop(string id, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClientUtil.Get(cancellationToken).NoSync();

        return await client.SendToType<CallStatusResponse>(HttpMethod.Post, $"calls/{id}/stop", null, _logger, cancellationToken).NoSync();
    }

    public async ValueTask<CallStatusResponse?> StopAllActive(CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClientUtil.Get(cancellationToken).NoSync();

        return await client.SendToType<CallStatusResponse>(HttpMethod.Post, "calls/active/stop", null, _logger, cancellationToken).NoSync();
    }
}