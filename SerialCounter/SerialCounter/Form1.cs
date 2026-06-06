using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCounter
{
    public partial class Form1 : Form
    {
        Queue<int> serials = new Queue<int>();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CounterCall(TextBox txt)
        {
            if (serials.Count>0)

            {
                int serial = serials.Peek();
                txt.Text = serial.ToString();
                this.lblmsg.Text = "Counter is at " + serial.ToString();
                serials.Dequeue();
                this.srList.DataSource = serials.ToList();
            }
        else
            {
                this.lblmsg.Text = "No more serials in the queue.";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}