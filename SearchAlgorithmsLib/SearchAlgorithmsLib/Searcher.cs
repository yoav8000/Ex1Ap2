using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
   public abstract class Searcher<T>:ISearcher<T>
    {
        protected int nodesEvaluated;

        public void IncreaseNodesEvaluated()
        {
            ++this.nodesEvaluated;
        }


        public int GetNumberOfNodesEvaluated()
        {
            return this.nodesEvaluated;
        }


        public Searcher()
        {
            nodesEvaluated = 0;
        }

        /// <summary>
        /// Backtraces the specified goal.
        /// </summary>
        /// <param name="goal">The goal.</param>
        /// <returns></returns>
        protected Solution<T> Backtrace(State<T> goal)
        {
            List<State<T>> pathToGoal = new List<State<T>>();
            pathToGoal.Add(goal);
            State<T> state = goal.CameFrom;
            while (state.CameFrom != null)
            {
                pathToGoal.Add(state);
                state = state.CameFrom;
            }
            return new Solution<T>(pathToGoal);
        }

        public abstract Solution<T> Search(ISearchable<T> searchable);



    }
}
