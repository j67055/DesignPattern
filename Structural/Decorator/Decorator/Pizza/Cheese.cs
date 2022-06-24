namespace Decorator
{
    class Cheese : PizzaDecorator
    {
        private string name;

        public Cheese(Pizza component, string name) : base(component)
            => this.name = name;

        public override string getDescription()
            => base.getDescription() + " " + name;
    }
}
