using CurrencyDotNet.Common.Attributes;
using CurrencyDotNet.RestClient.Requests.Abstractions;
using FluentAssertions;
using Xunit;

namespace CurrencyDotNet.UnitTests.Requests.Abstractions;

public class RequestTests
{
    internal record TestRequest(
    [property: QueryParam("symbol")] string Symbol,
    [property: QueryParam("limit")] int? Limit = null,
    [property: QueryParam("start")] long? StartTime = null,
    [property: QueryParam("end")] long? EndTime = null) : Request;

    [Fact]
    public void GetQueryString_TestRequest_ReturnsQueryString()
    {
        //Arrange
        var testRequest = new TestRequest(
            Symbol: "USD",
            Limit: 1000,
            StartTime: 90000);
        var expected = "symbol=USD&limit=1000&start=90000";

        //Act
        var queryString = testRequest.GetQueryString();

        //Assert
        expected.Should().Be(queryString);
    }
}
