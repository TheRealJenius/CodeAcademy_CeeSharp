using System;

namespace MethodOverloadPets
{
    class Program
    {
        static void Main(string[] args)
        {
            NamePets(); //in C# you can have multiple methods with the same name, just different parameters within them
            NamePets(nameTwo : "Jack", nameOne : "Jill"); // you can pass arguments in any order (by position or by name, when mixed you HAVE to do it in order of i.e. ref1, ref2, ref4)
            NamePets("Ben", "Tom", "Jerry");
        }
    
        static void NamePets(string nameOne, string nameTwo = "Joggy") //you can create default/optional arguments
        {
            Console.WriteLine($"Your pets {nameOne} and {nameTwo} will be joining your voyage across space!");
        }
    
        static void NamePets(string nameOne, string nameTwo, string nameThree)
        {
            Console.WriteLine($"Your pets {nameOne}, {nameTwo} and {nameThree} will be joining your voyage across space!");
        }
    
        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets =/");
        }
    }
}
