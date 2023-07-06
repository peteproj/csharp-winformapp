using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Programmed By: Peter Nguyen
//TEC 151
namespace Retail_Price_Calculator_By_Peter_Nguyen
{       
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //exit button
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            //creating variables        
            double price;
            double markup;
            double netPrice;


            //making sure valid numbers are being input to the textboxs
            if (double.TryParse(textBox1.Text, out price) && double.TryParse(textBox2.Text, out markup))
            {   
                //pulls the variable netPrice and its data
                netPrice = calculateRetail(price, markup);
                textBox3.Text = netPrice.ToString("C"); //formatting the price to oputput
            }
            else //error message
                MessageBox.Show("Please enter Valid numbers");
        }
        private double calculateRetail(double price, double markup)
        {   //the method and algorithm
            double newPercent = markup / 100;
            double netPrice = price * newPercent + price;
            return netPrice; //to allow the other methods to use the data inside the variable
        }
    }
}
