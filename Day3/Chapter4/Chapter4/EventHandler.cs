using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public class EventHandler
    {
        string symbol;
        decimal price;

        public EventHandler(string symbol)
        {
            this.symbol = symbol;

            PriceChanged += EventExample.MyHandler;
        }

        public event PriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return; // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null) // If invocation list not
                    PriceChanged(oldPrice, price); // empty, fire event.
            }
        }
    }
}
