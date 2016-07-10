using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown e = new Countdown();
            
            while (e.MoveNext())
                Console.Write(e.Current);

            e.GoUp();
            Console.Write(" " + e.Current);
            e.GoDown();
            Console.Write(" " + e.Current);



            IEquatable<Balloon> b= new Balloon();

            Balloon anewbaloon = new Balloon();
            anewbaloon.Color = "red";
            ((Balloon) b).Color = "red";
            bool truthval = b.IsEqualTo(anewbaloon);

            IEquatable<Student> p = new Student();
            Person anewperson = new Person();
            anewperson.Nume = "a";
            ((Person)p).Nume = "a";
            //this fails at compilation:
            ///truthval = p.IsEqualTo(anewperson);
            //this raises exception:
            try
            {
                truthval = p.IsEqualTo(((Student)anewperson));
            }
            catch (Exception ex)
            {
                
              
            }

            Person astudent = new Student();
            astudent.Nume = "b";
            truthval = p.IsEqualTo(((Student)astudent));

        }
    }
}
