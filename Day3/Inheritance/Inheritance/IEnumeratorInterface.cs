using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IEnumeratorInterface 
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
}
