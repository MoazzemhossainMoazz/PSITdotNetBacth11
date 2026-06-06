namespace Add_Patient
{
    partial class Form1
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
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.NameBtn = new System.Windows.Forms.Button();
            this.PatientList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(87, 31);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(156, 20);
            this.NametxtBox.TabIndex = 0;
            this.NametxtBox.TextChanged += new System.EventHandler(this.NametxtBox_TextChanged);
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(87, 75);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(89, 23);
            this.NameBtn.TabIndex = 1;
            this.NameBtn.Text = "Add";
            this.NameBtn.UseVisualStyleBackColor = true;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // PatientList
            // 
            this.PatientList.FormattingEnabled = true;
            this.PatientList.Location = new System.Drawing.Point(102, 152);
            this.PatientList.Name = "PatientList";
            this.PatientList.Size = new System.Drawing.Size(120, 95);
            this.PatientList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatientList);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.NametxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametxtBox;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.ListBox PatientList;
    }
}

