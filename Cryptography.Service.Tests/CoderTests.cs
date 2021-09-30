using Cryptography.Service.Models;
using Xunit;

namespace Cryptography.Service.Tests
{
    public class CoderTests
    {
        [Fact]
        public void Coder_Encrypt_int()
        {
            // arrange
            var publicKey = new PublicKey(77, 13);
            var message = 15;
            var expectedCipher = 64;

            // act
            var cipher = new Coder()
                .Encrypt(publicKey, message);

            // assert
            Assert.Equal(expectedCipher, cipher);
        }

        [Fact]
        public void Coder_Decrypt_int()
        {
            // arrange
            var privateKey = new PrivateKey(77, 37);
            var cipher = 64;
            var expectedMessage = 15;

            // act
            var message = new Coder()
                .Decrypt(privateKey, cipher);

            // assert
            Assert.Equal(expectedMessage, message);
        }

        [Fact]
        public void Coder_Encrypt_string()
        {
            // arrange
            var publicKey = new PublicKey(77, 13);
            var message = "1";
            var expectedCipher = new byte[] { 70, 0, 0, 0, 0, 0, 0, 0 };

            // act
            var cipher = new Coder()
                .Encrypt(publicKey, message);

            // assert
            Assert.Equal(expectedCipher, cipher);
        }

        [Fact]
        public void Coder_Decrypt_string()
        {
            // arrange
            var privateKey = new PrivateKey(77, 37);
            var cipher = new byte[] { 70, 0, 0, 0, 0, 0, 0, 0 };
            var expectedMessage = "1";

            // act
            var message = new Coder()
                .Decrypt(privateKey, cipher);

            // assert
            Assert.Equal(expectedMessage, message);
        }
    }
}
