namespace FactoryMethod
{
    class BroodWar :Starcraft
    {
        public Unit createUnit()
            => new BroodWarUnit();
    }
}
