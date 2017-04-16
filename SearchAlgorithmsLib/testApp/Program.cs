using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;
using Academy.Collections;
using Academy.Collections.Generic;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            State<string> a = new State<string>("a,1");
            a.CameFrom=null;
            a.Cost = 1;
            State<string> b = new State<string>("b,2");
            b.CameFrom = a;
            b.Cost = 2;
            State<string>c = new State<string>("c,3");
            c.CameFrom = b;
            c.Cost = 2;
            State<string> d  = new State<string>("d,4");
            d.CameFrom = c;
            d.Cost = 4;




            PriorityQueue<State<string>> queue = new PriorityQueue<State<string>>(5, new CostComperator<string>());
            queue.Enqueue(a);
            queue.Enqueue(c);
            queue.Enqueue(d);
            queue.Enqueue(b);

            State<string>[] array = new State<string>[queue.Count];
            int size = queue.Count;
           for(int i = 0; i < size; ++i)
            {
                array[i] = queue.Dequeue();
            }

           for(int i = 0; i < size; i++)
            {
                if (array[i].Equals(d))
                {
                    array[i].Cost = 0;
                    array[i].CameFrom = a;
                }
            }

           for(int i = 0;i< size; i++)
            {
                queue.Enqueue(array[i]);
            }
           
           
           
           /*
            IEnumerator<State<string>> enumerator = queue.GetEnumerator();
            enumerator.MoveNext();
            State<string> e = new State<string>("d,4");
            while (!enumerator.Current.Equals(e))
            {
                enumerator.MoveNext();
              
            }
            enumerator.Current.Cost = -1;
            enumerator.Dispose();

            IEnumerator<State<string>> enumerator1 = queue.GetEnumerator();
            enumerator1.MoveNext();
            while (!enumerator1.Current.Equals(e))
            {
                enumerator1.MoveNext();
            }



    */

        }
    }
}

       
       