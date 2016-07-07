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
        #region Constante
        const int kMaxEmployees = 100;
        const int kFirstEmployeeNumber = 1000;
        #endregion

        #region Constructor
        public void CreateArray()
        {
            Employee e1 = new Employee();
            for (int i = 0; i < kMaxEmployees; i++)
            {
                mEmployees[i] = e1;
            }
        }
        public Database()
        {
            mNextSlot = 0;
            mNextEmployeeNumber = kFirstEmployeeNumber;
        }
        #endregion

        #region Functions
        public Employee addEmployee(string inFirstName, string inLastName)
        {
            Employee theEmployee = mEmployees[mNextSlot];
            mNextSlot++;
            theEmployee.setFirstName(inFirstName);
            theEmployee.setLastName(inLastName);
            theEmployee.SetEmployeeNumber(mNextEmployeeNumber);
            mNextEmployeeNumber++;
            theEmployee.hire();
            return theEmployee;
        }

        public Employee getEmployee(int inEmployeeNumber)
        {
            Employee e = new Employee();
            for (int i = 0; i < mNextSlot; i++)
            {
                if (mEmployees[i].getEmployeeNumber() == inEmployeeNumber)
                {
                    return mEmployees[i];
                }
                else
                    return e;
            } 
            return e;
        }
        public Employee getEmployee(string inFirstName, string inLastName)
        {
            Employee e = new Employee();
            for (int i = 0; i < mNextSlot; i++)
            {
                if (mEmployees[i].getFirstName() == inFirstName && mEmployees[i].getLastName() == inLastName)
                {
                    return mEmployees[i];
                }
                else
                    return e;
            }
            return e;
        }
        #endregion

        #region DisplayFunction
        public void displayAll()
        {
            for (int i = 0; i < mNextSlot; i++)
            {
                mEmployees[i].display();
            }
        }

        public void displayCurrent()
        {
            for (int i = 0; i < mNextSlot; i++)
            {
                if (mEmployees[i].isHired())
                {
                    mEmployees[i].display();
                }
            }
        }

        public void displayFormer()
        {
            for (int i = 0; i < mNextSlot; i++)
            {
                if (!mEmployees[i].isHired())
                {
                    mEmployees[i].display();
                }
            }
        }
        #endregion

        #region Members
        protected Employee[] mEmployees = new Employee[kMaxEmployees];
        protected int mNextSlot;
        protected int mNextEmployeeNumber;
        #endregion
    }
}
