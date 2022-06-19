namespace Prototype
{
    class Mineral : Resource
    {
        public Mineral() : base() { }
        private Mineral(Mineral other) : base(other) { }

        public override object Clone()
            => new Mineral(this);

        public override string ToString()
            => "Mineral" + "(" + base.ToString() + ")";
    }
}
