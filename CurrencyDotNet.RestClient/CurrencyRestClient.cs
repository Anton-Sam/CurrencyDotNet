using CurrencyDotNet.Common.Enums;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient
{
    internal class CurrencyRestClient : ICurrencyRestClient
    {
        public CurrencyRestClient(string apiKey,
            ClientMode clientMode = ClientMode.Real,
            ApiVersion apiVersion = ApiVersion.V1)
        {

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

        public void GetAggregatedTradesHistory()
        {
            throw new NotImplementedException();
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
