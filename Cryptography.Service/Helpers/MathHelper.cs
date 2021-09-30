namespace Cryptography.Service.Helpers
{
    public static class MathHelper
    {
        public static long CalculateEulerFunction(
            long p,
            long q)
        {
            return (p - 1) * (q - 1);
        }

        public static int CalculateModularMultiplicativeInverse(
            long e,
            long eulerFunction)
        {
            e %= eulerFunction;

            for (var x = 1; x < eulerFunction; x++)
            {
                if (e * x % eulerFunction == 1)
                {
                    return x;
                }
            }

            return 1;
        }
    }
}