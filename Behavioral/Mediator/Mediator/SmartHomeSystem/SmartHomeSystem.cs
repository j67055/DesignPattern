namespace Mediator
{
    class SmartHomeSystem
    {
        private Speaker speaker;
        private Doorbell doorbell;
        private Thermometer thermometer;
        private Boiler boiler;

        public SmartHomeSystem()
        {
            speaker = new Speaker(this);
            doorbell = new Doorbell(this);
            thermometer = new Thermometer(this);
            boiler = new Boiler(this);
        }

        public void componentChanged(HouseComponent component)
        {
            if (component is Doorbell)
                speaker.play("스피커: 초인종 벨소리");
            else if(component is Thermometer)
                boiler.autoRun(thermometer.Temperature);
        }

        public void pushDoorbell()
            => doorbell.push();

        public void setBoilerTemperature(int temperature)
            => boiler.setTemperature(temperature);

        public void measureTemperature(int currTemperature)
            => thermometer.measure(currTemperature);
    }
}
