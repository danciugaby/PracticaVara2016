using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee: Person
    {
        private string rank;
        private int stadiu;
        public List<Employee> employeeList = new List<Employee>();
        #region SetSiGet
        public string Rank 
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }
        public int Stadiu 
        {
            get
            {
                return stadiu;
            } 
            set
            {
                stadiu = value;
            }
        }
        #endregion
        #region Constructor
        public Employee(string a):base(a)
        {
            rank = "lucrator";
            stadiu = 0;
        }
        public Employee()
        {
            rank = "lucrator";
            stadiu = 0;
        }
        public Employee(Employee e)
        {
            Name = e.Name;
            rank = e.Rank;
            stadiu = e.Stadiu;
        }


        #endregion
        #region Functii

        public void add()
        {
            Stadiu = 1;
            employeeList.Add(new Employee(this));
        }
        public void fire()
        {
            foreach(Employee i in employeeList)
            {
                if (i.Name == this.Name) stadiu = 0;
            }
        }
        public void promovate()
        {
            if (rank == "lucrator") rank = "sef";
            if (rank == "sef") rank = "patron";
            if (rank == "patron") Console.WriteLine("\nNu mai poate fi avansat.");
        }
        public void employees()
        {
            Console.WriteLine("Angajatii(toti) sunt: ");
            foreach (Employee i in employeeList)
            {
                Console.Write(i.Name+" ");
            }
            
            Console.WriteLine();
        }
        public void currentemployees()
        {
            Console.WriteLine("Angajatii curenti sunt: ");
            foreach (Employee i in employeeList)
            {
                if(i.Stadiu==1) Console.Write(i.Name);
            }
            Console.WriteLine();
        }
        public void formeremployeers()
        {
            Console.WriteLine("Fostii angajatii sunt: ");
            foreach (Employee i in employeeList)
            {
                if (i.Stadiu == 0) Console.Write(i.Name);
            }
            Console.WriteLine();
        }
        #endregion
    }
}
