using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    class Meal : CompositeFood
    {
        private List<Food> dishes = new List<Food>();

        public override void add(Food food)
            => dishes.Add(food);
        public override void remove(Food food)
            => dishes.Remove(food);
        public override int getCalorie()
           => dishes.Sum(e => e.getCalorie());
    }
}
