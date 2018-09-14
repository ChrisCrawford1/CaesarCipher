using System;
namespace CaeserCipher
{
    public interface IEncryptable
    {
        string CaeserEncrypt(int offset = 3);
        
    }
}
