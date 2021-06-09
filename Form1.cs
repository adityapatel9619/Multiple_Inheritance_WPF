using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Inheritance_WPF
{
    public partial class Form1 : Form
    {
        int ar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            ar = calculate.getArea();
            label3.Visible = true;
            label3.Text = "Area is: " + ar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            int ar = calculate.getArea();
            int cs = calculate.getCost(ar);
            label4.Visible = true;
            label4.Text = "Cost is: " + cs;
        }
    }
}
