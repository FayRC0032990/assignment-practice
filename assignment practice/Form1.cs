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
            double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
            height = Convert.ToDouble(textBox2.Text);
            area = width * height;
            label3.Text = "Area=" + area;

        }
    }
}
