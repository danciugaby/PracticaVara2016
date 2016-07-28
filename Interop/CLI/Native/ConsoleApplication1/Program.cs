using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Bridge.ClassDotNet caller = new Bridge.ClassDotNet();
                List<Bridge.MyPoint> inputs = new List<Bridge.MyPoint>();
                inputs.Add(new Bridge.MyPoint(1, 1));
                inputs.Add(new Bridge.MyPoint(2, 2));
                List<Bridge.MyPoint> results = caller.DoubleArray(inputs);
            }
        }
    }
}
