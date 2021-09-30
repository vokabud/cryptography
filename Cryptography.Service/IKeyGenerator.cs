using Cryptography.Service.Models;

namespace Cryptography.Service
{
    public interface IKeyGenerator
    {
        Key GeneratorKey();
    }
}