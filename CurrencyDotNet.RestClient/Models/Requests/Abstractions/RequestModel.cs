using CurrencyDotNet.Common.Models;
using CurrencyDotNet.Common.Extensions;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests.Abstractions
{
    public class RequestModel : IRequestModel
    {
        /// <summary>
        /// Takes all the properties of an object and the values ​​of those properties, providing them as a request Uri parameter.
        /// </summary>
        /// <returns>Parameter value for request Uri</returns>
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
