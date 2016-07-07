using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Employee : Person
    {
        #region Functions
        public Employee(string FirstName, string LastName, int EmployeeNumber, int Salary, bool Hired) : base(FirstName, LastName)
        {
            mEmployeeNumber = EmployeeNumber;
            mSalary = Salary;
            mHired = Hired;
        }
        #region MemberFunctions
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
            Console.Write("First name: " + mFirstName + " Last name: " + mLastName + " NumberID: " + mEmployeeNumber + " Salary: " + mSalary + " Hired " + mHired + "\r\n");
        }
        #endregion
        #endregion
        #region Members
        private int mEmployeeNumber;
        private int mSalary;
        private bool mHired;
        #endregion
    }
}
