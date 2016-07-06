using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda panda = new Panda();
            Panda she = new Panda();
            panda.Mate = she;
        }
    }
}
