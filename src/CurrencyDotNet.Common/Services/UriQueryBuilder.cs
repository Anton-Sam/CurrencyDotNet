using CurrencyDotNet.Common.Interfaces;

namespace CurrencyDotNet.Common.Services;

public class UriQueryBuilder : IUriQueryBuilder
{
    private List<string> _parts = new();

    public UriQueryBuilder()
    { }

    public UriQueryBuilder(string query)
    {
        _parts.Add(query);
    }

    public string Build()
    {
        var query = string.Join("&", _parts);
        _parts.Clear();

        return query;
    }

    public UriQueryBuilder Add(string paramName, string? paramValue)
    {
        if (!string.IsNullOrEmpty(paramName)
            && !string.IsNullOrEmpty(paramValue))
            _parts.Add(string.Concat(paramName, "=", paramValue));

        return this;
    }
}
