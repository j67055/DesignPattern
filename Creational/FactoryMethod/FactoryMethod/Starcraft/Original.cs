namespace FactoryMethod
{
    class Original : Starcraft
    {
        public Unit createUnit()
            => new OriginalUnit();
    }
}
