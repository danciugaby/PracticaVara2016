using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        private string name;
        #region SetSiGet
        
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        #endregion
        #region Constructor
        public Person(string a)
        {
            name = a;
        }
        public Person()
        {
            name = "--";
        }
        #endregion
    }
}
