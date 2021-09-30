using Cryptography.Service.Helpers;
using Cryptography.Service.Models;

namespace Cryptography.Service
{
    public class KeyGenerator : IKeyGenerator
    {
        public Key GeneratorKey()
        {
            var p = PrimesGenerator.Next();
            var q = PrimesGenerator.Next();

            var n = q * p;
            var eulerFunction = MathHelper.CalculateEulerFunction(p, q);
            var e = (int)PrimesGenerator.NextFromRange(1, eulerFunction);
            var d = MathHelper.CalculateModularMultiplicativeInverse(e, eulerFunction);

            return new Key(
                new PublicKey(n, e),
                new PrivateKey(n, d));
        }
    }
}