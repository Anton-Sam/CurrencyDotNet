using CurrencyDotNet.Common.Attributes;
using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Requests.Abstractions;
using FluentAssertions;
using System;
using Xunit;

namespace CurrencyDotNet.UnitTests.Requests.Abstractions;

public class PrivateRequestTests
{
    public class TimeProviderStub : TimeProvider
    {
        public override DateTimeOffset UtcNow => new DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero);
    }

    internal record PrivateRequestModelTestingClass(
        string ApiKey,
        [property: QueryParam("symbol")] string Symbol,
        [property: QueryParam("limit")] int? Limit = null) : PrivateRequest(ApiKey);

    [Fact]
    public void GetQueryString_TestPrivateRequest_QueryString()
    {
        //Arrange
        var key = "key";
        var symbol = "btc";

        var requestModel = new PrivateRequestModelTestingClass(key, symbol);

        var stub = new TimeProviderStub();
        TimeProvider.Current = stub;

        var expected = "symbol=btc&timestamp=1577836800000" +
            "&signature=d2fe05bf1fb3ad537771a5a297a3b2d2e5b8059e8edf0a4414a6f860d3895ba9";

        //Act
        var queryString = requestModel.GetQueryString();

        //Assert
        expected.Should().Be(queryString);
    }
}
