using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Employee : Person
    {
        #region Members

        const int baseSalary = 1200;
       
        int employee_number;
        int salary;
        bool hired;
        #endregion


        #region Constructors

        //inplicit constructor
        public Employee()
        {
            employee_number = -1;
            salary = baseSalary;
            hired = true;
        }

        public Employee(string f_name, string l_name, int employee_no, int s, bool h) : base(f_name, l_name)
        { 
            //For data to be validated when instantiating an object,
            //The object property (the setters) must be called,
            //Not the members 
            
            Employee_Number = employee_no;
            Salary = s;
            Hired = h;
        }
        #endregion


        #region Getters and Setters
     
        public int Employee_Number
        {
            get { return employee_number; }

            set
            {
                if (value > 0)
                    employee_number = value;
                else employee_number = 1;
            }
        }

        public int Salary
        {
            get { return salary; }

            set
            {
                if (value >= 0)
                    salary = value;
                else salary = baseSalary;
            }
        }

        public bool Hired
        {
            get { return hired; }

            set { hired = value; }
        }
        #endregion


        #region Methods

        public override void DisplayInfo()
        {
            Console.WriteLine("First name: " + first_name + ", last name:" + last_name + 
                              ", Number: " + employee_number + ", Salary: " + salary + ", Hired?: " + hired);
        }

        public void Promote(int RaiseAmount)
        {
            salary = salary + RaiseAmount;
        }

        public void Demote (int DemeritAmount)
        {
            if (salary - DemeritAmount >= 0)
                salary = salary - DemeritAmount;
            else
            {
                salary = 0;
                Console.WriteLine("You have demerited more than the employee's salary. Salary is will be set to 0");
            }
        }

        public void Hire()
        {
            hired = true;
        }

        public void Fire()
        {
            hired = false;
        }
        #endregion
    }
}
