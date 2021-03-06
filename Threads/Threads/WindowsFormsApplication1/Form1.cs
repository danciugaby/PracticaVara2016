﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //here is the backgroung process
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);

                            
                backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    // Set the e.Cancel flag so that the WorkerCompleted event
                    // knows that the process was cancelled.
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

            }
            backgroundWorker1.ReportProgress(100);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = "Processing......" + progressBar1.Value.ToString() + "%";
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "Task Cancelled.";
            }

            // Check to see if an error occurred in the background process.

            else if (e.Error != null)
            {
                lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                lblStatus.Text = "Task Completed...";
            }

            //Change the status of the buttons on the UI accordingly
            button1.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnCancel.Enabled = true;

            // Kickoff the worker thread to begin it's DoWork function.
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        void Go()
        {
            for (int i = 1; i < 5; i++)
                richTextBox1.Text += GetPrimesCount(i * 1000000, 1000000) +
                " primes between " + (i * 1000000) + " and " + ((i + 1) * 1000000 - 1) +
                Environment.NewLine;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Go();
        }
        int GetPrimesCount(int start, int count)
        {
            return ParallelEnumerable.Range(start, count).Count(n =>
          Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
        }
        Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() =>
           ParallelEnumerable.Range(start, count).Count(n =>
         Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }        async void GoGo()
        {
            //button2.IsEnabled = false;
            for (int i = 1; i < 5; i++)
            {
                richTextBox1.Text += await GetPrimesCountAsync(i * 1000000, 1000000) +
                " primes between " + (i * 1000000) + " and " + ((i + 1) * 1000000 - 1) +

                Environment.NewLine;
            }
            //button2.IsEnabled = true;
        }
    }
}
