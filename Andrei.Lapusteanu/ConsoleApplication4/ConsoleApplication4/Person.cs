using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Person
    {
        #region Members
        
        protected string first_name;
        protected string last_name;
        #endregion


        #region Constructors
 
        //implicit constructor
        public Person()
        {
            first_name = "Will";
            last_name = "Smith";
        }

        public Person(string f_name, string l_name)
        {
            First_Name = f_name;
            Last_Name = l_name;
        }
        #endregion


        #region Getters and Setters
     
        public string First_Name
        {
            get { return first_name; }

            set
            {
                if (first_name != "")
                    first_name = value;
                else first_name = "Will";
            }
        }

        public string Last_Name
        {
            get { return last_name; }

            set
            {
                if (last_name != "")
                    last_name = value;
                else last_name = "Smith";
            }
        }
        #endregion


        #region Methods
        
        virtual public void DisplayInfo()
        {
            Console.WriteLine("First name: " + first_name + ", Last name: " + last_name);
        }
        #endregion
    }
}
