using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Collections;
using Academy.Collections.Generic;
namespace SearchAlgorithmsLib
{
    abstract class PrioritySearcher<T>: Searcher<T>
    {
        PriorityQueue<State<T>> openList;

        public PrioritySearcher(int capacity, IComparer<State<T>>comparer)
        {
            this.openList = new PriorityQueue<State<T>>(capacity, comparer);
        }


        protected State<T> PopOpenList()
        {
            IncreaseNodesEvaluated();
            return openList.Dequeue();
        }

        protected void AdjustPriorityForState(State<T> currentState)///check if works and fix if not.
        {
            IEnumerator<State<T>> enumerator = openList.GetEnumerator();
            while (!enumerator.Equals(currentState))
            {
                enumerator.MoveNext();
            }

        }
    }
}
