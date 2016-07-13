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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl31.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl31.Visible = false;
        }
    }
}
