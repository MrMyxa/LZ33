using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox1.Text);
            float b = Convert.ToSingle(textBox2.Text);
            float x = Convert.ToSingle(textBox3.Text);
            if (x == 0)
                {
                    textBox4.Text = "x не может быть нулём";
                }
            else
            {
                textBox4.Text = Convert.ToString((float)(((a * x) - Math.Sqrt(b)) / (5.7 * ((x * x) + (b * b)))) - (Math.Abs(x + b) - (a * a) / (x * x)) * (Math.Pow(Math.Tan(b), 2)));
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
