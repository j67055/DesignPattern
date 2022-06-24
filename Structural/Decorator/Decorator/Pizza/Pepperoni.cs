namespace Decorator
{
    class Pepperoni : PizzaDecorator
    {
        private int count;

        public Pepperoni(Pizza component, int count) : base(component)
            => this.count = count;

        public override string getDescription()
            => base.getDescription() + " 페페로니(" + count.ToString() + "개)";
    }
}
