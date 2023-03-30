using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "آشوری" && textBox2.Text == "آریا")
            {
                Form Levels = new Form2();
                Levels.ShowDialog();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (textBox1.Text != "آشوری" && textBox2.Text != "آریا")
            {
                label3.Text = "نام کاربری و رمز عبور نامعتبر";
                label2.Text = "";
            }
            else if (textBox1.Text != "آشوری")
            {
                label2.Text = "نام کاربری نامعتبر";
                label3.Text = "";
            }
            else if (textBox2.Text != "آریا")
            {
                label2.Text = "رمز عبور نامعتبر";
                label3.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "نام کاربری")
            {
                textBox1.ForeColor = Color.White;
                textBox1.Text = "";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "رمز عبور")
            {
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.LightGray;
                textBox1.Text = "نام کاربری";
            }
            else
            {
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.LightGray;
                textBox2.Text = "رمز عبور";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.ForeColor = Color.White;
            }
        }
    }
}
