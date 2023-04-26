using CurrencyDotNet.Common.Services;

namespace CurrencyDotNet.Common.Interfaces
{
    public interface IUriQueryBuilder
    {
        string GetQuery();
        UriQueryBuilder AddValue(string uriQueryPart);
    }
}
