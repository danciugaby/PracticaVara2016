using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    public class Menu
    {
        Employee e=new Employee();
        public void firstMenu()
        {
            Console.WriteLine("1.Adauga angajat");
            Console.WriteLine("2.Concediaza angajat");
            Console.WriteLine("3.Promoveaza angajat");
            Console.WriteLine("4.Lista angajati(istoric)");
            Console.WriteLine("5.Lista angajati curenti");
            Console.WriteLine("6.Lista fosti angajati");
            Console.WriteLine("Introduce optiunea:");
            option();

        }
        public void option()
        {
            
            var a=Console.ReadLine();
            var x=Int32.Parse(a);
            if (x == 1) m1();
            else
                if (x == 2) m2();
                else
                    if (x == 3) m3();
                    else
                        if (x == 4) m4();
                        else
                            if (x == 5) m5();
                            else
                                if (x == 6) m6();
                                else
                                    option();
        }
        public void back()
        {
            firstMenu();
        }
        public void m1()
        {
            Console.WriteLine("Introdu nume:");
            string x;
            x = Console.ReadLine();
            e.Name = x;
            e.add();
            Console.ReadKey();
            back();
            
        }
        public void m2()
        {
            Console.WriteLine("Introdu nume:");
            string x;
            x = Console.ReadLine();
            e.Name = x;
            e.fire();
            Console.ReadKey();
            back();
        }
        public void m3()
        {
            Console.WriteLine("Introdu nume:");
            string x;
            x = Console.ReadLine();
            e.Name = x;
            e.promovate();
            Console.ReadKey();
            back();
        }
        public void m4()
        {
            e.employees();
            Console.ReadKey();
            back();
        }
        public void m5()
        {
            e.currentemployees();
            Console.ReadKey();
            back();
        }
        public void m6()
        {
            e.formeremployeers();
            Console.ReadKey();
            back();
        }
    }

}
