using System;

namespace Mediator
{
    class Boiler : HouseComponent
    {
        private int setting;

        public Boiler(SmartHomeSystem mediator) : base(mediator) { }

        public void setTemperature(int temperature)
            => setting = temperature;

        public void autoRun(int currTemperature)
        {
            Console.WriteLine($"현재 온도: {currTemperature}, 설정 온도: {setting}");

            if (setting > currTemperature)
                on();
            else
                off();
        }

        public void on()
            => Console.WriteLine("보일러: On");

        public void off()
            => Console.WriteLine("보일러: Off");
    }
}
