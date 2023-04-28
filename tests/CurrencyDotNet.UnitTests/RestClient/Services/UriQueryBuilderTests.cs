using CurrencyDotNet.Common.Services;
using FluentAssertions;
using Xunit;

namespace CurrencyDotNet.UnitTests.RestClient.Services;

public class UriQueryBuilderTests
{
    [Fact]
    public void Build_AddNotNullParams_ReturnsQuery()
    {
        //Arrange
        var builder = new UriQueryBuilder();
        builder.Add("symbol", "btc");
        builder.Add("recvwindow", 5000.ToString());

        var expected = "symbol=btc&recvwindow=5000";

        //Act
        var result = builder.Build();

        //Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Build_AddNullParamValue_ReturnsQuery()
    {
        //Arrange
        var builder = new UriQueryBuilder();
        builder.Add("symbol", "btc");
        builder.Add("recvwindow", null);

        var expected = "symbol=btc";

        //Act
        var result = builder.Build();

        //Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Build_AddNullParamName_ReturnsQuery()
    {
        //Arrange
        var builder = new UriQueryBuilder();
        builder.Add("symbol", "btc");
        builder.Add(null!, "value");

        var expected = "symbol=btc";

        //Act
        var result = builder.Build();

        //Assert
        result.Should().Be(expected);
    }
}
