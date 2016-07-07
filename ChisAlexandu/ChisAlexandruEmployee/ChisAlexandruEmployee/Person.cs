using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Person
    {
        public Person(string FirstName,string LastName)
        {
            mFirstName = FirstName;
            mLastName = LastName;
        }
        public virtual void display()
        {
            Console.Write(mFirstName+" "+mLastName);
        }
        #region Members
        protected string mFirstName;
        protected string mLastName;
        #endregion
    }
}
