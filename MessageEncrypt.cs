using System;
using System.Text;
namespace CaeserCipher
{
    public class MessageEncrypt : IEncryptable
    {
        private readonly string _message;
        private readonly int _offset;

        public MessageEncrypt()
        {

        }

        public MessageEncrypt(string message)
        {
            this._message = message;
        }

        public MessageEncrypt(string message, int offset)
            :this(message)
        {
            this._offset = offset;
        }

        public string CaeserEncrypt(int offset = 3)
        {
            if (_message.Length == 0)
                throw new ArgumentException("Message to encrypt must contain letters", "message");

            char[] splitMessage = _message.ToCharArray();
            StringBuilder encryptedString = new StringBuilder();

            for (int i = 0; i < splitMessage.Length; i++)
            {
                char letter = splitMessage[i];
                int intLetter = (int)letter;

                var newLetter = Encoding.ASCII.GetString(new byte[] { (byte)(intLetter-offset) });

                encryptedString.Append(newLetter);
            }
            return encryptedString.ToString();
        }
    }
}
