namespace Prototype
{
    class Gas : Resource
    {
        public Gas() : base() { }
        private Gas(Gas other) : base(other) { }

        public override object Clone()
            => new Gas(this);
        public override string ToString()
            => "Gas" + "(" + base.ToString() + ")";
    }
}
