using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{


    class Program
    {
        static void Main(string[] args)
        {
            Int32 ii = 1;
            Int32 jj = 2;
            String s= String.Format("dsadas {1} dsajhjd {0}", ii, jj);
            
            for (int i = 0; i < 2; i++)
            {
                
           
                Point p1 = new Point(1, 1);
                Point p2 = new Point(p1); //am un p2vechi
                p2 = null;
                p1.X = -3;
                p2 = p1; //care se pierde aici
                //p2.X = 2;
                GC.Collect();
            }
            Console.WriteLine(FeetToInches(30)); 
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
