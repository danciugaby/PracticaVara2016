using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeemanager
{
    public class Person
    {
        public Person(string name, string fname)
        {
            Name = name;
            Firstname = fname;
        }

        public string Name { get; set; }
        public string Firstname { get; set; }
    }
}
