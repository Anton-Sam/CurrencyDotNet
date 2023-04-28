using CurrencyDotNet.Common.Attributes;
using CurrencyDotNet.Common.Extensions;
using CurrencyDotNet.Common.Interfaces;
using CurrencyDotNet.Common.Services;

namespace CurrencyDotNet.RestClient.Requests.Abstractions;

internal abstract record PrivateRequest(
    string PrivateApiKey,
    [property: QueryParam("recvWindow")] int? RecvWindow = null) : Request
{
    [QueryParam("timestamp")]
    public long Timestamp =>
        TimeProvider.Current.UtcNow.ToUnixTimeMilliseconds();

    public override string GetQueryString()
    {
        var baseQuery = base.GetQueryString();

        IUriQueryBuilder builder = new UriQueryBuilder(baseQuery);
        builder.Add("signature", baseQuery.HmacSha256(PrivateApiKey));

        return builder.Build();
    }
}
