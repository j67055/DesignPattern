namespace Decorator
{
    class Olive : PizzaDecorator
    {
        private int count;

        public Olive(Pizza component, int count) : base(component)
            => this.count = count;

        public override string getDescription()
            => base.getDescription() + " 올리브(" + count.ToString() + "개)";
    }
}
