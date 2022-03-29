using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Interfaces
{
    internal interface ICurrencyRestClient
    {
        void GetAccountInfo();
        Task<CallResult<AggregatedTradeHistory>> GetAggregatedTradesHistoryAwait(int endTime, 
            int limit, 
            int startTime, 
            string symbol, 
            CancellationToken cancellationToken);
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
