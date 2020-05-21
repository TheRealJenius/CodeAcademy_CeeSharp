// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil
  {
    public string Title {get; private set;} // the name of the mage

    public Pupil(string title)
    {
      Title = title;
    }

    public Storm CastWindStorm() //return type is storm object (yes my mind was blown at this point, no pun inteded)
    {
      Storm tier1 = new Storm("wind", false, Title);
      return tier1;
    }
  }
}
