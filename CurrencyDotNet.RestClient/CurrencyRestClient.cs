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
            _restApiProvider = new RestApiProvider(clientMode, apiVersion);
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

        public async Task<CallResult<AggregatedTradeHistory>> GetAggregatedTradesHistoryAwait(string symbol,
            int? limit = null,
            DateTime? endTime = null,
            DateTime? startTime = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetAggregatedTradeHistoryRequest(
                symbol: symbol,
                limit: limit,
                endTime: ((DateTimeOffset)endTime).ToUnixTimeSeconds(),
                startTime: ((DateTimeOffset)startTime).ToUnixTimeSeconds()
                );

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
        /// <summary>
        /// Returns tickers for all the symbols for the last 24 hours
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CallResult<IEnumerable<Ticker>>> GetAllTickersAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetTickerRequest();

            return await _restApiProvider.GetRequestAsync<IEnumerable<Ticker>>(request, cancellationToken);
        }
        /// <summary>
        /// Returns ticker for a selected symbol for the last 24 hours
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CallResult<Ticker>> GetTickerAsync(string symbol,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetTickerRequest(symbol: symbol);

            return await _restApiProvider.GetRequestAsync<Ticker>(request, cancellationToken);
        }
    }
}
