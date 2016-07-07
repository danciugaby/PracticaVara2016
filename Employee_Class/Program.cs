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
            Data.DisplayMembers();
            

        }




































    }
}
