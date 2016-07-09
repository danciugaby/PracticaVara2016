using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IEquatable<T>
    {
        bool IsEqualTo(T obj);
    }

    public class Balloon : IEquatable<Balloon>
    {
        public string Color { get; set; }
        public int CC { get; set; }

        public bool IsEqualTo(Balloon b)
        {
            if (b == null) return false;
            return b.Color == Color && b.CC == CC;
        }
    }

    public class Person
    {
        public string Nume { get; set; }
        public string Prenume { get; private set; }
    }

    public class Student : Person, IEquatable<Student>
    {
        public int m_number;

        bool IEquatable<Student>.IsEqualTo(Student obj)
        {
 
            if (obj == null) return false;
            return obj.Nume == this.Nume && this.Prenume == obj.Prenume;
        }
    }
}
