using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Console.WriteLine("Please enter the message you wish to decode:");
            string message = Console.ReadLine();
            char[] secretMessage = message.ToCharArray(); //Changes the message string into an array of characters
            char[] encryptedMessage = new char[secretMessage.Length];
            
            //encryption begins
            for (int i=0; i<secretMessage.Length; i++)
            {
              char letter = secretMessage[i];
              int letterPos = Array.IndexOf(alphabet, letter);
              int alphaPos = (letterPos + 3) % 26; //encrypting the letter
              // wrapping it around % 26 ensures that we can still encrypt z (the last char)
              Console.WriteLine(alphaPos);
              Console.WriteLine(letterPos);
              Console.WriteLine((letterPos + 3)%26);
              char letterEncrypt = alphabet[alphaPos];
              encryptedMessage[i] = letterEncrypt;
            }
            string messageOut = String.Join("",encryptedMessage);
            Console.WriteLine(encryptedMessage);

        }
    }
}
