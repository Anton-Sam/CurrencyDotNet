using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Interfaces
{
    internal interface ICurrencyRestClient : IDisposable
    {
        void GetAccountInfo();
        Task<CallResult<AggregatedTradeHistory>> GetAggregatedTradesHistoryAwait(string symbol,
            int? limit = null,
            DateTime? endTime = null,
            DateTime? startTime = null,
            CancellationToken cancellationToken = default(CancellationToken));
        void GetCurrencies();
        void GetDepositAddress();
        void GetDeposits();
        void GetOrderBook();
        void GetExcangeInfo();
        void GetFundingLimits();
        void GetKlines();
        void GetLedgers();
        void GetLeverageSettings();
        void GetTrades();
        void GetOpenOrders();
        /// <summary>
        /// Returns the ticker for all the symbols for the last 24 hours
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<CallResult<IEnumerable<Ticker>>> GetAllTickersAsync(
            CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the ticker for a selected symbol for the last 24 hours
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<CallResult<Ticker>> GetTickerAsync(string symbol,
            CancellationToken cancellationToken = default(CancellationToken));
        void GetTime();
        void GetTradingFees();
        void GetTradingLimits();
        void GetTradingPositions();
        void GetTradingPositionsHistory();
        void GetTransactions();
        void GetWithdrawals();
        void ClosePosition();
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
        void UpdatePosition();
    }
}
