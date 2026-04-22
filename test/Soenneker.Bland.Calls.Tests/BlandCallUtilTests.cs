using Soenneker.Bland.Calls.Abstract;
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
}
