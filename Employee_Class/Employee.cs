using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    public class Employee : Person 
    {
        #region Members
        private const int DefaultSalary = 30000;
        private int Salary;
        private string EmployeeNumber;
        private bool Hired;
        #endregion
        #region Constructors
        public Employee(string fname,string lname,string sal=null, string employeeNumber=null) : base(fname, lname)
        {
            if (sal == null)
                Salary = DefaultSalary;
            else
                Salary = Int32.Parse(sal);
            EmployeeNumber = employeeNumber;
            Hired = true;
        }
        public Employee()
        {

        }
        #endregion
        #region Properties
        public string accessEmpNum
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
            set { Salary = value; }
        }
        #endregion
        #region Methods
        public void RaiseSalary(int Raise=2000)
        {
            Salary = Salary + Raise;
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
            Console.WriteLine(accesFName);
            Console.WriteLine(accesLName);
            Console.WriteLine(Salary);
            Console.WriteLine(EmployeeNumber);
            if (Hired == true)
                Console.WriteLine("The person is an employee");
            else
                Console.WriteLine("The person is not an employee");
        }
        #endregion
    }
}
