using System;
using System.Collections.Generic;

namespace Strategy
{
    class RandomSufle<T> : Suffle<T>
    {
        public List<T> suffle(List<T> list)
        {
            Random random = new Random();

            for (int i = 0; i < list.Count; ++i)
            {
                int randomIndex = random.Next(list.Count);
                (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
            }

            return list;
        }
    }
}
