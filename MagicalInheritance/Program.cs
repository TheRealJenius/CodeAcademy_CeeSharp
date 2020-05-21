using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm zul = new Storm("wind", false, "Zul'rajas");
            Pupil mez = new Pupil("Mezil-kree");
            Mage gul = new Mage("Gul'dan");
            Archmage niel = new Archmage("Nielas Aran");
            Console.WriteLine(zul.Announce());
            Console.WriteLine(mez.CastWindStorm().Announce());
            Console.WriteLine(gul.CastRainStorm().Announce());
            Console.WriteLine(niel.CastLightningStorm().Announce());
        }
    }
}
