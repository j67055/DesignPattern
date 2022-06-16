namespace AbstractFactory
{
    internal class TerranFactory : RaceFactory
    {
        public override Race createRace()
            => new Terran();
        public override Worker createWorker()
            => new SCV();
        public override Unit createUnit()
            => new Marine();
    }
}
