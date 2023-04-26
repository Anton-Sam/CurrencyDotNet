using CurrencyDotNet.Common.Enums;

namespace CurrencyDotNet.RestClient.Common;

public class CurrencyRestClient : ICurrencyRestClient
{
    private readonly IRestApiProvider _restApiProvider;
    private readonly string _apiKey;

    public CurrencyRestClient(string apiKey,
        ClientMode clientMode = ClientMode.Real,
        ApiVersion apiVersion = ApiVersion.V1)
    {
        _restApiProvider = new RestApiProvider(clientMode, apiVersion);
        _apiKey = apiKey;
    }

    public void Dispose()
    {
        _restApiProvider.Dispose();
    }
}
