using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class AnEnumerable : IEnumerable
    {
        object[] items = null;

        public void PopulateWithDymmy()
        {
            AnEnumerable anenum = new AnEnumerable();
            anenum.items = new object[3] {"a", 222, 23.5};

            this.items = new object[3] {"A", 333,anenum};
        }

        public IEnumerator GetEnumerator()

        {
            int c = 0;
            foreach (object o in items)
            {
                if (c++ %2!=0)
                    continue;
             
                if (o == null)
                   continue;
                yield return o;
            }
        }
        
    }
}
