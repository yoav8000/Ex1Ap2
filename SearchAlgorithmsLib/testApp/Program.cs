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
            State<string> a = new State<string>("a,0");
            a.CameFrom=null;
            a.Cost = 0;
            State<string> b = new State<string>("a,1");
            b.CameFrom = a;
            a.Cost = 1;
            State<string>c = new State<string>("b,2");
            c.CameFrom = b;
            c.Cost = 2;
            State<string> d  = new State<string>("d,3");
            d.CameFrom = c;
            d.Cost = 4;

            PriorityQueue<State<string>> queue = new PriorityQueue<State<string>>(5, new CostComperator<string>());
            queue.Enqueue(a);
            queue.Enqueue(c);
            queue.Enqueue(d);
            queue.Enqueue(b);
           
           
            State<string> e = queue.Peek();







        }
    }
}
