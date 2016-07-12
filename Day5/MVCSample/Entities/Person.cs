using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : IComparable<Person>
    {
        string name;
        string firstname;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        int IComparable<Person>.CompareTo(Person other)
        {
            if (other.Name == this.Name)
            {
                return other.Firstname.CompareTo(this.Firstname);
            }
            else
                return other.Name.CompareTo(this.Name);
        }
    }
}
