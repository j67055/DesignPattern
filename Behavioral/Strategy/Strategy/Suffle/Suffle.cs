using System.Collections.Generic;

namespace Strategy
{
    interface Suffle<T>
    {
        List<T> suffle(List<T> list);
    }
}
