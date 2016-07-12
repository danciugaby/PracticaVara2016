using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person, IComparable
    {
        public Employee()
        {
            Name = "Dummy";
            Firstname = "Dorel";
        }
        public Employee(string name, string firstname)
        {
            Name = name;
            Firstname = firstname;
        }
        public override string ToString()
        {
            return Name + " " + Firstname;
        }
      

        int IComparable.CompareTo(Object other)
        {

            if (((Employee)other).Name == this.Name)
            {
                return ((Employee)other).Firstname.CompareTo(this.Firstname);
            }
            else
                return ((Employee)other).Name.CompareTo(this.Name);
        }
    } 
}
