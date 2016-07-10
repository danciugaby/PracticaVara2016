using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Employee:Person
    {
        #region Constructor
        public Employee()
        {
            mEmployeeNumber = 0;
            Salary=0;
            mHired = false;
        }
        public Employee(string FirstName, string LastName,int EmployeeNumber,int Salary,bool Hired): base(FirstName,LastName)
        {
            mEmployeeNumber = EmployeeNumber;
            mSalary = Salary;
            mHired = Hired;
        }
        #endregion

        #region Prop
        public int EmployeeNumber
        {
            get
            {
                return mEmployeeNumber;
            }
            set
            {
                mEmployeeNumber = EmployeeNumber;
            }

        }
        public bool isHired
        {
            get
            {
                return mHired;
            }
        }

        public int Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = Salary;
            }
        }
        #endregion

        #region Functions
        public void promote(int inRaiseAmount = 1000)
        {
            mSalary += inRaiseAmount;
        }
        public void demote(int inDemeritAmount = 1000)
        {
            mSalary -= inDemeritAmount;
        }
        public void hire()
        {
            mHired = true;
        }
        public void fire()
        {
            mHired = false;
        }
        public override void display()
        {
            Console.Write("First name: "+ FirstName + " Last name: " + LastName +" NumberID: "+ mEmployeeNumber+" Salary: "+ mSalary + " Hired " +mHired+ "\r\n");
        }
        #endregion

        #region Members
        private int mEmployeeNumber;
        private int mSalary;
        private bool mHired;
        #endregion
    }
}
