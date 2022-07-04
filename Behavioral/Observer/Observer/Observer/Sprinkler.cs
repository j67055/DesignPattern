using System;

namespace Observer
{
    class Sprinkler : Observer
    {
        private FireDetector fireDetector;

        public Sprinkler(FireDetector fireDetector)
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
            => Console.WriteLine("\t스프링클러: On");

        public void off()
            => Console.WriteLine("\t스프링클러: Off");

    }
}
