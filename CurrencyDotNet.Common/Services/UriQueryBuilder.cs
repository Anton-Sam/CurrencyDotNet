using CurrencyDotNet.Common.Interfaces;

namespace CurrencyDotNet.Common.Services
{
    public class UriQueryBuilder : IUriQueryBuilder, IDisposable
    {
        private string _query;

        public void Dispose() => _query = null;

        public string GetQuery() => _query;

        public UriQueryBuilder AddValue(string uriQueryPart)
        {
            _query = _query == null ? uriQueryPart : $"&{uriQueryPart}";
            return this;
        }    
    }
}
