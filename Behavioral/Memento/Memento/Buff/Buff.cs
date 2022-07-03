namespace Memento
{
    class Buff
    {
        private string name;

        public Buff(string name)
            => this.name = name;
        public override string ToString()
            => name;
    }
}
