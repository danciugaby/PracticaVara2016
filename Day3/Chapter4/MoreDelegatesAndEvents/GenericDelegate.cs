using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreDelegatesAndEvents
{
    public delegate T Transformer<T>(T args);

    public class GenericDelegate<T>
    {
        public static void Transform<T>(T[] values, Transformer<T> t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }


}
