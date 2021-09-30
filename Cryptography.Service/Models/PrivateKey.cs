namespace Cryptography.Service.Models
{
    public class PrivateKey
    {
        public PrivateKey(
            long n,
            int d)
        {
            N = n;
            D = d;
        }

        public long N { get; }

        public int D { get; }
    }
}