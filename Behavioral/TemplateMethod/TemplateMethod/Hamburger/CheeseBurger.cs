using System;

namespace TemplateMethod
{
    class CheeseBurger : Hamburger
    {
        protected override void addPatty()
            => Console.WriteLine("고기 패티 추가");

        protected override void addSource()
             => Console.WriteLine("케첩 추가");

        protected override void addToping()
             => Console.WriteLine("치즈 추가");
    }
}
