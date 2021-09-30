namespace Cryptography.Service.Models
{
    public class PublicKey
    {
        public PublicKey(
            long n,
            int e)
        {
            N = n;
            E = e;
        }

        public long N { get; }

        public int E { get; }
    }
}