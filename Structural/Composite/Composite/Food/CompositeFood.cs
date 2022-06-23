namespace Composite
{
    abstract class CompositeFood : Food
    {
        public abstract void add(Food food);
        public abstract void remove(Food food);
        public abstract int getCalorie();
    }
}
