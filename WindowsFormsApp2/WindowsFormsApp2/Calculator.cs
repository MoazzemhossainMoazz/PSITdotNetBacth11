using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fn = int.Parse(textBox1.Text);
            int sn = int.Parse(textBox2.Text);
            label1.Text = (fn + sn).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int fn = int.Parse(textBox1.Text);
            int sn = int.Parse(textBox2.Text);
            label1.Text = (fn - sn).ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int fn = int.Parse(textBox1.Text);
            int sn = int.Parse(textBox2.Text);
            label1.Text = (fn * sn).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int fn = int.Parse(textBox1.Text);
            int sn = int.Parse(textBox2.Text);
            label1.Text = (fn / sn).ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
