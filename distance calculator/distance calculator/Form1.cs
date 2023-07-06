using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distance_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //variables
            double speed;
            double time;
            double balance;
            int count = 1;
            int spd = 1;
            //to make sure no letters are input
            try
            {
                speed = double.Parse(textBox1.Text);
                time = double.Parse(textBox2.Text);
                

                //make sure speed is postive and getting user input
                if (double.TryParse(textBox1.Text, out balance) && speed > 0)
                {//continue loop to show details in list box
                    while (count <= time)
                    {
                        balance = spd * speed;
                        listBox1.Items.Add("After hour " + spd + " the distance is " + balance);
                        //adds 1 to the value and restarts loop
                        spd++;
                        count++;

                    }
                }
                else
                {//error message
                    MessageBox.Show("Invalid Values");
                }
            }
            catch
            {//error message
                MessageBox.Show("Invalid Values");
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {//close button
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {//clear button
            listBox1.Items.Clear();
        }
    }
}
