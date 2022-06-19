namespace Prototype
{
    class Ground : Tile
    {
        public Ground() : base() { }
        private Ground(Ground other) : base(other) { }
        public override object Clone()
            => new Ground(this);

        public override string ToString()
            => "Ground" + "(" + base.ToString() + ")";
    }
}
