// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string title) : base(title) //since the argument has already been define it doesn't have to be defined again in base and can just be called
    {

    }

    public virtual Storm CastRainStorm()
    {
      return new Storm("rain", false, Title); //another way to return an object
    }


  }
}
