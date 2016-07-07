using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e1 = new Employee("Mihai","Petre",2000, 23);
            
            
            List <Employee> ListOfEmployees= new List<Employee>();

            ListOfEmployees.Add(e1);
            ListOfEmployees.Add(new Employee("Andrei", "Mihalache", 1600, 26));
            ListOfEmployees.Add(new Employee("Alexandra", "Marin", 2000, 24));

           
            Database database = new Database(ListOfEmployees);

            database.Print();

            foreach(Employee e in database.ListOfEmployees)
            {
                e.DecreasedSalary(300);
            }

            database.Print();

        }
    }
}
