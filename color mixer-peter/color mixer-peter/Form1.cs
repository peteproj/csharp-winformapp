using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_mixer_peter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton4.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton1.Checked && radioButton5.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (radioButton1.Checked && radioButton6.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (radioButton2.Checked && radioButton4.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (radioButton2.Checked && radioButton5.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (radioButton2.Checked && radioButton6.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (radioButton3.Checked && radioButton4.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (radioButton3.Checked && radioButton5.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (radioButton3.Checked && radioButton6.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else 
            {
                MessageBox.Show("Please 2 colors from different group box");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
