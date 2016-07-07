using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("ion", "Guster", 1233, 3440, true);
            Person p1 = new Person();
            Employee e2 = new Employee();

            e1.DisplayInfo();
            e2.DisplayInfo();
            //p1.DisplayInfo();
        }
    }

}
