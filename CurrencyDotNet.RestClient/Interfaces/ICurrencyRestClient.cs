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
        void GetTicker24hr();
        void GetTime();
        /// <summary>
        /// Returns trading fees for a selected symbol
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<CallResult<IEnumerable<TradingFee>>> GetTradingFeesAsync(string? symbol = null,
            CancellationToken cancellationToken = default(CancellationToken));
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
