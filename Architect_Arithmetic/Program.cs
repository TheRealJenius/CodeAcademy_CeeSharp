using System;

namespace Architect_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
          double totalArea = (RectArea(2500,1500)) + (0.5 * CircArea(375)) + (TriArea(750,500));
          double cost = Math.Round((totalArea * 180), 2); //rounding to two decimal places since it's money
          Console.WriteLine($"To build a replica of the Teotihuacan, which has a total area of {totalArea}m, it would cost {cost} Mexican Pesos");
        }
    
        static double RectArea(double length, double width)
        {
          return length * width;
        }
    
        static double CircArea(double radius)
        {
          return (Math.PI * Math.Pow(radius,2));
        }
    
        static double TriArea(double bottom, double height) //base is a keyord
        {
          return 0.5 * bottom * height;
        }
        
    }
}
