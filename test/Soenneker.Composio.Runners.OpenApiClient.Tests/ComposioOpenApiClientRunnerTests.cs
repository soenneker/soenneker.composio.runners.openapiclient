using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Composio.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ComposioOpenApiClientRunnerTests : FixturedUnitTest
{
    public ComposioOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
