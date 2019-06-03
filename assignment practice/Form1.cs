using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculates the area of a rectangle
            try
            {
                double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
                height = Convert.ToDouble(textBox2.Text);
                area = width * height;
                label3.Text = "Area=" + area;
            }
            catch
            {
                MessageBox.Show("Type in two numbers to get a proper answer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Calculates the area of a triangle
            try
            {
                double Base, height, area;
                Base = Convert.ToDouble(textBox3.Text);
                height = Convert.ToDouble(textBox4.Text);
                area = Base * height / 2;
                label6.Text = "Area=" + area;
            }
            catch
            {
                MessageBox.Show("Type in two numbers to get a logical answer");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Calculates the area of a circle
            try
            {
                double radius, area;

            }
        }
    }
}
