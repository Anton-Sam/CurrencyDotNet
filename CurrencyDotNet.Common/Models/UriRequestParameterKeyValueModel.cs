namespace CurrencyDotNet.Common.Models
{
    public class UriRequestParameterKeyValueModel
    {
        public string Key { get; set; }
        public object? Value { get; set; }

        public UriRequestParameterKeyValueModel(string key, object? value)
        {
            Key = key;
            Value = value;
        }

        public bool IsEmpty()
            => Key == null || Value == null;

        public override string ToString()
            => $"{Key}={Value}";
    }
}
