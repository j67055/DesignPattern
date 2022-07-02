namespace Mediator
{
    class Thermometer : HouseComponent
    {
        public int Temperature { get; private set; }

        public Thermometer(SmartHomeSystem mediator) : base(mediator) { }

        public void measure(int currTemperature)
        {
            Temperature = currTemperature;
            changed();
        }
    }
}
