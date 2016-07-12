using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
  public  class Database
    {
        private List<Employee> Members = new List<Employee>();
        public Database()
        {
            for (int i = 0; i < 5; i++)
            {
                string fname, lname;
                fname = "josh";
                lname = "vladimir";
                Employee newEmp = new Employee(fname, lname);
                Members.Add(newEmp);
            }
        }

        public List<Employee> accessDatabase
        {
            get
            {
                return Members;
            }

            set
            {
                Members = value;
            }
        }

        public void DisplayMembers()
        {
            foreach(Employee e in Members)
            {
                e.display();
            }
        }
    }
}
