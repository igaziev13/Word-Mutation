using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Mutation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.allow_vowels = checkBox2.Checked;
            Form1.allow_consonants = checkBox3.Checked;
            Form1.vowels = textBox2.Text;
            Form1.consonants = textBox3.Text;
            if (radioButton2.Checked) Form1.volatility = 5;
            if (radioButton3.Checked) Form1.volatility = 8;
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox2.Enabled = true;
            else textBox2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) textBox3.Enabled = true;
            else textBox3.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
