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
    public partial class NewEmployeForm : Form
    {
<<<<<<< HEAD
        string fname;
        string lname;
        string salary;
        string employeeNumber;

        public string Fname
        {
            get
            {
                return fname;
            }

            set
            {
                fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return lname;
            }

            set
            {
                lname = value;
            }
        }

        public string Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public string EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }

            set
            {
                employeeNumber = value;
            }
        }

=======
>>>>>>> feature/Departments
        public NewEmployeForm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string salary = txtSalary.Text;
            string employeeNumber = txtEmployeeNumber.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void NewEmployeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
=======
>>>>>>> feature/Departments
    }
}
