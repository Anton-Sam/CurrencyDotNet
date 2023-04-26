using CurrencyDotNet.Common.Extensions;
using System;
using Xunit;

namespace CurrencyDotNet.UnitTests.Common.Extensions
{
    public class StringExtensionsTests
    {
        [Fact]
        public void HmacSha256_NotEmptyMessageString_ReturnsHmacSha256Value()
        {
            //Arrange
            var message = "message";
            var secret = "key";
            var expected = "6e9ef29b75fffc5b7abae527d58fdadb2fe42e7219011976917343065f58ed4a";

            //Act
            var actual = message.HmacSha256(secret);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HmacSha256_EmptyMessageString_ThrowArgumentException()
        {
            //Arrange
            var message = "";
            var secret = "key";

            //Act
            var actual = () => message.HmacSha256(secret);

            //Assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void HmacSha256_EmptySecretString_ThrowArgumentException()
        {
            //Arrange
            var message = "message";
            var secret = "";

            //Act
            var actual = () => message.HmacSha256(secret);

            //Assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void HmacSha256_NullMessageString_ThrowArgumentNullException()
        {
            //Arrange
            string message = null;
            var secret = "key";

            //Act
            var actual = () => message.HmacSha256(secret);

            //Assert
            Assert.Throws<ArgumentNullException>(actual);
        }

        [Fact]
        public void HmacSha256_NullSecretString_ThrowArgumentNullException()
        {
            //Arrange
            string message = "message";
            string secret = null;

            //Act
            var actual = () => message.HmacSha256(secret);

            //Assert
            Assert.Throws<ArgumentNullException>(actual);
        }
    }
}
