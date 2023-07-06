using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Geoff Campbell
 * Class: TEC 151
 * Assignment: For Each Loop Demo
 * Date: 11/13/2018
 * Description: This is a project to demonstrate a ForEach loop.
 * */
namespace PizzaShop_ForEachLoop
{
    public partial class Form1 : Form
    {
        private double counter = 0;
        private double TotalCost;
        private double IndividualCost = 0;
        private double SizeCost = 0;
        private double ToppingsCost = 0;
        private double IndividualQuantity = 0;
        private const double Meat = 1;
        private const double Veggie = .5;


        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare variables            
            try
            {
                //data validation
                IndividualQuantity = double.Parse(PizzaQuantityTextbox.Text);
                //read size and assign price
                if (PersonalRadioButton.Checked == true)
                {
                    SizeCost = 6.5;
                }
                else if (MediumRadioButton.Checked == true)
                {
                    SizeCost = 9;
                }
                else if (LargeRadioButton.Checked == true)
                {
                    SizeCost = 11.5;
                }
                else if (ExtraLargeRadioButton.Checked == true)
                {
                    SizeCost = 14;
                }
                //read toppings and assign prices
                if (PepperoniCheckbox.Checked == true)
                {
                    ToppingsCost += Meat;
                }
                if (SausageCheckbox.Checked == true)
                {
                    ToppingsCost += Meat;
                }
                if (MushroomCheckbox.Checked == true)
                {
                    ToppingsCost += Veggie;
                }
                if (OnionCheckbox.Checked == true)
                {
                    ToppingsCost += Veggie;
                }
                if (GreenPepperCheckbox.Checked == true)
                {
                    ToppingsCost += Veggie;
                }
                //calculate cost of individual pizza(s)
                IndividualCost = IndividualQuantity * (SizeCost + ToppingsCost);
                //add to total order counter
                counter += IndividualQuantity;
                //add to total cost
                TotalCost += IndividualCost;
                CurrentOrderLabel.Text = IndividualCost.ToString("C");
                ToppingsCost = 0;

                List<RadioButton> radiolist = new List<RadioButton>() { PersonalRadioButton, MediumRadioButton, LargeRadioButton, ExtraLargeRadioButton };
                List<CheckBox> chklist = new List<CheckBox>() { PepperoniCheckbox, SausageCheckbox, MushroomCheckbox, OnionCheckbox, GreenPepperCheckbox };





                foreach (RadioButton radio in radiolist)
                {
                    if (radio.Checked == true)
                    {
                        listBox1.Items.Add("(Quantity:" +IndividualQuantity+")" + radio.Text );
                    }
                }


                foreach (CheckBox chk in chklist)
                {
                    if (chk.Checked == true)
                    {
                        listBox1.Items.Add(chk.Text);
                    }
                }









            }
            catch
            {
                //data validation error message
                MessageBox.Show("Please input a pizza quantity!");
            }


        }

        private void Summarybutton_Click(object sender, EventArgs e)
        {
            //display summary information
            DisplayTotalPizzas.Text = counter.ToString("n0");
            DisplayTotalAmount.Text = TotalCost.ToString("c2");
        }

        private void NextItemButton_Click(object sender, EventArgs e)
        {
            //clear the information from this specific pizza
            PersonalRadioButton.Checked = true;
            MediumRadioButton.Checked = false;
            LargeRadioButton.Checked = false;
            ExtraLargeRadioButton.Checked = false;
            PepperoniCheckbox.Checked = false;
            SausageCheckbox.Checked = false;
            MushroomCheckbox.Checked = false;
            OnionCheckbox.Checked = false;
            GreenPepperCheckbox.Checked = false;
            IndividualCost = 0;
            IndividualQuantity = 0;
            SizeCost = 0;
            ToppingsCost = 0;
            PizzaQuantityTextbox.Text = "";
            CurrentOrderLabel.Text = "";
            listBox1.Items.Clear();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            NextItemButton_Click(sender, e);
            counter = 0;
            TotalCost = 0;
            DisplayTotalPizzas.Text = "";
            DisplayTotalAmount.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Close();
        }
    }
}
