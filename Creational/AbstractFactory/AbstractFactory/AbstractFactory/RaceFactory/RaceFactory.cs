namespace AbstractFactory
{
    abstract class RaceFactory
    {
        public abstract Race createRace();
        public abstract Worker createWorker();
        public abstract Unit createUnit();
    }
}
