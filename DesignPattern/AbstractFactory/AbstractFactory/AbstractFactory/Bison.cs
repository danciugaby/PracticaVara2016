using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Bison : Herbivore
    {
        //Eats stepe
        //Has 1 tone
        public override void Eat(Grass h)
        {
            Console.WriteLine(this.GetType().Name +
    " graizes grass of type" + h.GetType().Name);
        }
    }
}
