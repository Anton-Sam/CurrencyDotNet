﻿using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Interfaces
{
    internal interface ICurrencyRestClient : IDisposable
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
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<CallResult<IEnumerable<Ticker>>> GetAllTickersAsync(
            CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the ticker for a selected symbol for the last 24 hours
        /// </summary>
        /// <param name="symbol">Symbol</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<CallResult<Ticker>> GetTickerAsync(string symbol,
            CancellationToken cancellationToken = default(CancellationToken));
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
