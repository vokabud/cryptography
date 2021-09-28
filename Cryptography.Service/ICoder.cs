namespace Cryptography.Service
{
    public interface ICoder
    {
        int Encrypt(PublicKey publicKey, int data);

        string Encrypt(PublicKey publicKey, string data);

        int Decrypt(PrivateKey publicKey, int cipher);

        string Decrypt(PrivateKey publicKey, string data);
    }
}