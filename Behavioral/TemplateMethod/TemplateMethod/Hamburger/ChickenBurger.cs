using System;

namespace TemplateMethod
{
    class ChickenBurger : Hamburger
    {
        protected override void setBread()
            => Console.WriteLine("치킨버거 용 빵 준비");

        protected override void addPatty()
            => Console.WriteLine("치킨 패티 추가");

        protected override void addSource()
             => Console.WriteLine("치킨 양념 추가");

        protected override void addToping()
             => Console.WriteLine("양상추 추가");
    }
}
