using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WildBeast : Herbivore
    {
        //Here I specicify savanah
        public override void Eat(Grass h)
        {
            Console.WriteLine(this.GetType().Name +
 " graizes anually grass of type" + h.GetType().Name);
        }
    }
}
