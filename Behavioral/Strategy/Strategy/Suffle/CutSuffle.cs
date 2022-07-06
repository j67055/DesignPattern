using System.Collections.Generic;

namespace Strategy
{
    class CutSuffle<T> : Suffle<T>
    {
        public List<T> suffle(List<T> list)
        {
            List<T> suffled = new List<T>(list.Count);
            int half = (list.Count + 1) / 2 - 1;

            for(int i = half + 1; i < list.Count; ++i )
                suffled.Add(list[i]);
            for (int i = 0; i <= half; ++i)
                suffled.Add(list[i]);

            return suffled;
        }
    }
}
