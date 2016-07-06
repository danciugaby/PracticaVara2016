using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Panda
    {
        public Panda Mate;
        public void Marry(Panda partner)
        {
            Mate = partner;
            partner.Mate = this;
        }
    }
}
