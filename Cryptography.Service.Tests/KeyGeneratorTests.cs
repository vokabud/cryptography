using System;
using Xunit;

namespace Cryptography.Service.Tests
{
    public class KeyGeneratorTests
    {
        [Fact]
        public void RunTest_for_long()
        {
            // arrange
            ICoder coder = new Coder();

            var testValue = new Random().Next(10, 100);
            var key = new KeyGenerator().GeneratorKey();
            
            // act
            var cipher = coder.Encrypt(key.PublicKey, testValue);
            var resultValue = coder.Decrypt(key.PrivateKey, cipher);
            
            // assert
            Assert.Equal(testValue, resultValue);
        }

        [Fact]
        public void RunTest_for_string()
        {
            // arrange
            ICoder coder = new Coder();

            var testValue = "Hello world!";
            var key = new KeyGenerator().GeneratorKey();

            // act
            var cipher = coder.Encrypt(key.PublicKey, testValue);
            var resultValue = coder.Decrypt(key.PrivateKey, cipher);

            // assert
            Assert.Equal(testValue, resultValue);
        }
    }
}