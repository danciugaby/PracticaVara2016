namespace CompanyDataControl
{
    partial class ControlHubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.DatabaseDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(913, 491);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(110, 26);
            this.btnNewEmployee.TabIndex = 2;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.Location = new System.Drawing.Point(12, 121);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(411, 396);
            this.DatabaseDisplay.TabIndex = 3;
            this.DatabaseDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // ControlHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 529);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.btnNewEmployee);
            this.Name = "ControlHubForm";
            this.Text = "Control Hub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.ListView DatabaseDisplay;
    }
}

