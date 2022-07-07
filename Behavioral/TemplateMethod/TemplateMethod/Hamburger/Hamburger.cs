using System;

namespace TemplateMethod
{
    abstract class Hamburger
    {
        public void make()
        {
            setBread();
            addPatty();
            addSource();
            addToping();
        }

        protected virtual void setBread()
            => Console.WriteLine("빵 준비");

        protected abstract void addPatty();
        protected abstract void addSource();
        protected abstract void addToping();
    }
}
