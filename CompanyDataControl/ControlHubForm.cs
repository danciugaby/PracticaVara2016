using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDataControl
{
    public partial class ControlHubForm : Form
    {
        private Employee_Class.Database Data;
        public ControlHubForm()
        {
            InitializeComponent();
            Data = new Employee_Class.Database();
        }
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployeForm newEmployeeFrm = new NewEmployeForm();
            DialogResult dg = newEmployeeFrm.ShowDialog();
            if(dg==DialogResult.OK)
            {
                Employee_Class.Employee newEmployee = new Employee_Class.Employee(newEmployeeFrm.Fname, newEmployeeFrm.Lname, newEmployeeFrm.Salary, newEmployeeFrm.EmployeeNumber);
                Data.accessDatabase.Add(newEmployee);
            }
        }

        private void DatabaseDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
