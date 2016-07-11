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
    public partial class MyFirstForm : Form
    {
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            DialogResult dg =  loginfrm.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string name = loginfrm.Name1;
                string password = loginfrm.Password;
            }
        }

        private void btnLogin_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("dsadsa   fdsdf ");
            listBox1.Items.Add("dsadsa   fdsdf ");
            listBox1.Items.Add("my");
            listBox1.Items.Add("dsadsa   fdsdf ");
            listBox1.Items.Add("dsadsa   fdsdf ");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            if (listBox1.Items[listBox1.SelectedIndex] == "my")
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.Refresh();
        }
    }
}
