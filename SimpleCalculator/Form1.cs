using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox1.Text = "Enter first number";
            textBox2.Text = "Enter second number";
            Addition.Text = "+";
            button2.Text = "-"; 
            button3.Text = "*"; 
            button4.Text = "/";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int result = 0;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);
                result = a + b;
                textBox3.Text = result.ToString();
                //MessageBox.Show("Addition Operation is:" + " " +result.ToString());
            }
            catch
            {
                MessageBox.Show("Please enter numeric value(s)!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int a = 0;
                int b = 0;
                int result = 0;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);
                result = a - b;
                textBox3.Text = result.ToString();
                //MessageBox.Show("Minus Operation is:" + " " + result.ToString());
            }
            catch {
                MessageBox.Show("Please enter numeric value(s)!");
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int result = 0;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);
                result = a / b;
                textBox3.Text = result.ToString();
                //MessageBox.Show("Divid Operation is:" + " " + result.ToString());
            }
            catch
            {
                MessageBox.Show("Please enter numeric value(s)!");

            }
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int result = 0;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);
                result = a * b;

                textBox3.Text = result.ToString();
                //MessageBox.Show("Multiply Operation is:" + " " + result.ToString());
            }
            catch
            {
                MessageBox.Show("Please enter numeric value(s)!");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter first number" && textBox2.Text == "Enter second number")
            {
                return;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}











