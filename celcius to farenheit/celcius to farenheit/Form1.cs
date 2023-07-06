using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celcius_to_farenheit
{
    public partial class Form1 : Form
        {       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //intialize constants
            const int start = 0;
            const int end = 20;
            const int interval = 1;
            
            //declare vairables
            int celsius;
            double fahrenheit;
            //beggining of loop and rules for the loop. Celsius starts at 0 ends with 20, increases by 1 each loop
            for (celsius = start; celsius <= end; celsius += interval)
            {   //formula for conversion
                fahrenheit =  (9 / 5) * celsius + 32;
                //put in list box
                conversionTable.Items.Add(celsius + " celsius is same as " + fahrenheit + " fahrenheit");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//exit button
            this.Close();
        }
    }
}
