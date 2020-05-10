using System;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] {"Is the sun yellow?", "We have two moons?", "Cats can fly?"};
            bool[] answers = new bool[] {true, false, false};
            bool[] responses = new bool[answers.Length];
            int askingIndex = 0;
            if (questions.Length != answers.Length)
            {
              Console.WriteLine("The amount of questions and answers don't match!!!!!");
            }
            else
            {
              foreach (string question in questions)
              {
               Console.WriteLine(question);
               Console.WriteLine("True or False?");
               string input = Console.ReadLine();
               bool isBool;
               bool inputBool;
               isBool = Boolean.TryParse(input, out inputBool); //confirms if the statment can be turned into a boolean, returns fals if not
               while (isBool != true)
               {
                 Console.WriteLine("Please respond with 'true' or 'false'.");
                 input = Console.ReadLine();
                 isBool = Boolean.TryParse(input, out inputBool);
               }
               responses[askingIndex] = inputBool;
               askingIndex ++;
              }
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
              Console.WriteLine($"{scoringIndex + 1}. {answer} | Answer: {responses[scoringIndex]}");

              if (answer == responses[scoringIndex])
              {
                score++;
              }
              scoringIndex ++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
