using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
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
=======
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDataControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlHubForm());
>>>>>>> feature/Departments
        }
    }
}
