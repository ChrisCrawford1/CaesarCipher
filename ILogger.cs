using System;
namespace CaeserCipher
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(string message);
    }
}
