using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
             // User Name
            string name = "Farhad Hesam Abbasi";

            // Get first letter
            char firstLetter = name[name.IndexOf('F')];


            // Get last name
            string lastName = name.Substring(name.IndexOf("A"));

            // Print results
            Console.WriteLine($"{firstLetter}. {lastName}");
             
             
             
             // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;


            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");
        
        
            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
        }
    }
}
