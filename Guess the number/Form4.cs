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
    public partial class Form4 : Form
    {
        int number_random = new Random().Next(1, 100);
        int temp = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_added = Convert.ToInt32(textBox1.Text);

            if (number_added == number_random)
            {
                label3.Text = "";
                label2.Text = "";
                MessageBox.Show("عدد رو درست حدس زدی");
                temp += 1;
                this.Close();
            }
            else if (number_added > number_random)
            {
                label2.Text = "عدد کوچکتر است";
                int number_guess = Convert.ToInt32(label5.Text);
                label5.Text = Convert.ToString(number_guess - 1);

                if (label5.Text == "0" && temp != 1)
                {
                    MessageBox.Show("متاسفانه نتونستی عدد رو درست حدس بزنی");
                    this.Close();
                }
            }
            else if (number_added < number_random)
            {
                label2.Text = "عدد بزرگتر است";
                int number_guess = Convert.ToInt32(label5.Text);
                label5.Text = Convert.ToString(number_guess - 1);

                if (label5.Text == "0")
                {
                    MessageBox.Show("متاسفانه نتونستی عدد رو درست حدس بزنی");
                    this.Close();
                }

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "حدس شما")
            {
                textBox1.ForeColor = Color.White;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.LightGray;
                textBox1.Text = "حدس شما";
            }
            else
            {
                textBox1.ForeColor = Color.White;
            }
        }
    }
}
