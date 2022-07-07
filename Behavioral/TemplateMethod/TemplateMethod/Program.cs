using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburger cheeseBurger = new CheeseBurger();
            Hamburger chickenBurger = new ChickenBurger();

            Console.WriteLine("================치즈버거 만들기================");
            cheeseBurger.make();
            Console.WriteLine("================================================\n");

            Console.WriteLine("================치킨버거 만들기================");
            chickenBurger.make();
            Console.WriteLine("================================================\n");
        }
    }
}
