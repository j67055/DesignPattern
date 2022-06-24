namespace Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        private Pizza component;

        protected PizzaDecorator(Pizza component)
            => this.component = component;

        public virtual string getDescription()
            => component.getDescription();
    }
}
