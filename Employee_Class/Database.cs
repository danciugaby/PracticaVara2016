using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Database
    {
        #region Members
        private List<Employee> Members = new List<Employee>();
        #endregion
        #region Constructors
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
        #endregion
        #region Methods
        public void DisplayMembers()
        {
            foreach(Employee e in Members)
            {
                e.display();
            }
        }
        #endregion
    }
}
