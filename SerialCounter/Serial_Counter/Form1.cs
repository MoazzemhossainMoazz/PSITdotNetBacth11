using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Counter
{
    public partial class Form1 : Form
    {
        Queue<int> serials = new Queue<int>();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addSrlBtn_Click(object sender, EventArgs e)
        {
            counter++;
            serials.Enqueue(counter);
            this.slrlist.DataSource = serials.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //If I don't use this code repeatedly for each button then I can use this code for all buttons

        private void ProcessCounter(TextBox txtCounter)
        {
            if (serials.Count > 0)
            {
                int serial = serials.Peek();
                txtCounter.Text = serial.ToString();
                lblmsg.Text = "Counter is at " + serial.ToString();

                serials.Dequeue();
                slrlist.DataSource = null;
                slrlist.DataSource = serials.ToList();
            }
            else
            {
                lblmsg.Text = "No more serials in the queue.";
            }
        }

        private void counterbtn1_Click(object sender, EventArgs e)
        {
            //    if(serials.Count > 0)
            //    {
            //        int serial = serials.Peek();
            //        this.txtcnt1.Text = serial.ToString();
            //        this.lblmsg.Text = "Counter is at " + serial.ToString();
            //        serials.Dequeue();
            //        this.slrlist.DataSource = serials.ToList();
            //    }
            //    else
            //    {
            //        this.lblmsg.Text = "No more serials in the queue.";
            //    }

            ProcessCounter(txtcnt1);

        }

        private void counterbtn2_Click(object sender, EventArgs e)
        {
            //    int serial = serials.Peek();
            //    this.txtcnt2.Text = serial.ToString();
            //    this.lblmsg.Text = "Counter is at " + serial.ToString();
            //    serials.Dequeue();
            //    this.slrlist.DataSource = serials.ToList();

            ProcessCounter(txtcnt2);
        }

        private void counterbtn3_Click(object sender, EventArgs e)
        {
            //    int serial = serials.Peek();
            //    this.txtcnt3.Text = serial.ToString();
            //    this.lblmsg.Text = "Counter is at " + serial.ToString();
            //    serials.Dequeue();
            //    this.slrlist.DataSource = serials.ToList();

            ProcessCounter(txtcnt3);
        }

        private void counterbtn4_Click(object sender, EventArgs e)
        {
            //    int serial = serials.Peek();
            //    this.txtcnt4.Text = serial.ToString();
            //    this.lblmsg.Text = "Counter is at " + serial.ToString();
            //    serials.Dequeue();
            //    this.slrlist.DataSource = serials.ToList();

            ProcessCounter(txtcnt4);
        }





    }
}
