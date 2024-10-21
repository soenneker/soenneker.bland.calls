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
public class BlandCallUtil : IBlandCallUtil
{
    private readonly IBlandClient _blandClient;
    private readonly ILogger<BlandCallUtil> _logger;

    public BlandCallUtil(IBlandClient blandClient, ILogger<BlandCallUtil> logger)
    {
        _blandClient = blandClient;
        _logger = logger;
    }

    public async ValueTask<CreateCallResponse?> Create(CreateCallRequest request, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        CreateCallResponse? result = await client.SendToType<CreateCallResponse>(HttpMethod.Post, "calls", request, _logger, cancellationToken).NoSync();

        return result;
    }

    public async ValueTask<CallDetailsResponse?> Get(string id, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        CallDetailsResponse? result = await client.SendToType<CallDetailsResponse>($"calls/{id}", _logger, cancellationToken).NoSync();

        return result;
    }

    public async ValueTask<CallsResponse?> Get(CallFilterRequest filter, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        var uri = new UriBuilder
        {
            Path = "calls",
            Query = filter.ToQueryString()
        };

        CallsResponse? result = await client.SendToType<CallsResponse>(uri.ToString(), _logger, cancellationToken).NoSync();

        return result;
    }

    public async ValueTask<CallStatusResponse?> Stop(string id, CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        CallStatusResponse? result = await client.SendToType<CallStatusResponse>(HttpMethod.Post, $"calls/{id}/stop", null, _logger, cancellationToken).NoSync();

        return result;
    }

    public async ValueTask<CallStatusResponse?> StopAllActive(CancellationToken cancellationToken = default)
    {
        HttpClient client = await _blandClient.Get(cancellationToken).NoSync();

        CallStatusResponse? result = await client.SendToType<CallStatusResponse>(HttpMethod.Post, "calls/active/stop", null, _logger, cancellationToken).NoSync();

        return result;
    }
}