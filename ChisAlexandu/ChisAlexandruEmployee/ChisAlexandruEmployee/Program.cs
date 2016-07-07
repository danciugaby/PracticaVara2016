using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisAlexandruEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Employee
            Employee e1=new Employee("Alexandru","Chis",1,800,true);
            e1.display();
            e1.promote();
            e1.display();
            e1.demote();
            e1.display();
            Console.Read();
            #endregion

            #region Test Databade
            Database db1 = new Database();
            db1.CreateArray();
            Employee emp1 = db1.addEmployee("Greg", "Wallis");
            emp1.fire();
            Employee emp2 = db1.addEmployee("Scott", "Kleper");
            emp2.SetSalary(1000);
            Employee emp3 = db1.addEmployee("Nick", "Solter");
            emp3.SetSalary(10000);
            emp3.promote();
            Console.WriteLine("All employees: \r\n");
            db1.displayAll();
            Console.WriteLine("\r\n");
            Console.WriteLine("Current employees: \r\n");
            db1.displayCurrent();
            Console.WriteLine("\r\n");
            Console.WriteLine("Former employees: \r\n");
            db1.displayFormer();
            Console.Read();
            #endregion
        }
    }
}
