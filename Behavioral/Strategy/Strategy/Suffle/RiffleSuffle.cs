using System.Collections.Generic;

namespace Strategy
{
    class RiffleSuffle<T> : Suffle<T>
    {
        public List<T> suffle(List<T> list)
        {
            List<T> suffled = new List<T>(list.Count);
            int i = (list.Count + 1) / 2 - 1, j = list.Count - 1;

            for (int k = 0; k < (list.Count + 1) / 2; ++k)
            {
                suffled.Add(list[i--]);
                if (suffled.Count == list.Count) break;
                suffled.Add(list[j--]);
            }

            return suffled;
        }
    }
}
