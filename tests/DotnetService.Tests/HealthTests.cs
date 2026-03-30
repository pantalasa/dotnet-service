namespace DotnetService.Tests;

public class HealthTests
{
    [Fact]
    public void ServiceName_ShouldNotBeEmpty()
    {
        var serviceName = "DotnetService";
        Assert.NotEmpty(serviceName);
    }
}
