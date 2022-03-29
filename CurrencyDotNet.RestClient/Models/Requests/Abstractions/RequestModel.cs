using CurrencyDotNet.Common.Models;
using CurrencyDotNet.Common.Extensions;

namespace CurrencyDotNet.RestClient.Models.Requests.Abstractions
{
    internal class RequestModel
    {
        public string GetQueryString()
        {
            Type myType = this.GetType();
            var propertiesList = myType.GetProperties();
            var parametersList = new List<string>();

            foreach (var propertyInfo in propertiesList)
            {
                var key = propertyInfo.Name.GetUriRequestParameterKey();
                var value = propertyInfo.GetValue(this);

                var keyValue = new UriRequestParameterKeyValueModel(key, value);
                if (!keyValue.IsEmpty()) parametersList.Add(keyValue.ToString());
            }

            return $"?{string.Join('&', parametersList)}";
        }
    }
}
