using Soenneker.Tests.HostedUnit;

namespace Soenneker.Composio.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ComposioOpenApiClientRunnerTests : HostedUnitTest
{
    public ComposioOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
