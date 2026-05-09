using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.Add("Meter");
            cmbFrom.Items.Add("Kilometers");
            cmbFrom.Items.Add("Centimeters");

            cmbTo.Items.Add("Meter");
            cmbTo.Items.Add("Kilometers");
            cmbTo.Items.Add("Centimeters");

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double value= Convert.ToDouble(txtValue.Text);
            string from=cmbFrom.Text;
            string to=cmbTo.Text;
            double result = 0;

            if (from == "Meter" && to == "Kilometers")
                result = value / 1000;
            else if (from == "Kilometers" && to == "Meter")
                result = value * 1000;
            else if (from == "Meter" && to == "Centimeters")
                result = value * 100;
            else if (from == "Centimeters" && to == "Meter")
                result = value / 100;
            else
                result= value;
            lblResult.Text = "Result:" + result;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
