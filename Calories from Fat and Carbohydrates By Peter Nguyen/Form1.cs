using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Fat_and_Carbohydrates_By_Peter_Nguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //close program
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //variable assignment
            double fat;
            double carb;
            double fatCal;
            double carbCal;

            //makes sure inputs are valid
            if (double.TryParse(textBox1.Text, out fat) && double.TryParse(textBox2.Text, out carb))
            {   //brining the data from the method to here
                fatCal = FatCalories(fat);
                textBox3.Text = fatCal.ToString("n1"); //display data from method to textbox

                carbCal = CarbCalories(carb);//same as above
                textBox4.Text = carbCal.ToString("n1");
            }
            else //error message
                MessageBox.Show("Please enter Valid numbers");
        }
        

        private double FatCalories(double fat) //create method
        {   //formula
            double fatCal = fat * 9;
            return fatCal; //allow to store data and use elsewhere
        }


        private double CarbCalories(double carb)//same as above
        {
            double carbCal = carb * 4;
            return carbCal;
        }
    }
}
