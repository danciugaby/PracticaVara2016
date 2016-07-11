using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    
    public class Employee : Person 
    {
        #region Delegates And Events
        public delegate void newEmployeeEventHandler(Employee source,EventArgs args);
        public event newEmployeeEventHandler EmployeeInstanced;
        #endregion
        #region Members
        private const int DefaultSalary = 30000;
        private int Salary, EmployeeNumber;
        private bool Hired;
        #endregion
        #region Constructors
        public Employee(string fname,string lname,int sal=DefaultSalary,int empNum=-1,bool hire=false) : base(fname, lname)
        {
            if (Hired == false)
                Salary = 0;
            else
                Salary = sal;
            EmployeeNumber = empNum;
            Hired = hire;
            EmployeeInstanced += Source_EmployeeInstanced;
            OnNewEmployee();
        }

        private void Source_EmployeeInstanced(Employee source, EventArgs args)
        {
            Hire();
        }

        public Employee()
        {
        }
        #endregion
        #region Properties
        public int accessEmpNum
        {
            get { return EmployeeNumber; }
            set { EmployeeNumber = value; }
        }
        public bool  accessHire
        {
            get { return Hired; }
            set { Hired = value; }
        }
        public int accessSalary
        {
            get { return Salary; }
            set { Salary = value; }//valdiations
        }
        #endregion
        #region Methods
        public void RaiseSalary(int Raise=2000)
        {
            Salary = Salary + Raise;//validations
        }
        public void DemoteSalary(int Demote=2000)
        {
            Salary = Salary - Demote;
        }
        public void Hire()
        {
            Hired = true;
        }
        public void Fire()
        {
            Hired = false;
        }
        public void display()
        {
            Console.WriteLine($"First Name:{accesFName}");
            Console.WriteLine($"Last Name:{accesLName}");
            Console.WriteLine($"Saalry:{Salary}");
            Console.WriteLine($"Phone Number:{EmployeeNumber}");
            if (Hired == true)
                Console.WriteLine("The person is an employee");
            else
                Console.WriteLine("The person is not an employee");
        }
        protected virtual void OnNewEmployee()
        {
            if (EmployeeInstanced != null)
                EmployeeInstanced(this, EventArgs.Empty);
        }
        #endregion
    }
}
