using CurrencyDotNet.RestClient.Requests.Abstractions;
using CurrencyDotNet.RestClient.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Common;

internal interface IRestApiProvider : IDisposable
{

    Task<CallResult<T>> GetRequestAsync<T>(
        Request request,
        CancellationToken token = default);
    Task<CallResult<T>> GetRequestAsync<T>(
        PrivateRequest request,
        CancellationToken token = default);
    Task<CallResult<T>> PostRequestAsync<T>(
        PrivateRequest request,
        CancellationToken token);
}