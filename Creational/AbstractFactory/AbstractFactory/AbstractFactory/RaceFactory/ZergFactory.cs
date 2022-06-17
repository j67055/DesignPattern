namespace AbstractFactory
{
    class ZergFactory : RaceFactory
    {
        public override Race createRace()
            => new Zerg();
        public override Worker createWorker()
            => new Drone();
        public override Unit createUnit()
            => new Zergling();
    }
}
