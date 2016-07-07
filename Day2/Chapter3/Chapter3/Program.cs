using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        string a;

        public Program(string s)
        {
            a = s;
        }

        public override string ToString()
        {
            return a+a;
        }

        public override bool Equals(object obj)
        {
            Program pout = (Program) obj;
            int result = this.a.CompareTo(pout.a);
            return (result == 0) ? true : false;
            //return this.a == pout.a;
        }

        static void Main(string[] args)
        {

            Object o;
            Program p  = new Program("1"); 
            Program p1 = new Program("1"); 
            string s = p.ToString();
            string s1 = p1.ToString();
            bool val = p.Equals(p1);
           
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

            Nullable<String> n = new Nullable<String>();
            n.Value = "";
            Console.WriteLine(n.Value);

        }
    }
}
