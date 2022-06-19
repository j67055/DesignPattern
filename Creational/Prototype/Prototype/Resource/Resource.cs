using System;

namespace Prototype
{

    abstract class Resource : ICloneable
    {
        private int value;

        protected Resource() { }
        protected Resource(Resource other)
            => value = other.value;

        public void setValue(int value)
            => this.value = value;

        public abstract object Clone();

        public override string ToString()
            => value.ToString();
    }
}
