using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AwesomeAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using Soenneker.Bland.Calls.Abstract;
using Soenneker.Bland.Calls.Requests;
using Soenneker.Bland.Client.Abstract;
using Soenneker.Tests.HostedUnit;


namespace Soenneker.Bland.Calls.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class BlandCallUtilTests : HostedUnitTest
{
    private readonly IBlandCallUtil _util;

    public BlandCallUtilTests(Host host) : base(host)
    {
        _util = Resolve<IBlandCallUtil>(true);
    }

    [Test]
    public void Default()
    { }

    [Test]
    public async Task Get_with_filter_uses_relative_calls_endpoint()
    {
        var handler = new RecordingHandler();
        var httpClient = new HttpClient(handler) {BaseAddress = new Uri("https://api.bland.ai/v1/")};
        var util = new BlandCallUtil(new TestClientUtil(httpClient), NullLogger<BlandCallUtil>.Instance);

        await util.Get(new CallFilterRequest {Limit = 25, Completed = true});

        handler.RequestUri.Should().Be(new Uri("https://api.bland.ai/v1/calls?limit=25&ascending=false&completed=true"));
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}")
            });
        }
    }

    private sealed class TestClientUtil(HttpClient client) : IBlandClientUtil
    {
        public ValueTask<HttpClient> Get(CancellationToken cancellationToken = default) => ValueTask.FromResult(client);

        public void Dispose()
        {
            client.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            client.Dispose();
            return ValueTask.CompletedTask;
        }
    }
}
