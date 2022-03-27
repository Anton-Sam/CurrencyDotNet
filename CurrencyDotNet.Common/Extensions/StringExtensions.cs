using Ardalis.GuardClauses;
using System.Security.Cryptography;
using System.Text;

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
    }
}
