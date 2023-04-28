using CurrencyDotNet.Common.Services;

namespace CurrencyDotNet.Common.Interfaces;

public interface IUriQueryBuilder
{
    string Build();
    UriQueryBuilder Add(string paramName, string? paramValue);
}
