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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32 (textBox1.Text);
            int b= Convert.ToInt32 (textBox2.Text);
            int c = Convert.ToInt32 (textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = b + c;
            if (x > c && y > b && z > a)
             MessageBox.Show("Треугольник реализуется");
            else
                MessageBox.Show("Треугольник не реализуется");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = b + c;
            if (x > c && y > b && z > a)
            {
                if (a == b && a == c && b == c)
                {
                    MessageBox.Show("Треугольник равносторонний");
                }
                if (a == b || a == c || b == c)
                {
                    MessageBox.Show("Треугольник равнобедренных");
                }
                else { MessageBox.Show("Треугольник равносторонний"); }

            }
            else { MessageBox.Show("Треугольник не реализуется"); }
  }
