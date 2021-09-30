using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Cryptography.Service.Models;

namespace Cryptography.Service
{
    public class Coder : ICoder
    {
        public long Encrypt(PublicKey publicKey, long data)
        {
            return (long)(BigInteger.Pow(data, publicKey.E) % publicKey.N);
        }

        public long Decrypt(PrivateKey privateKey, long cipher)
        {
            return (long)(BigInteger.Pow(cipher, privateKey.D) % privateKey.N);
        }

        public byte[] Encrypt(PublicKey publicKey, string data)
        {
            var byteData = Encoding.UTF8.GetBytes(data);
            var encrypted = new List<byte>();

            foreach (var b in byteData)
            {
                var encryptedBit = Encrypt(publicKey, b);
                encrypted.AddRange(BitConverter.GetBytes(encryptedBit));
            }

            return encrypted
                .ToArray();
    }

        public string Decrypt(PrivateKey privateKey, byte[] data)
        {
            var decryptedData = new List<byte>();

            for (var i = 0; i < data.Length; i += 8)
            {
                var b = BitConverter.ToInt64(data, i);
                var decrypted = (byte)Decrypt(privateKey, b);
                decryptedData.Add(decrypted);
            }

            return Encoding.UTF8.GetString(decryptedData.ToArray());
        }

    }
}