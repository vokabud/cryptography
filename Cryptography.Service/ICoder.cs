using Cryptography.Service.Models;

namespace Cryptography.Service
{
    public interface ICoder
    {
        long Encrypt(PublicKey publicKey, long data);

        long Decrypt(PrivateKey publicKey, long cipher);

        byte[] Encrypt(PublicKey publicKey, string data);

        string Decrypt(PrivateKey publicKey, byte[] cipher);
    }
}