﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Entities;
namespace View
{
    public partial class Form1 : Form
    {
        Database d = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            SortedList< string, Employee> a = new SortedList< string, Employee>();

            a.Add("a", new Employee());
            a.Add("d", new Employee());
            a.Add("c", new Employee());
            a.Add("e", new Employee());
            a["c"] = new Employee("a","b");
            if (
            d.Add(employeeHandler.TxtName.Text, employeeHandler.TxtFirstName.Text)
                )
                MessageBox.Show("success");
        }
        void PopulateList()
        {
            lstEmployees.DataSource = d.QueryAll();
            lstEmployees.Refresh();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           int index = lstEmployees.SelectedIndex;
            if (index > 0)
            {
                d.DeleteAt(index);
                PopulateList();
            }
           
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
