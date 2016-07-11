using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
    public partial class LoginForm : Form
    {
        string name = "";
        string password = "";

        public string Name1
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

       
            
       private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLA_Click(object sender, EventArgs e)
        {
            Name1 = textBox1.Text;
            Password = textBox2.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
