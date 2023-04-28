namespace CurrencyDotNet.Common.Attributes;

public class QueryParamAttribute : Attribute
{
    public string Name { get; }

    public QueryParamAttribute(string name)
    {
        Name = name;
    }
}
