namespace Memento
{
    class CharacterMemento
    {
        public string[] Buffs { get; private set; }

        public CharacterMemento(string[] buffs)
            => Buffs = buffs;
    }
}
