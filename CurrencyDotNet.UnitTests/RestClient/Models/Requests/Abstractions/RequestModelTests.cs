using Xunit;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.UnitTests.RestClient.Models.Requests.Abstractions
{
    public class RequestModelTestingClass : RequestModel
    {
        public string Symbol { get; set; }
        public int? Limit { get; set; }
        public long? StartTime { get; set; }
        public long? EndTime { get; set; }

        public RequestModelTestingClass(string symbol,
            int? limit = null,
            long? endTime = null,
            long? startTime = null)
        {
            Symbol = symbol;
            Limit = limit;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

    public class RequestModelTests
    {
        [Fact]
        public void GetQueryString_SuccessReturnValue()
        {
            //Arrange
            var requestModelTestingClass = new RequestModelTestingClass(
                symbol: "USD",
                limit: 1000,
                startTime: 90000);
            var expected = "?symbol=USD&limit=1000&startTime=90000";

            //Act
            var queryString = requestModelTestingClass.GetQueryString();

            //Assert
            Assert.Equal(expected, queryString);
        }
    }
}
