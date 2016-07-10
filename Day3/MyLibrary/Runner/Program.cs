using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Functionality1;
using MyLibrary.Functionality2;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d = new Display();
            d.DisplayMessage("ceva");
            Transform t = new Transform();
            t.ChangeBehaviour(true);
        }
    }
}
