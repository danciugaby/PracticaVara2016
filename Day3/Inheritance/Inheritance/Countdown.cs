using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Countdown :  IEnumeratorInterface, IEnumUpDown
    {
        int count = 11;

        #region Methods from IEnumeratorInterface

        public bool MoveNext()
        {
            count --;
            return (count > 0) ;
        }

        public object Current
        {
            get { return count; }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region  Methods from IEnumUpDown

        public bool GoUp()
        {
            count ++;
            return (count < 11);
        }

        public bool GoDown()
        {
            count --;
            return (count > 0);
        }

        #endregion 
    }
}
