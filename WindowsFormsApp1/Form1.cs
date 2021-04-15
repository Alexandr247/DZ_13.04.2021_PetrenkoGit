using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "\nВсем на свете это ясно   " +
                "Быть программером прекрасно!   " +
                "Ты, программер, умный очень   " +
                "Программируешь что хочешь!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = button1.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = button8.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = button5.BackColor;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = button4.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = button2.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = button3.BackColor;
        }
    }
}
