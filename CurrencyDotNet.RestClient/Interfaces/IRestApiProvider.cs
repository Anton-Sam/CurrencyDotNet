﻿namespace CurrencyDotNet.RestClient.Interfaces
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
        /// <param name="requestModel">Request model</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response object</returns>
        public Task<T> GetRequestAsync<T>(IRequestModel requestModel, CancellationToken token);

        /// <summary>
        /// Send http POST request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestModel">Request model</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>Response object</returns>
        public Task<T> PostRequestAsync<T>(IRequestModel requestModel, CancellationToken token);
    }
}
