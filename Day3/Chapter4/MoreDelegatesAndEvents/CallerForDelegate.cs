using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreDelegatesAndEvents
{
    public class Point
    {
        public Point()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public  class CallerForDelegate  
    {
        public static Point ATransformer(Point p)
        {
            Point anewpoint = p;
            anewpoint.X ++;
            anewpoint.Y ++;
            return anewpoint;
        }
    }
}
