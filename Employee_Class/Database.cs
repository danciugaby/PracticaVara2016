using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    public delegate void newEmpolyeeDelegate(Employee newEmployee);
    class Database
    {
        #region Members
        protected List<Employee> Members;
        #endregion
        #region Constructors
        public Database()
        {
            Members = new List<Employee>();
            /* for (int i = 0; i < 5; i++)
              {

                  string fname, lname;
                  fname = "josh";
                  lname = "vladimir";
                  Employee newEmp = new Employee(fname, lname);
                  Members.Add(newEmp);
              }*/
              //to do:Add new functions that ads employees
        }
        #endregion
        #region Events
        
        #endregion
        #region Methods
        public virtual void DisplayMembers()
        {
            foreach(Employee e in Members)
            {
                e.display();
            }
        }
        public  void AddNewEmployee(Employee newEmployee=null)
        {
            if (newEmployee == null)
            {
                string fname, lname;
                fname = "josh";
                lname = "vladimir";
                Employee employee = new Employee(fname, lname);
                Members.Add(employee);
            }
            else
                Members.Add(newEmployee);
        }
        public void NewEmployeeDelegate(Employee e)
        {
            newEmpolyeeDelegate newEmpD = AddNewEmployee;
            newEmpD(e);
        }
        public void OnNewEmployee(Employee source,EventArgs args)
        {
            
            Members.Add(source);
        }

        private void Source_EmployeeInstanced(Employee source, EventArgs args)
        {
            source.Hire();
        }
        #endregion
    }
}
