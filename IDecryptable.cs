using System;
namespace CaeserCipher
{
    public interface IDecryptable
    {
        string CaesarDecrypt(string message, int offset = 3);
    }
}
