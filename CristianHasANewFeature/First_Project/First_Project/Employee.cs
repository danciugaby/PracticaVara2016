using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Employee: Person
    {
        #region members

        int salary;
        int number;
        bool hired;

        #endregion

        #region constructors

        public Employee() : base()
        {
           
           salary=100;
           number=-1;
           hired = true;
        }

        public Employee(string f,string l,int s, int n) : base(f,l)
        {
            this.SalaryProp = s;
            this.EmployeeNumberProp = n;
            hired = true;
        }

        #endregion

        #region functions

        public int SalaryProp
        { 
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    this.salary = value;
                else this.salary = 0;
            }
        }
        
        public int EmployeeNumberProp
        {
            get
            {
                return number;
            }
            set
            {
                if (value > 0)
                    this.number = value;
                else this.number = 0;
            }
        }

        public string IsHired()
        {
            if (hired)
                return "Employed";
            else
                return "Former Employee";
        }

        public void Print()
        {
            Console.WriteLine("FULL NAME: "+this.FirstNameProp+" "+ this.LastNameProp);
            Console.WriteLine("EMPLOYEE NUMBER:" +this.EmployeeNumberProp);
            Console.WriteLine("SALARY:" +this.SalaryProp);
            Console.WriteLine("STATUS:" + IsHired()+"\n" );
        }

        public void RaisedSalary(int sum)
        {
            if(sum>0)
                this.SalaryProp += sum;
        }

        public void DecreasedSalary(int sum)
        {
            if (sum < SalaryProp && sum>0)
                this.SalaryProp -= sum;
            else
                this.SalaryProp = 0;
        }

        public void Fired()
        {
            this.hired = false;
        }
        #endregion
    }
}
