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

        #region Getter
        public string getFirstName()
        {
            return mFirstName;
        }
        public string getLastName()
        {
            return mLastName;
        }
        #endregion

        #region Setter
        public void setFirstName(string FirstName)
        {
            mFirstName = FirstName;
        }

        public void setLastName(string LastName)
        {
            mLastName = LastName;
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
