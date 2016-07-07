using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Alexandru", "Chis", 1, 800, true);
            e1.display();
            e1.promote();
            e1.display();
            e1.demote();
            e1.display();
            Console.Read();
            //comentariu
        }
    }
}
