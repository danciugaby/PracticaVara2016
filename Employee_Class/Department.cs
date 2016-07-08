using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Department : Database
    {
        #region Members
        private List<Database> Members = new List<Database>();
        #endregion
        #region Constructors
        public Department()
        {

        }
        #endregion
    }
}

