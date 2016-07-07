using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    public class Person
    {
        protected string firstName, lastName;
        #region Constructors
        public Person(string fname,string lname)
        {
            firstName = fname;
            lastName = lname;                
        }
        public Person()
        {

        }
        #endregion
        #region Proprerties
        public string accesFName
        {
            get{ return firstName;}
            set{firstName = value;}
        }

        public string  accesLName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion

    }
}
