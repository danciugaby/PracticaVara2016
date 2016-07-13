using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    public class Linqer
    {
        public static void TestEnum()
        {
            AnEnumerable anenumarable = new AnEnumerable();
            anenumarable.PopulateWithDymmy();
            int c = Count(anenumarable);
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
