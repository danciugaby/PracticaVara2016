using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee a=new Employee("Aristotel","Agapie");
            Console.WriteLine(a.accesFName);
            Database Data = new Database();
            Employee e = new Employee("daniel","mirel");
            Data.AddNewEmployee(a);
            Data.AddNewEmployee(e);
            e = new Employee("Mihai", "Stefan");
            Data.DisplayMembers();
        }
        class EmployeeEventArgs :EventArgs
        {

        }
    }
}
