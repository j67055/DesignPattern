using System;
using System.Collections.Generic;

namespace Observer
{
    class FireDetector : Subject
    {
        public bool IsActive { get; private set; }

        private List<Observer> observers = new List<Observer>();

        public void add(Observer observer)
            => observers.Add(observer);

        public void remove(Observer observer)
            => observers.Remove(observer);

        public void notify()
            => observers.ForEach(e => e.update(this));

        public void detecte(bool isOnFire)
        {
            if (isOnFire)
                Console.WriteLine("화재 감지");
            else
                Console.WriteLine("화재 감지 안됨");

            IsActive = isOnFire;
            notify();
        }
    }
}
