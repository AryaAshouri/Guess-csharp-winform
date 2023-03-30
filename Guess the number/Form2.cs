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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form level_one = new Form3();
            level_one.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form level_two = new Form4();
            level_two.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form level_three = new Form5();
            level_three.ShowDialog();
        }
    }
}
