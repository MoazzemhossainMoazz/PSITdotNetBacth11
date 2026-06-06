namespace Serial_Counter
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
            this.txtcnt1 = new System.Windows.Forms.TextBox();
            this.addSrlBtn = new System.Windows.Forms.Button();
            this.slrlist = new System.Windows.Forms.ListBox();
            this.counterbtn1 = new System.Windows.Forms.Button();
            this.txtcnt2 = new System.Windows.Forms.TextBox();
            this.txtcnt3 = new System.Windows.Forms.TextBox();
            this.txtcnt4 = new System.Windows.Forms.TextBox();
            this.counterbtn2 = new System.Windows.Forms.Button();
            this.counterbtn3 = new System.Windows.Forms.Button();
            this.counterbtn4 = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcnt1
            // 
            this.txtcnt1.Location = new System.Drawing.Point(24, 12);
            this.txtcnt1.Name = "txtcnt1";
            this.txtcnt1.Size = new System.Drawing.Size(100, 20);
            this.txtcnt1.TabIndex = 0;
            // 
            // addSrlBtn
            // 
            this.addSrlBtn.Location = new System.Drawing.Point(153, 148);
            this.addSrlBtn.Name = "addSrlBtn";
            this.addSrlBtn.Size = new System.Drawing.Size(75, 23);
            this.addSrlBtn.TabIndex = 1;
            this.addSrlBtn.Text = "Add Serial";
            this.addSrlBtn.UseVisualStyleBackColor = true;
            this.addSrlBtn.Click += new System.EventHandler(this.addSrlBtn_Click);
            // 
            // slrlist
            // 
            this.slrlist.FormattingEnabled = true;
            this.slrlist.Location = new System.Drawing.Point(153, 188);
            this.slrlist.Name = "slrlist";
            this.slrlist.Size = new System.Drawing.Size(120, 95);
            this.slrlist.TabIndex = 2;
            this.slrlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // counterbtn1
            // 
            this.counterbtn1.Location = new System.Drawing.Point(24, 50);
            this.counterbtn1.Name = "counterbtn1";
            this.counterbtn1.Size = new System.Drawing.Size(75, 23);
            this.counterbtn1.TabIndex = 3;
            this.counterbtn1.Text = "Counter 1";
            this.counterbtn1.UseVisualStyleBackColor = true;
            this.counterbtn1.Click += new System.EventHandler(this.counterbtn1_Click);
            // 
            // txtcnt2
            // 
            this.txtcnt2.Location = new System.Drawing.Point(173, 12);
            this.txtcnt2.Name = "txtcnt2";
            this.txtcnt2.Size = new System.Drawing.Size(100, 20);
            this.txtcnt2.TabIndex = 4;
            // 
            // txtcnt3
            // 
            this.txtcnt3.Location = new System.Drawing.Point(318, 12);
            this.txtcnt3.Name = "txtcnt3";
            this.txtcnt3.Size = new System.Drawing.Size(100, 20);
            this.txtcnt3.TabIndex = 5;
            // 
            // txtcnt4
            // 
            this.txtcnt4.Location = new System.Drawing.Point(468, 12);
            this.txtcnt4.Name = "txtcnt4";
            this.txtcnt4.Size = new System.Drawing.Size(100, 20);
            this.txtcnt4.TabIndex = 6;
            // 
            // counterbtn2
            // 
            this.counterbtn2.Location = new System.Drawing.Point(173, 50);
            this.counterbtn2.Name = "counterbtn2";
            this.counterbtn2.Size = new System.Drawing.Size(75, 23);
            this.counterbtn2.TabIndex = 7;
            this.counterbtn2.Text = "Counter 2";
            this.counterbtn2.UseVisualStyleBackColor = true;
            this.counterbtn2.Click += new System.EventHandler(this.counterbtn2_Click);
            // 
            // counterbtn3
            // 
            this.counterbtn3.Location = new System.Drawing.Point(318, 50);
            this.counterbtn3.Name = "counterbtn3";
            this.counterbtn3.Size = new System.Drawing.Size(75, 23);
            this.counterbtn3.TabIndex = 8;
            this.counterbtn3.Text = "Counter 3";
            this.counterbtn3.UseVisualStyleBackColor = true;
            this.counterbtn3.Click += new System.EventHandler(this.counterbtn3_Click);
            // 
            // counterbtn4
            // 
            this.counterbtn4.Location = new System.Drawing.Point(468, 50);
            this.counterbtn4.Name = "counterbtn4";
            this.counterbtn4.Size = new System.Drawing.Size(75, 23);
            this.counterbtn4.TabIndex = 9;
            this.counterbtn4.Text = "Counter 4";
            this.counterbtn4.UseVisualStyleBackColor = true;
            this.counterbtn4.Click += new System.EventHandler(this.counterbtn4_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(367, 174);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.counterbtn4);
            this.Controls.Add(this.counterbtn3);
            this.Controls.Add(this.counterbtn2);
            this.Controls.Add(this.txtcnt4);
            this.Controls.Add(this.txtcnt3);
            this.Controls.Add(this.txtcnt2);
            this.Controls.Add(this.counterbtn1);
            this.Controls.Add(this.slrlist);
            this.Controls.Add(this.addSrlBtn);
            this.Controls.Add(this.txtcnt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcnt1;
        private System.Windows.Forms.Button addSrlBtn;
        private System.Windows.Forms.ListBox slrlist;
        private System.Windows.Forms.Button counterbtn1;
        private System.Windows.Forms.TextBox txtcnt2;
        private System.Windows.Forms.TextBox txtcnt3;
        private System.Windows.Forms.TextBox txtcnt4;
        private System.Windows.Forms.Button counterbtn2;
        private System.Windows.Forms.Button counterbtn3;
        private System.Windows.Forms.Button counterbtn4;
        private System.Windows.Forms.Label lblmsg;
    }
}

