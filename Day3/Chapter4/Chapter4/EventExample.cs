using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public delegate void PriceChangedHandler(decimal oldPrice,
    decimal newPrice);

    class EventExample
    {
        public static  void MyHandler(decimal oldPrice,
            decimal newPrice)
        {
            //here we can treat price change
            Console.WriteLine(oldPrice);
            Console.WriteLine(newPrice);
        }

    }
}
