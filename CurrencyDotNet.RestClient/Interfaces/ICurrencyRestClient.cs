using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Interfaces
{
    public interface ICurrencyRestClient : IDisposable
    {
        void GetAccountInfo();

        Task<CallResult<AggregatedTradeHistory>> GetAggregatedTradesHistoryAsync(string symbol,
            int? limit = null,
            DateTime? endTime = null,
            DateTime? startTime = null,
            CancellationToken cancellationToken = default(CancellationToken));

        void GetCurrencies();
        void GetDepositAddress();
        void GetDeposits();

        Task<CallResult<OrderBook>> GetOrderBookAsync(string symbol,
            int? limit = null,
            CancellationToken cancellationToken = default(CancellationToken));

        void GetExcangeInfo();
        void GetFundingLimits();
        void GetKlines();
        void GetLedgers();
        void GetLeverageSettings();
        void GetTrades();
        void GetOpenOrders();
        void GetTicker24hr();
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
