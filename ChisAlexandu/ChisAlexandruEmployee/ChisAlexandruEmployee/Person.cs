using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Person
    {
        #region Constructor
        public Person()
        {
            mFirstName = " ";
            mLastName = " ";
        }
        public Person(string FirstName,string LastName)
        {
            mFirstName = FirstName;
            mLastName = LastName;
        }
        #endregion

        #region Prop
        public string FirstName 
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        #endregion

        #region Functions
        public virtual void display()
        {
            Console.Write(mFirstName+" "+mLastName);
        }
        #endregion

        #region Members
        private string mFirstName;
        private string mLastName;
        #endregion
    }
}
