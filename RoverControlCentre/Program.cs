using System;

namespace RoverControlCentre
{
    class Program
    {
        static void Main(string[] args)
        {
          MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
          MoonRover apollo = new MoonRover("Apollo 15", 1971);
          MarsRover sojourner = new MarsRover("Sojourner", 1997);
          Satellite sputnik = new Satellite("Sputnik", 1957); 
  	    	Rover[] r = {lunokhod, apollo, sojourner};
          DirectAll(r);
    
          Object[] probes = {lunokhod, apollo, sojourner, sputnik};
          foreach (Object o in probes)
          {
            Console.WriteLine(o.GetType());
            Console.WriteLine("------------");
          }
    
          //now that I've set both Rover and Satellite to share the same interface, we can upcast
          IDirectable[] directing = {lunokhod, apollo, sojourner, sputnik};
          DirectAll(directing);
        }
    
        static void DirectAll(IDirectable[] direct) //initially stated Rover[] rove
        {
          foreach (IDirectable d in direct)
          {
            Console.WriteLine(d.GetInfo());
            Console.WriteLine(d.Explore());
            Console.WriteLine(d.Collect());
            Console.WriteLine("-------------");
          }
            
        }
    }
}
