namespace Withings.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WithingsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WITHINGS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WITHINGS_API_KEY environment variable is not found.");

        var client = new WithingsClient(apiKey);
        
        return client;
    }
}
