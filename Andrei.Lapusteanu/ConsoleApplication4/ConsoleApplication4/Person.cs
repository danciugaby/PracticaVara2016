using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Person
    {
        protected string first_name  { get; set; }
        protected string last_name  { get; set; }

        public Person()
        {
            first_name = "Will";
            last_name = "Smith";
        }

        public Person(string f_name, string l_name)
        {
            first_name = f_name;
            last_name = l_name;
        }

        virtual public void DisplayInfo()
        {
            Console.WriteLine("First name: " + first_name + ", Last name: " + last_name);
        }
    }
}
