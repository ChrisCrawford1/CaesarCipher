using System;
using System.Text;
namespace CaeserCipher
{
    public class MessageDecrypt : IDecryptable
    {
        public MessageDecrypt()
        {

        }

        public string CaesarDecrypt(string message, int offset = 3)
        {
            if (message.Length == 0)
                throw new ArgumentException("Message to decrypt must be greater than 0", "message");

            char[] splitMessage = message.ToCharArray();
            StringBuilder decryptedString = new StringBuilder();

            for (int i = 0; i < splitMessage.Length; i++)
            {
                char letter = splitMessage[i];
                int intLetter = (int)letter;

                var newLetter = Encoding.ASCII.GetString(new byte[] { (byte)(intLetter + offset) });
                decryptedString.Append(newLetter);
            }
            return decryptedString.ToString();
        }
    }
}
