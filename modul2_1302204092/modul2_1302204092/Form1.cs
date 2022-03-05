using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204092
{
    public partial class Form1 : Form
    {
        double value = 0;
        string ops = "";
        bool op_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Label Output") || (op_pressed))
            {
                textBox1.Clear();
            }

            Button b = (Button)sender;

            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void button0_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+": textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            value = Double.Parse(textBox1.Text);

            op_pressed = true;
        }
    }
}
