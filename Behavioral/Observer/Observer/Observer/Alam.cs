using System;

namespace Observer
{
    class Alam : Observer
    {
        private FireDetector fireDetector;

        public Alam(FireDetector fireDetector)
            => this.fireDetector = fireDetector;

        public void update(Subject subject)
        {
            if (subject != fireDetector) return;

            if (fireDetector.IsActive)
                on();
            else
                off();
        }

        public void on()
            => Console.WriteLine("\t화재 알람: On");

        public void off()
            => Console.WriteLine("\t화재 알람: Off");
    }
}
