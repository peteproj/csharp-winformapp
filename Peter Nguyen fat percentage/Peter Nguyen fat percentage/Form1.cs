using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peter_Nguyen_fat_percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal = double.Parse(textBox1.Text);
            double fat = double.Parse(textBox2.Text);
            double fatp;
            double fatc;
            Boolean percent;

            if (cal > fat && cal >= 0 && fat >= 0)
            {
                fatp = fat / cal * 100.00;
                fatc = fat * 8;

                label4.Text = "Numbers of Calories from Fat: " + fatc;
                
                label5.Text = "Percentage of Fat: " + fatp;
                if (checkBox1.Checked = true)
                {

                    if (fatp < 30)
                    {
                        percent = true;

                        if (percent = true)
                        {
                            label6.Visible = true;
                            label6.Text = "(low-fat food)";
                        }
                        else { }
                    }
                }
            }
            
            else
            { 
            MessageBox.Show ("Invalid input, Make sure fat is less than cal and numbers are postive");
            }
            
            
            
        }
    }
}
/*               if (checkBox1.Checked = true)
                {

                    label6.visible = true;
                    label6.text = 
                }
 */