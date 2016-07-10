using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Functionality2
{
    public class Transform
    {
        bool behaviour;

        public bool Behaviour
        {
            get
            {
                return behaviour;
            }

            set
            {
                behaviour = value;
            }
        }

        public void ChangeBehaviour(bool val)
        {
            Behaviour = val;
        }
    }
}
