using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class B : Comparer<A>
    {
        public override int Compare(A x, A y)
        {
           
            return (x.a < y.a) ? -1 : 1;
        }
    }
    public class A 


    {
        public int [] items;
        public int a;
        public A(int i)
        {
            a = i;
            items = new int[] { 1, 2, 34, 56 };
        }

        
    }

    public class Linqer
    {
        public static void TestEnum()
        {
            
            AnEnumerable anenumarable = new AnEnumerable();
            anenumarable.PopulateWithDymmy();
            int c = Count(anenumarable);
            anenumarable.Dispose();
        }
        public static void TestEnumeartor()
        {
            A a = new A(1);
            // Because string implements IEnumerable, we can call GetEnumerator():
            var rator = ((IEnumerable<int>)a.items).GetEnumerator();
            while (rator.MoveNext())
            {
                int c = (int)rator.Current;
                Console.Write(c + ".");
            }

            A[] list = { new A(3), new A(2) };
            B comparer = new  B();
            Array.Sort(list, comparer);
        }
        
       static  bool MyContains(string a)
        {
            return a.Contains("a");
        }
        public static int Count(IEnumerable e)
        {
            int count = 0;
            foreach (object element in e)
            {
                var subCollection = element as IEnumerable;
                if (subCollection != null)
                    count += Count(subCollection);
                else
                    count++;
            }
            return count;
        }
    }
}
