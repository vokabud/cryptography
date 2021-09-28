using Cryptography.Service;
using Xunit;

namespace Cryptography.Serviceю.Tests
{
    public class CoderTests
    {
        [Fact]
        public void RunTest()
        {
            var plainText = "Hello world!";

            IKeyGenerator generator;
            ICoder coder;

            var key = generator.GeneratorKey();

            var cipherText = coder.Encrypt(key.PublicKey, plainText);
            var resultText = coder.Decrypt(key.PrivateKey, cipherText);

            Assert.Equal(plainText, resultText);
        }
    }
}
