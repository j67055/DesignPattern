using System;

namespace Facade
{
    class Dice : Component
    {
        private Random random = new Random();

        public void set()
            => Console.WriteLine("주사위 준비");
        public int roll()
            =>  random.Next(1, 7);
        public void clear()
            => Console.WriteLine("주사위 정리");
    }
}
