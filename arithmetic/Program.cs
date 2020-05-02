using System;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 27;


            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;
        
        
            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
        
        
            // Time to Jupiter
            double journeyToJupiter = 6.142466;
        
        
            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;
        
        
            // New Age on Jupiter
            double newJupiterAge = newEarthAge /jupiterYears;
        
        
            // Log calculations to console
            Console.WriteLine(userAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newJupiterAge);
        }
    }
}
