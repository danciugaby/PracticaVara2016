using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Employee : Person
    {
        int employee_number{ get; set; }
        int salary { get; set; }
        bool hired { get; set; }

        public Employee() : base()
        {
            employee_number = 1;
            salary = 1000;
            hired = true;
        }

        public Employee(string f_name, string l_name, int employee_no, int s, bool h) : base(f_name, l_name)
        {
            if (employee_no > 0)
                employee_number = employee_no;
            else employee_number = 1;

            if (s > 0)
                salary = s;
            else salary = 1000;

            hired = h;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("First name: " + first_name + ", last name:" + last_name + 
                              ", Number: " + employee_number + ", Salary: " + salary + ", Hired?: " + hired);
        }
    }
}
