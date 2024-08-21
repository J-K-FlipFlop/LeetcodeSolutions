using System;
using System.Text;

namespace CodeWarsSolutions
{
    public class Rot13
    {
        public static string Rot13Encrypt(string message)
        {
            StringBuilder newMessage = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i] - 0);
                if ((message[i] - 0 < 110 && message[i] - 0 > 96) || (message[i] - 0 < 78 && message[i] - 0 > 64))
                {
                    int ascii = message[i] + 13;
                    newMessage[i] = Convert.ToChar(ascii);
                }
                else if ((message[i] - 0 >= 110 && message[i] - 0 < 123) || (message[i] - 0 >= 78 && message[i] - 0 < 91))
                {
                    int ascii = message[i] - 13;
                    newMessage[i] = Convert.ToChar(ascii);
                }
            }

            string result = newMessage.ToString();

            return result;
        }
    }
}