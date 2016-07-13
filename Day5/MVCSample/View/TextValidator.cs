using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class TextValidator
    {
        static public bool Validate(string text)
        {
            return text != "bubu";
        }
        static public bool ValidateLeave(string text)
        {
            return text != "baba";
        }

    }
}
