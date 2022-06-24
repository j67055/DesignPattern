using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pepperoniPizza = new Pepperoni(new Cheese(new Source(new Dough(), "토마토"), "모차렐라치즈"), 15);
            Pizza combinationPizza = new Olive(new Pepperoni(new Cheese(new Source(new Dough(), "토마토"), "모차렐라치즈"), 5), 5);

            Console.WriteLine(pepperoniPizza.getDescription());
            Console.WriteLine(combinationPizza.getDescription());
        }
    }
}
