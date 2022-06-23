using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    class Dish : CompositeFood
    {
        private List<Food> ingredients = new List<Food>();

        public override void add(Food food)
            => ingredients.Add(food);
        public override void remove(Food food)
            => ingredients.Remove(food);
        public override int getCalorie()
           => ingredients.Sum(e => e.getCalorie());
    }
}
