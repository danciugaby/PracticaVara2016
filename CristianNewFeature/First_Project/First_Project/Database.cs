using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Database
    {
        #region members

        public List<Employee> ListOfEmployees = new List<Employee>();
        
        #endregion

        #region constructors

        public Database()
        {

        }

        public Database(List<Employee> list)
        {
            ListOfEmployees = list;
        }

        #endregion

        #region functions 
 
        public void Print()
        {
            foreach (Employee e in this.ListOfEmployees)
            {
                e.Print();
            }
        }
        #endregion

    }
}
