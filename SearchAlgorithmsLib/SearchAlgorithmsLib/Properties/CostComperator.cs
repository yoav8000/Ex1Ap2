using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib.Properties
{
    public class CostComperator<T>:Comparer<State<T>>
    {
        public override  int Compare(State<T> first, State<T> second)
        {
            return first.Cost.CompareTo(second.Cost);
        }
    }
}
