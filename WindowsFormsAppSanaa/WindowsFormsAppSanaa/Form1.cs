using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSanaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double x, y;
            // x = 6;
            //  y = ++x;
            //  MessageBox.Show("y=" + y.ToString());
            int n, m, sum;
            n = Int32.Parse(textBox1.Text);
            m = Int32.Parse(textBox2.Text);
            sum = n + m;
            textBox3.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
