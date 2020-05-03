using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter the platinum you wish to make:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{amount} platinum is equal to...");
            
            //setting the amount of gold and silver coins
            double gold = Math.Floor(amount/10);
            double remaining = amount%10;
            double silver = Math.Floor(remaining/5);
            remaining = remaining%5;
        
            //Prinitng out the values
            Console.WriteLine($"Gold conis = {gold}");
            Console.WriteLine($"Silver conis = {silver}");
            Console.WriteLine($"Bronze conis = {remaining}");
        }
    }
}
