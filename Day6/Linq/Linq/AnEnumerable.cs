using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class AnEnumerable : IEnumerable, IDisposable
    {
        object[] items = null;
        unsafe static void f()
            {
             int* a=  null;
            System.IntPtr aa = (System.IntPtr)(int *)a;
            }
       

        public void PopulateWithDymmy()
        {

            AnEnumerable anenum = new AnEnumerable();
            anenum.items = new object[3] { 'a', 222, 23.5 };

            this.items = new object[3] {'A', 333,anenum};
        }

        public IEnumerator GetEnumerator()

        {
            int c = 0;
            foreach (object o in items)
            {
                //if (c++ % 2 != 0)
                //    continue;

                if (o == null)
                    continue;
                yield return o;
            }
        }

        public void Dispose()
        {
            MyEraser(items);
        }
        void MyEraser(IList myitems)
        {
           for(int i=0;i<myitems.Count;i++)
            {
                object o = myitems[i];
                if (o != null)
                {
                    var subCollection = o as IEnumerable;
                    if (subCollection != null)
                    {
                        IList list = new List<object>();
                        foreach (var e in subCollection)
                        {
                            list.Add(e);
                        }
                        MyEraser(list);
                        myitems[i] = list;
                    }
                    else
                    {
                        o = null;
                        myitems[i] = o;
                    }
                }

               
            }
        }
    }
}
