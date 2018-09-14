using System;

namespace CaeserCipher
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a mesasge to encrypt: ");
            var messageToEncrypt = Console.ReadLine();

            Console.WriteLine("Encrypting {0}", messageToEncrypt);

            var encrypt = new MessageEncrypt(messageToEncrypt);
            var encryptedMessage = encrypt.CaeserEncrypt();
            Console.WriteLine("Encrypted {0}", encryptedMessage);

            Console.WriteLine();

            Console.WriteLine("Decrypting {0}", encryptedMessage);

            var decrypt = new MessageDecrypt();
            var decryptedMessage = decrypt.CaesarDecrypt(encryptedMessage);

            Console.WriteLine("Decrypted {0}", decryptedMessage);

        }
    }
}
