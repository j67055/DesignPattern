namespace Mediator
{
    class Doorbell : HouseComponent
    {
        public Doorbell(SmartHomeSystem mediator) : base(mediator) { }
        public void push()
            => changed();
    }
}
