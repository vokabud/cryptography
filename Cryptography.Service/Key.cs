namespace Cryptography.Service
{
    public class Key
    {
        public Key(
            PublicKey publicKey, 
            PrivateKey privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public PublicKey PublicKey { get; }

        public PrivateKey PrivateKey { get; }
    }
}
