using CurrencyDotNet.Common;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;
using System;
using Xunit;

namespace CurrencyDotNet.UnitTests.RestClient.Models.Requests.Abstractions
{
    public class TimeProviderStub : TimeProvider
    {
        public override DateTimeOffset UtcNow => new DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero);
    }

    public class PrivateRequestModelTestingClass : PrivateRequestModel
    {
        public string Symbol { get; set; }
        public PrivateRequestModelTestingClass(string apiKey)
            : base(apiKey)
        { }
    }
    public class PrivateRequestModelTests
    {
        [Fact]
        public void GetQueryString_PrivateRequestModel_ReturnsQuesryString()
        {
            //Arrange
            var key = "key";
            var requestModel = new PrivateRequestModelTestingClass(apiKey: key)
            {
                Symbol = "btc",
                RecvWindow = 5000
            };
            
            var stub = new TimeProviderStub();
            TimeProvider.Current = stub;

            var expected = "symbol=btc&recvWindow=5000&timestamp=1577836800000" +
                "&signature=77b87e02887ed3567ca6159e88d27830cdbf09e3ec18397af0b783709530915c";
            //Act
            var queryString=requestModel.GetQueryString();
            //Assert
            Assert.Equal(expected, queryString);
        }
    }
}
