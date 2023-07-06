using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoff_Auto_By_Peter_Nguyen
{
    public partial class Form1 : Form
    { double total;
      
      double parts;
        double labor;
        double tax;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //exit button
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //call all clear methods
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            ClearListbox();
            total = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //creating varibales and calling methods
            double subtotal = OilLubeCharges(total) + flushCharges(total) + MiscCharges(total) + OtherCharges(total, parts, labor);
            
            double ntotal;
            ntotal = subtotal + TaxCharges(total);
            textBox1.Text = "0";
            textBox2.Text = "0";
            double addpart =  double.Parse(textBox1.Text);
            double addlabor = double.Parse(textBox2.Text);
            


            //display to textbox
            textBox3.Text = subtotal.ToString("C");
            textBox4.Text = addpart.ToString("C");
            textBox5.Text = addlabor.ToString("C");
            textBox6.Text = TaxCharges(total).ToString("C");
            textBox7.Text= ntotal.ToString("C");
            
            
            
            
            
            
            
            
            //add items to list box
            List<CheckBox> chklist = new List<CheckBox>() { oil, lube, radiator, transmission, inspection, tire, muffler};

            foreach (CheckBox chk in chklist)
            {
                if (chk.Checked == true)
                {
                    listBox2.Items.Add(chk.Text);              
                }
            
            }
        }

        private double OilLubeCharges(double total)
        {   //if checked, then add value
            if (oil.Checked == true)
            {
                total += 26;
            }
            else
            {
                total += 0;
            }
            if (lube.Checked == true)
            {
                total += 18;

            }
            else
            {
                total += 0;
            }
            return total;//return
        }

        private double flushCharges(double total) 
        {   //if checked then use value
            if (radiator.Checked == true)
            {
                total += 30;
            }
            else
            {
                total += 0;
            }
            if (transmission.Checked == true)
            {
                total += 80;
            }
            else
            {
                total += 0;
            }                      
            return total;
        }
        private double MiscCharges(double total)
        {   //if checked then use value
            if (inspection.Checked == true)
            {
                total += 15;
            }
            else
            {
                total += 0;
            }
            if (muffler.Checked == true)
            {
                total += 100;
            }
            else
            {
                total += 0;
            }
            if (tire.Checked == true)
            {
                total += 20;
            }
            else
            {
                total += 0;
            }
            
            return total;
        }

        private double OtherCharges(double total, double parts, double labor)
        {   //give value
            parts = 0;
            labor = 0;

            try
            {
                parts = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("error enter number again");
                parts= 0;
                
            }
            try
            {
                labor= double.Parse(textBox2.Text);
                
            }
            catch
            {
                MessageBox.Show("error enter number again");
                labor= 0;
            }

            total = parts + labor;
            

            textBox3.Text = textBox1.Text;
            
            
            
            return total;
            
        }

        private double TaxCharges(double total)
        {   //calculating tax
            double tax;
            parts = double.Parse(textBox1.Text);
            
            tax = parts * 0.06;
            return tax;   
        }

        private void ClearOilLube()
        {//unckeck checkbox
            oil.Checked = false;
            lube.Checked = false;
        }
        private void ClearFlushes()
        {//unckeck checkbox
            radiator.Checked = false;
            transmission.Checked = false;
        }
    
        private void ClearMisc()
        {   //unckeck checkbox
            inspection.Checked = false;
            muffler.Checked = false;
            tire.Checked = false;
        }

        private void ClearOther() 
        {   //clear text box and reset variables
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void ClearFees()
        {   //reset variables
            
            total= 0;
        }
        private void ClearListbox()
        {   //clear list box items
            listBox2.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   //set default value of parts to 0
            this.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//set default value of parts to 0
            this.Text = "0";
        }
    }
}
