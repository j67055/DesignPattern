namespace Mediator
{
    abstract class HouseComponent
    {
        private SmartHomeSystem mediator;

        protected HouseComponent(SmartHomeSystem mediator)
            => this.mediator = mediator;

        public void changed()
            => mediator.componentChanged(this);
    }
}
