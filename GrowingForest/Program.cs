using System;

namespace GrowingForest
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Amazon");
      
      Console.WriteLine(f.Trees);
      f.Grow();
      Console.WriteLine(f.Trees);

    }
  }
}
