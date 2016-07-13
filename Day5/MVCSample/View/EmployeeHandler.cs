using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class EmployeeHandler : UserControl
    {
        public EmployeeHandler()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!TextValidator.Validate(txtName.Text))
                txtName.Text = "a";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!TextValidator.ValidateLeave(txtName.Text))
                txtName.Text = "u";
        }
    }
}
