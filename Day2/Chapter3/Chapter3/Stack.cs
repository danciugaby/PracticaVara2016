using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];

        public void Push(T obj)
        {
            data[position++] = obj;
        }

        public T Pop()
        {
            return data[--position];
        }
    }
    public struct Nullable<T>
    {
        private T anotherval;
        
        public T Value
        {
            get
            {
                return anotherval;
            }
            //{
            //    T t = default(T);
            //    return Value;
            //}
            set
            {
                if (value != null)
                if (value.ToString()=="")
                    Value = default(T);
            }
        }
    }
}
