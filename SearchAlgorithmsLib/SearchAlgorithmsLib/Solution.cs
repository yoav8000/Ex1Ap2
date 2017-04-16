using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    public class Solution<T>
    {
        private List<State<T>> pathToDestination;

        public Solution(List<State<T>> path)
        {
            this.pathToDestination = path;
        }

        public List<State<T>> PathToDestination
        {
            get
            {
                return this.pathToDestination;
            }
        }

    }
}
