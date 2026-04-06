using tryAGI.Withings;

namespace Withings.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Withings tools with any MEAI-compatible AI provider
        using var client = new WithingsClient(apiKey: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}
