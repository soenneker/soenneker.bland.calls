using Soenneker.Bland.Calls.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Bland.Calls.Tests;

[Collection("Collection")]
public class BlandCallUtilTests : FixturedUnitTest
{
    private readonly IBlandCallUtil _util;

    public BlandCallUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IBlandCallUtil>(true);
    }
}
