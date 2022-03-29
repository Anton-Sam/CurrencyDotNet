using CurrencyDotNet.Common.Interfaces;

namespace CurrencyDotNet.Common.Services
{
    /// <summary>
    /// Creates a final endpoint for the Rest API
    /// </summary>
    public class UriQueryBuilder : IUriQueryBuilder, IDisposable
    {
        private string _query;

        public void Dispose() => _query = null;

        /// <summary>
        /// Returns final uri query for API endpoint
        /// </summary>
        /// <returns>Final uri query</returns>
        public string GetQuery() => _query;

        /// <summary>
        /// Adds a new parameter to the end of the current request
        /// </summary>
        /// <param name="uriQueryPart">New patameter for current request</param>
        /// <returns>This object</returns>
        public UriQueryBuilder AddValue(string uriQueryPart)
        {
            _query = _query == null ? uriQueryPart : $"&{uriQueryPart}";
            return this;
        }    
    }
}
