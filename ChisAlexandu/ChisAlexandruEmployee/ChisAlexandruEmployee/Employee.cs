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
            setFirstName(" ");
            setLastName(" ");
            mEmployeeNumber = 0;
            SetSalary(0);
            mHired = false;
        }
        public Employee(string FirstName, string LastName,int EmployeeNumber,int Salary,bool Hired): base(FirstName,LastName)
        {
            mEmployeeNumber = EmployeeNumber;
            mSalary = Salary;
            mHired = Hired;
        }
        #endregion

        #region Getters
        public int getEmployeeNumber()
        {
            return mEmployeeNumber;
        }
        public bool isHired()
        {
            return mHired;
        }
        #endregion

        #region Setters
        public void SetEmployeeNumber(int EmployeeNumber)
        {
            mEmployeeNumber = EmployeeNumber;
        }

        public void SetSalary(int Salary)
        {
            mSalary = Salary;
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
            Console.Write("First name: "+ getFirstName() + " Last name: " + getLastName() +" NumberID: "+ mEmployeeNumber+" Salary: "+ mSalary + " Hired " +mHired+ "\r\n");
        }
        #endregion

        #region Members
        private int mEmployeeNumber;
        private int mSalary;
        private bool mHired;
        #endregion
    }
}
