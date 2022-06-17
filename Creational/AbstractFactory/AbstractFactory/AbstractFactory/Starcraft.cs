using System;

namespace AbstractFactory
{
    class Starcraft
    {
        static void Main(string[] args)
        {
            Race Terran = CreateRace(new TerranFactory());
            Console.WriteLine(Terran.ToString());

            Race Protoss = CreateRace(new ProtossFactory());
            Console.WriteLine(Protoss.ToString());

            Race Zerg = CreateRace(new ZergFactory());
            Console.WriteLine(Zerg.ToString());
        }

        static Race CreateRace(RaceFactory factory)
        {
            Race race = factory.createRace();
            Worker worker = factory.createWorker();
            Unit unit = factory.createUnit();

            race.addWorker(worker);
            race.addUnit(unit);

            return race;
        }
    }
}
