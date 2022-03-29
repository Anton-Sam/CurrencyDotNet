using CurrencyDotNet.Common.Enums;
using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests;
using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

namespace CurrencyDotNet.RestClient
{
    internal class CurrencyRestClient : ICurrencyRestClient
    {
        private readonly IRestApiProvider _restApiProvider;

        public CurrencyRestClient(string apiKey,
            ClientMode clientMode = ClientMode.Real,
            ApiVersion apiVersion = ApiVersion.V1)
        {
            _restApiProvider = new RestApiProvider();
        }

        public void Dispose()
        {
            _restApiProvider.Dispose();
        }

        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void ClosePosition()
        {
            throw new NotImplementedException();
        }

        public void GetAccountInfo()
        {
            throw new NotImplementedException();
        }

        public async Task<CallResult<AggregatedTradeHistory>> GetAggregatedTradesHistoryAwait(int endTime, 
            int limit, 
            int startTime, 
            string symbol, 
            CancellationToken cancellationToken)
        {
            var request = new GetAggregatedTradeHistoryRequest(
                endTime: endTime, 
                limit: limit, 
                startTime: startTime, 
                symbol: symbol);

            return await _restApiProvider.GetRequestAsync<AggregatedTradeHistory>(request, cancellationToken);
        }

        public void GetCurrencies()
        {
            throw new NotImplementedException();
        }

        public void GetDepositAddress()
        {
            throw new NotImplementedException();
        }

        public void GetDeposits()
        {
            throw new NotImplementedException();
        }

        public void GetExcangeInfo()
        {
            throw new NotImplementedException();
        }

        public void GetFundingLimits()
        {
            throw new NotImplementedException();
        }

        public void GetKlines()
        {
            throw new NotImplementedException();
        }

        public void GetLedgers()
        {
            throw new NotImplementedException();
        }

        public void GetLeverageSettings()
        {
            throw new NotImplementedException();
        }

        public void GetOpenOrders()
        {
            throw new NotImplementedException();
        }

        public void GetOrderBook()
        {
            throw new NotImplementedException();
        }

        public void GetTicker24hr()
        {
            throw new NotImplementedException();
        }

        public void GetTime()
        {
            throw new NotImplementedException();
        }

        public void GetTrades()
        {
            throw new NotImplementedException();
        }

        public void GetTradingFees()
        {
            throw new NotImplementedException();
        }

        public void GetTradingLimits()
        {
            throw new NotImplementedException();
        }

        public void GetTradingPositions()
        {
            throw new NotImplementedException();
        }

        public void GetTradingPositionsHistory()
        {
            throw new NotImplementedException();
        }

        public void GetTransactions()
        {
            throw new NotImplementedException();
        }

        public void GetWithdrawals()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdatePosition()
        {
            throw new NotImplementedException();
        }
    }
}
