using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    delegate int Transformer(int x);

    class DelegateClass
    {
        public int Square(int x)
        {
            return   x* x;
        }
        public int DoubleIt(int x)
        {
            return 2 * x;
        }

        public void ExampleACallOfDelegate()
        {
            Transformer t = Square;
            int result = t(3);
            Console.WriteLine(result); 
        }

       
    }
}
