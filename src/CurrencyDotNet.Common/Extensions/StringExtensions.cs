using System.Text;
using System.Security.Cryptography;
using Ardalis.GuardClauses;

namespace CurrencyDotNet.Common.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns HMAC SHA256 value
        /// </summary>
        /// <param name="message">Input message</param>
        /// <param name="secret">Key for calculating digital signature</param>
        /// <returns>Digital signature value</returns>
        public static string HmacSha256(this string message, string secret)
        {
            Guard.Against.NullOrEmpty(message, nameof(message));
            Guard.Against.NullOrEmpty(secret, nameof(secret));

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] keyBytes = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);

            using HMACSHA256 cryptographer = new HMACSHA256(keyBytes);

            byte[] bytes = cryptographer.ComputeHash(messageBytes);

            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Returns the key value of the request Uri parameter
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns>Key value of the request Uri parameter</returns>
        public static string GetUriRequestParameterKey(this string value)
        {
            if (value.Equals("ApiKey")) return "X-MBX-APIKEY";

            var firstPartLower = char.ToLower(value[0]);
            var secondPart = value[1..];
            return $"{firstPartLower}{secondPart}";
        }
    }
}
