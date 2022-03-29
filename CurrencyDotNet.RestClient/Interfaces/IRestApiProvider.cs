namespace CurrencyDotNet.RestClient.Interfaces
{
    /// <summary>
    /// Provider for http requests
    /// </summary>
    public interface IRestApiProvider : IDisposable
    {
        /// <summary>
        /// Send http GET request
        /// </summary>
        /// <typeparam name="T">Type of response</typeparam>
        /// <param name="requestUri">Request uri</param>
        /// <param name="requestModel">Request model</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response object</returns>
        public Task<T> GetRequestAsync<T>(string requestUri, IRequestModel requestModel, CancellationToken token);

        /// <summary>
        /// Send http POST request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri">Request uri</param>
        /// <param name="requestModel">Request model</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response object</returns>
        public Task<T> PostRequestAsync<T>(string requestUri, IRequestModel requestModel, CancellationToken token);
    }
}
