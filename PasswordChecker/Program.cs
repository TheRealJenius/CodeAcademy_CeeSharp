using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining the criteria
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "\\/'@#;:.>,<]}[{#~¬`!\"£$%^&*()-_=+¦";

            // User's password
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            // a point for each criteria met
            int score = 0;

            if (password.Length >= minLength)
            {
              score++;
            }

            if (Tools.Contains(password,uppercase))
            {
              score++;
            }

            if (Tools.Contains(password,lowercase))
            {
              score++;
            }

            if (Tools.Contains(password,digits))
            {
              score++;
            }

            if (Tools.Contains(password,specialChars))
            {
              score++;
            }

            Console.WriteLine(score);

            switch (score)
            {
              case 1:
                Console.WriteLine("Your password is weeeaaakkk");
                break;

              case 2:
                Console.WriteLine("Your password barely passes");
                break;

              case 3:
                Console.WriteLine("Your password is alright... I guess");
                break;

              case 4:
                Console.WriteLine("Your password is quite good");
                break;

              case 5:
                Console.WriteLine("Your password is REALLLLYYY good!! O_O");
                break;

              default:
                break;
            }
        }
    }
}
