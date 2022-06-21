namespace AbstractFactory
{
    class Terran : Race
    {
        public override string ToString()
            => nameof(Zerg) + base.ToString();
    }
}
