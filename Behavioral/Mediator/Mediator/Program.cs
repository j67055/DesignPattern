namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem smartHomeSystem = new SmartHomeSystem();
            smartHomeSystem.pushDoorbell();
            smartHomeSystem.setBoilerTemperature(15);
            smartHomeSystem.measureTemperature(5);
            smartHomeSystem.measureTemperature(15);
        }
    }
}
