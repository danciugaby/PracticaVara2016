using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ChisAlexandruEmployee
{

    class Database
    {
        #region Constant
        const int kMaxEmployees = 100;
        const int kFirstEmployeeNumber = 1000;
        #endregion

        #region Constructor
        public Database()
        {
            mEmployees = new List<Employee>();
        }
        #endregion

        #region Functions
        public Employee addEmployee(string inFirstName, string inLastName)
        {
            Employee theEmployee = new Employee();
            theEmployee.FirstName=inFirstName;
            theEmployee.LastName=inLastName;
            theEmployee.EmployeeNumber=mEmployees.Count;
           
            theEmployee.hire();
            mEmployees.Add(theEmployee);
            return theEmployee;
        }

        public Employee getEmployee(int inEmployeeNumber)
        {
            if (inEmployeeNumber < mEmployees.Count)
                return mEmployees[inEmployeeNumber];
            else
                return null;
        }
        public Employee getEmployee(string inFirstName, string inLastName)
        {
            Employee e = new Employee();
            for (int i = 0; i < mEmployees.Count ; i++)
            {
                if (mEmployees[i].FirstName == inFirstName && mEmployees[i].LastName == inLastName)
                {
                    return mEmployees[i];
                }            
            }
            return e;
        }
        #endregion

        #region DisplayFunction
        public void displayAll()
        {
            foreach (Employee e in mEmployees)
            {
               e.display();
            }
        }

        public void displayCurrent()
        {
            foreach (Employee e in mEmployees)
            {
                if (e.isHired)
                {
                    e.display();
                }
            }
        }

        public void displayFormer()
        {
            foreach (Employee e in mEmployees)
            {
                if (!e.isHired)
                {
                    e.display();
                }
            }
        }
        #endregion

        #region Members
        protected List<Employee> mEmployees;
        #endregion
    }
}
