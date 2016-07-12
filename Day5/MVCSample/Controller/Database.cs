using Entities;
using ModelWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Database 
    {
        IList<Employee> database;
        ModelManagerWrapper modelwrapper = new ModelManagerWrapper();
        public Database()
        {
            database = new MyList();
        }
       public bool Add(string name, string firstname)
        {
            Employee e = new Employee(name, firstname);
            database.Add(e);
            
            
            Array a=database.ToArray<Employee>();
            Array.Sort(a);
            return  modelwrapper.Add(e);
        } 
    }
   
}
