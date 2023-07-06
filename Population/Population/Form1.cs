using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //create error message for invalid inputs
            try
            {
                 int.Parse(textBox1.Text);
                 int.Parse(textBox2.Text);
                 int.Parse(textBox3.Text);   
            }
            catch//error message
            {
                MessageBox.Show("Whole numbers only");
            }
            int initial = int.Parse(textBox1.Text);
            int percent = int.Parse(textBox2.Text) / 100 ;
            int days = int.Parse(textBox3.Text);
            int count = 1;
            int pop;
            //loop
            while (count <= days)
            {   //formula for population
                pop = initial * percent;
                //display onto listbox
                listBox1.Items.Add("Day " + count + "    Population: " + pop);
                //add existing values to vairables to evenually end loop
                count++;
                initial += pop;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
