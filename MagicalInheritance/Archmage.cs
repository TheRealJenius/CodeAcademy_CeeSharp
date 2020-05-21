// Archmage.cs
using System;

namespace MagicalInheritance
{
 class Archmage : Mage //remember that you can only inherit once, that's why class Archmage : Pupil, Mage causes an error - think of a tree diagram/cascading style
 {
   public Archmage(string title) : base (title)
   {
     
   }

   public override Storm CastRainStorm()
   {
     return new Storm("rain", true, Title);
   }

   public Storm CastLightningStorm()
   {
     return new Storm ("lightning", true, Title);
   }
 }
}
