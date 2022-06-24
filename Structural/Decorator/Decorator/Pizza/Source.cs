namespace Decorator
{
    class Source : PizzaDecorator
    {
        private string name;

        public Source(Pizza component, string name) : base(component)
            => this.name = name;

        public override string getDescription()
            => base.getDescription() + " " + name + "소스";
    }
}
