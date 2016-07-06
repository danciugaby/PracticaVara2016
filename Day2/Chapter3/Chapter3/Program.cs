using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda panda = new Panda();
            Panda she = new Panda();
            panda.Mate = she;

            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            var x = stack.Pop(); // x is 10
            var y = stack.Pop();

            var stackd = new Stack<double>();
            stackd.Push(5.0);
            stackd.Push(10.0);
            var xx = stackd.Pop(); // x is 10
            var yy = stackd.Pop(); 
        }
    }
}
