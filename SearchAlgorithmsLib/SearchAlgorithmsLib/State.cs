using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithmsLib
{
    class State<T> : IComparable<T>
    {
        private double cost;
        private State<T> cameFrom;
        private T stateIdentifier;
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value can not be negative");
                }
            }
        }

        public State<T> CameFrom
        {
            get
            {
                return cameFrom;
            }
            set
            {
                this.cameFrom = value;
            }
        }

        public T StateIdentifier
        {
            get
            {
                return this.stateIdentifier;
            }
        }



        public State(double cost, State<T> cameFrom)
        {
            this.cost = cost;
            this.CameFrom = cameFrom;
        }

        public State()
        {
            this.cost = 0;
            this.CameFrom = null;
        }

        public override int GetHashCode()
        {
            return String.Intern(this.stateIdentifier.ToString()).GetHashCode();
        }


        public bool Equals(State<T> other)
        {
            return this.stateIdentifier.Equals(other.StateIdentifier);
           
        }

        public override bool Equals(object obj)////check if works fine.
        {
            if(obj.GetType() == typeof(State<T>))
            {
                return this.Equals(obj as State<T>);
            }

            return false;
        }



    }
}
