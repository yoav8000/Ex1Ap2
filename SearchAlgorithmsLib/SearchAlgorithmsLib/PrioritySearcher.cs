using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Collections;
using Academy.Collections.Generic;
namespace SearchAlgorithmsLib
{
    public abstract class PrioritySearcher<T>: Searcher<T>
    {
       private PriorityQueue<State<T>> openList;


        public PrioritySearcher(int capacity, IComparer<State<T>>comparer)
        {
            this.openList = new PriorityQueue<State<T>>(capacity, comparer);
        }
        public PriorityQueue<State<T>> OpenList
        {
            get;
            set;
        }

        public int OpenListSize
        {
            get
            {
                return openList.Count;
            }
        }

        protected State<T> PopOpenList()
        {
            IncreaseNodesEvaluated();
            return openList.Dequeue();
        }
        
        protected void AdjustPriorityForState( State<T> currentSuccessor, State<T> currentState, double newCost)///check if works and fix if not.
        {
            IEnumerator<State<T>> enumerator = openList.GetEnumerator();
            enumerator.MoveNext();
            bool hasNext = true;
            while (!enumerator.Current.Equals(currentSuccessor)&&(hasNext))
            {
                hasNext = enumerator.MoveNext();
            }
            if (!hasNext)
            {
                return;
            }

            if(enumerator.Current.Cost > newCost)
            {
                currentSuccessor.CameFrom = currentState;
                currentSuccessor.Cost = newCost;
            }
        }
    }
}
