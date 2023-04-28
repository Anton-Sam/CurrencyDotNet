using CurrencyDotNet.Common.Attributes;
using CurrencyDotNet.Common.Interfaces;
using CurrencyDotNet.Common.Services;
using System.Reflection;

namespace CurrencyDotNet.RestClient.Requests.Abstractions;

internal abstract record Request
{
    public virtual string GetQueryString()
    {
        IUriQueryBuilder builder = new UriQueryBuilder();

        foreach (var prop in GetType().GetProperties())
        {
            var attr = prop.GetCustomAttribute<QueryParamAttribute>();
            if (attr is null)
                continue;

            var value = prop.GetValue(this);
            if (value is null)
                continue;

            builder.Add(attr.Name,value.ToString());
        }

        return builder.Build();
    }
}
