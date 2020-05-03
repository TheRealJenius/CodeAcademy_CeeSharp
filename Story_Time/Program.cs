using System;

namespace Story_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program will allow users to create their own story
            Author: Jesse Appiah - TheRealJenius
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Let's begin:");

            // Give the Mad Lib a title:
            string title = "The adventures of a day";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Provide a name:");
            string name = Console.ReadLine();
            Console.Write("Provide an adjective:");
            string adjective1 = Console.ReadLine();
            Console.Write("Provide another adjective:");
            string adjective2 = Console.ReadLine();
            Console.Write("Provide one last adjective:");
            string adjective3 = Console.ReadLine();
            Console.Write("Provide a verb:");
            string verb = Console.ReadLine();
            Console.Write("Provide a noun:");
            string noun1 = Console.ReadLine();
            Console.Write("Provide one more noun:");
            string noun2 = Console.ReadLine();
            Console.Write("Provide the name of an animal:");
            string animal = Console.ReadLine();
            Console.Write("Provide the name of a type of food:");
            string food = Console.ReadLine();
            Console.Write("Provide the name of a fruit:");
            string fruit = Console.ReadLine();
            Console.Write("Provide the name of a supehero:");
            string superhero = Console.ReadLine();
            Console.Write("Provide the name of a country:");
            string country = Console.ReadLine();
            Console.Write("Provide the name of a dessert:");
            string dessert = Console.ReadLine();
            Console.Write("Provide a year:");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine("Here's your story....");
            Console.WriteLine(story);
        }
    }
}
