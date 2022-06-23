using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Meal breakfast = new Meal();
            Dish bread = new Dish();
            bread.add(new Flour());
            Dish bacon = new Dish();
            bacon.add(new Pork());
            breakfast.add(bread);
            breakfast.add(bacon);
            Console.WriteLine("아침 식사: " + breakfast.getCalorie().ToString() + " kcal");

            Meal dinner = new Meal();
            Dish steak = new Dish();
            steak.add(new Pork());
            steak.add(new Pork());
            Dish pasta = new Dish();
            pasta.add(new Tomato());
            pasta.add(new Flour());
            dinner.add(steak);
            dinner.add(pasta);
            Console.WriteLine("저녁 식사: " + dinner.getCalorie().ToString() + " kcal");
        }
    }
}
