using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MyList : IList<Employee>
    {
        List<Employee> list = new List<Employee>();
       public bool Validate(Employee e)
        {
            return e.Name != null && e.Firstname != null;
        }

       Employee IList<Employee>.this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                if (Validate(value))
                    list[index] = value;
            }
        }

        int ICollection<Employee>.Count
        {
            get
            {
                return list.Count;
            }
        }

        bool ICollection<Employee>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

       void ICollection<Employee>.Add(Employee item)
        {
            if (Validate(item))
            list.Add(item);
        }

        void ICollection<Employee>.Clear()
        {
            list.Clear();
        }

        bool ICollection<Employee>.Contains(Employee item)
        {
            return list.Contains(item);
        }

        void ICollection<Employee>.CopyTo(Employee[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        int IList<Employee>.IndexOf(Employee item)
        {
            return list.IndexOf(item);
        }

        void IList<Employee>.Insert(int index, Employee item)
        {
            list.Insert(index, item);
        }

        bool ICollection<Employee>.Remove(Employee item)
        {
            return list.Remove(item);
        }

        void IList<Employee>.RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

    }

}
