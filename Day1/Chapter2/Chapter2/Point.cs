using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{

   abstract class MyInterface
    {
        public abstract  void f();

       void ff()
       {
       }
    }
       class Point : MyInterface, IDisposable
    {
        #region members

        int y;
        private int x;

           public int X
           {
               get { return x; }
               set
               {
                   if (value >0)
                   x = value;
                   
               }
           }
        #endregion

        #region constructors

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region functions

        public override string ToString()
        {
           StringBuilder s = new StringBuilder();
           
            s.Append(x.ToString());
            s.Append( y.ToString());
            
            return s.ToString();
        }

        #region events
        #endregion

        #endregion

        void IDisposable.Dispose()
        {
            Console.WriteLine(x);
        }

        public override void f()
        {
           
        }
    }
}
