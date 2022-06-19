using System;

namespace Prototype
{
    abstract class Tile : ICloneable
    {
        private TileShape shape;

        protected Tile()
            => this.shape = default(TileShape);
        protected Tile(Tile other)
            => shape = other.shape;

        public void setShape(TileShape shape)
            => this.shape = shape;

        public abstract object Clone();

        public override string ToString()
            => shape.ToString();
    }
}
