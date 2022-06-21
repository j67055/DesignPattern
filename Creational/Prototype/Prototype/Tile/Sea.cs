namespace Prototype
{
    class Sea : Tile
    {
        public Sea() : base() { }
        private Sea(Sea other) : base(other) { }

        public override object Clone()
            => new Sea(this);
        public override string ToString()
            => nameof(Sea) + "(" + base.ToString() + ")";
    }
}
