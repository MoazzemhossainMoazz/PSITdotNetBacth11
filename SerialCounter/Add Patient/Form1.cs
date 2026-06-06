using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Patient
{
    public partial class Form1 : Form
    {
        Queue<Patient> serials = new Queue<Patient>();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBtn_Click(object sender, EventArgs e)
        {
            string name = this.NametxtBox.Text;
            counter++;
            Patient patient = new Patient { SrNo = counter, Name = name };
            this.serials.Enqueue(patient);
            this.NametxtBox.Text = "";
            var data= serials.Select(s => s.Name + "-" + s.SrNo).ToList();
            this.PatientList.DataSource = data;
        }
    }
}
