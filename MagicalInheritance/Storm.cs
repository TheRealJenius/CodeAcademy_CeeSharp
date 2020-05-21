// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm
  {
    public string Essence{get; private set;} // these three have a public getter and private setter
    public bool IsStrong{get; private set;}
    public string Caster{get; private set;}

    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }
    
    public string Announce()
    {
      string power; //based off IsStrong
      if (IsStrong is true){power = "strong";}
      else{power = "weak";}
      return $"{Caster} just cast a {power} {Essence} storm";
    }

  }
}
