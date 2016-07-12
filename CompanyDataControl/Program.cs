using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDataControl
{
    class Program
    {
        public static void Main()
        {
            ControlHubForm mainHub = new ControlHubForm();
            mainHub.ShowDialog();
            string s = 23.ToString();
            int i = Int32.Parse(s);
        }
    }
}
