namespace AbstractFactory
{
    class ProtossFactory : RaceFactory
    {
        public override Race createRace()
            => new Protoss();
        public override Worker createWorker()
            => new Probe();
        public override Unit createUnit()
            => new Zealot();
    }
}
