namespace Prototype
{
    class Land : Tile
    {
        public Land() : base() { }
        private Land(Land other) : base(other) { }
        public override object Clone()
            => new Land(this);

        public override string ToString()
            => nameof(Land) + "(" + base.ToString() + ")";
    }
}
