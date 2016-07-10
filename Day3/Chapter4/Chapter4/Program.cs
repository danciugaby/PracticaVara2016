using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass d = new DelegateClass();
            d.ExampleACallOfDelegate();

            Util util = new Util();
            int[] vals = new int[3];
            vals[0] = 1;
            vals[1] = 2;
            vals[2] = 3;
            //first I will double all values
            util.Transform(ref vals,d.DoubleIt);
            //and then I'll pow it
            util.Transform(ref vals, d.Square);

            //now the real power of delegates:
            vals[0] = 1;
            vals[1] = 2;
            vals[2] = 3;
            Transformer t = d.Square;
            t += d.Square;
            t += d.DoubleIt;
            
            util.Transform(ref vals, t);
            //inside the constructor we subscribe to an event which is treated
            //in EventExample class
            EventHandler e  =new EventHandler("symbol");

            //this will trigger the raiseof the event
            e.Price = 10;
        }
    }
}
