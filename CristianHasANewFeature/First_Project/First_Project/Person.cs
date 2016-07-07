using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Person
    {
        #region members

        protected string first_name;
        protected string last_name;

        #endregion

        #region constructors

        public Person()
        {
            last_name = "";
            first_name = "";
        }

       public Person(string f,string l)
        {
            this.first_name = f;
            this.last_name = l;
        }

        #endregion

        #region functions 

       public string FirstNameProp
       {
           get
           {
               return first_name;

           }
           set
           {
               first_name = value;
           }
       }

       public string LastNameProp 
       {
           get
           {
               return last_name;
           }
           set
           {
               last_name = value;
           }
       }


        #endregion
    }
}
