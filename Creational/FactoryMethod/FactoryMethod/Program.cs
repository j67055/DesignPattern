using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Starcraft original = new Original();
            Unit originalUnit = original.createUnit();
            Console.WriteLine(originalUnit.ToString());

            Starcraft broodWar = new BroodWar();
            Unit broodWarUnit = broodWar.createUnit();
            Console.WriteLine(broodWarUnit.ToString());
        }
    }
}
