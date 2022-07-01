using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate<string> inventory = new Inventory("체력 포션", "마나 포션", "롱 소드");
            Iterator<string> iterator = inventory.createIterator();

            for(; !iterator.isDone(); iterator.next())
                Console.WriteLine(iterator.Current);
        }
    }
}
