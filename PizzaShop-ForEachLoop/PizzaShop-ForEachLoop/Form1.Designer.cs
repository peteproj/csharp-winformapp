namespace PizzaShop_ForEachLoop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PepperoniCheckbox = new System.Windows.Forms.CheckBox();
            this.SausageCheckbox = new System.Windows.Forms.CheckBox();
            this.MushroomCheckbox = new System.Windows.Forms.CheckBox();
            this.OnionCheckbox = new System.Windows.Forms.CheckBox();
            this.GreenPepperCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.PersonalRadioButton = new System.Windows.Forms.RadioButton();
            this.LargeRadioButton = new System.Windows.Forms.RadioButton();
            this.ExtraLargeRadioButton = new System.Windows.Forms.RadioButton();
            this.PizzaQuantityTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.NextItemButton = new System.Windows.Forms.Button();
            this.Summarybutton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisplayTotalPizzas = new System.Windows.Forms.TextBox();
            this.DisplayTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentOrderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 225);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 147);
            this.listBox1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Current Selection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PepperoniCheckbox);
            this.groupBox3.Controls.Add(this.SausageCheckbox);
            this.groupBox3.Controls.Add(this.MushroomCheckbox);
            this.groupBox3.Controls.Add(this.OnionCheckbox);
            this.groupBox3.Controls.Add(this.GreenPepperCheckbox);
            this.groupBox3.Location = new System.Drawing.Point(162, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 136);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // PepperoniCheckbox
            // 
            this.PepperoniCheckbox.AutoSize = true;
            this.PepperoniCheckbox.Location = new System.Drawing.Point(6, 19);
            this.PepperoniCheckbox.Name = "PepperoniCheckbox";
            this.PepperoniCheckbox.Size = new System.Drawing.Size(74, 17);
            this.PepperoniCheckbox.TabIndex = 32;
            this.PepperoniCheckbox.Text = "Pepperoni";
            this.PepperoniCheckbox.UseVisualStyleBackColor = true;
            // 
            // SausageCheckbox
            // 
            this.SausageCheckbox.AutoSize = true;
            this.SausageCheckbox.Location = new System.Drawing.Point(6, 42);
            this.SausageCheckbox.Name = "SausageCheckbox";
            this.SausageCheckbox.Size = new System.Drawing.Size(68, 17);
            this.SausageCheckbox.TabIndex = 33;
            this.SausageCheckbox.Text = "Sausage";
            this.SausageCheckbox.UseVisualStyleBackColor = true;
            // 
            // MushroomCheckbox
            // 
            this.MushroomCheckbox.AutoSize = true;
            this.MushroomCheckbox.Location = new System.Drawing.Point(6, 65);
            this.MushroomCheckbox.Name = "MushroomCheckbox";
            this.MushroomCheckbox.Size = new System.Drawing.Size(80, 17);
            this.MushroomCheckbox.TabIndex = 34;
            this.MushroomCheckbox.Text = "Mushrooms";
            this.MushroomCheckbox.UseVisualStyleBackColor = true;
            // 
            // OnionCheckbox
            // 
            this.OnionCheckbox.AutoSize = true;
            this.OnionCheckbox.Location = new System.Drawing.Point(6, 89);
            this.OnionCheckbox.Name = "OnionCheckbox";
            this.OnionCheckbox.Size = new System.Drawing.Size(59, 17);
            this.OnionCheckbox.TabIndex = 35;
            this.OnionCheckbox.Text = "Onions";
            this.OnionCheckbox.UseVisualStyleBackColor = true;
            // 
            // GreenPepperCheckbox
            // 
            this.GreenPepperCheckbox.AutoSize = true;
            this.GreenPepperCheckbox.Location = new System.Drawing.Point(6, 113);
            this.GreenPepperCheckbox.Name = "GreenPepperCheckbox";
            this.GreenPepperCheckbox.Size = new System.Drawing.Size(97, 17);
            this.GreenPepperCheckbox.TabIndex = 36;
            this.GreenPepperCheckbox.Text = "Green Peppers";
            this.GreenPepperCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MediumRadioButton);
            this.groupBox2.Controls.Add(this.PersonalRadioButton);
            this.groupBox2.Controls.Add(this.LargeRadioButton);
            this.groupBox2.Controls.Add(this.ExtraLargeRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(20, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 129);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(15, 43);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRadioButton.TabIndex = 28;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // PersonalRadioButton
            // 
            this.PersonalRadioButton.AutoSize = true;
            this.PersonalRadioButton.Checked = true;
            this.PersonalRadioButton.Location = new System.Drawing.Point(15, 19);
            this.PersonalRadioButton.Name = "PersonalRadioButton";
            this.PersonalRadioButton.Size = new System.Drawing.Size(66, 17);
            this.PersonalRadioButton.TabIndex = 26;
            this.PersonalRadioButton.TabStop = true;
            this.PersonalRadioButton.Text = "Personal";
            this.PersonalRadioButton.UseVisualStyleBackColor = true;
            // 
            // LargeRadioButton
            // 
            this.LargeRadioButton.AutoSize = true;
            this.LargeRadioButton.Location = new System.Drawing.Point(15, 67);
            this.LargeRadioButton.Name = "LargeRadioButton";
            this.LargeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.LargeRadioButton.TabIndex = 29;
            this.LargeRadioButton.TabStop = true;
            this.LargeRadioButton.Text = "Large";
            this.LargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExtraLargeRadioButton
            // 
            this.ExtraLargeRadioButton.AutoSize = true;
            this.ExtraLargeRadioButton.Location = new System.Drawing.Point(15, 91);
            this.ExtraLargeRadioButton.Name = "ExtraLargeRadioButton";
            this.ExtraLargeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ExtraLargeRadioButton.TabIndex = 30;
            this.ExtraLargeRadioButton.TabStop = true;
            this.ExtraLargeRadioButton.Text = "Extra Large";
            this.ExtraLargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // PizzaQuantityTextbox
            // 
            this.PizzaQuantityTextbox.Location = new System.Drawing.Point(69, 15);
            this.PizzaQuantityTextbox.Name = "PizzaQuantityTextbox";
            this.PizzaQuantityTextbox.Size = new System.Drawing.Size(20, 20);
            this.PizzaQuantityTextbox.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Quantity";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(369, 186);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 54;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(301, 157);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(199, 23);
            this.NewCustomerButton.TabIndex = 53;
            this.NewCustomerButton.Text = "Clear for New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // NextItemButton
            // 
            this.NextItemButton.Location = new System.Drawing.Point(301, 127);
            this.NextItemButton.Name = "NextItemButton";
            this.NextItemButton.Size = new System.Drawing.Size(199, 23);
            this.NextItemButton.TabIndex = 52;
            this.NextItemButton.Text = "Clear for Next Item";
            this.NextItemButton.UseVisualStyleBackColor = true;
            this.NextItemButton.Click += new System.EventHandler(this.NextItemButton_Click);
            // 
            // Summarybutton
            // 
            this.Summarybutton.Location = new System.Drawing.Point(300, 97);
            this.Summarybutton.Name = "Summarybutton";
            this.Summarybutton.Size = new System.Drawing.Size(200, 23);
            this.Summarybutton.TabIndex = 51;
            this.Summarybutton.Text = "Display Summary";
            this.Summarybutton.UseVisualStyleBackColor = true;
            this.Summarybutton.Click += new System.EventHandler(this.Summarybutton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(300, 68);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(200, 23);
            this.CalculateButton.TabIndex = 50;
            this.CalculateButton.Text = "Calculate Amount for Current Pizza";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayTotalPizzas);
            this.groupBox1.Controls.Add(this.DisplayTotalAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(301, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary:";
            // 
            // DisplayTotalPizzas
            // 
            this.DisplayTotalPizzas.Location = new System.Drawing.Point(140, 30);
            this.DisplayTotalPizzas.Name = "DisplayTotalPizzas";
            this.DisplayTotalPizzas.ReadOnly = true;
            this.DisplayTotalPizzas.Size = new System.Drawing.Size(54, 20);
            this.DisplayTotalPizzas.TabIndex = 3;
            // 
            // DisplayTotalAmount
            // 
            this.DisplayTotalAmount.Location = new System.Drawing.Point(106, 69);
            this.DisplayTotalAmount.Name = "DisplayTotalAmount";
            this.DisplayTotalAmount.ReadOnly = true;
            this.DisplayTotalAmount.Size = new System.Drawing.Size(88, 20);
            this.DisplayTotalAmount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Pizzas Ordered:";
            // 
            // CurrentOrderLabel
            // 
            this.CurrentOrderLabel.AutoSize = true;
            this.CurrentOrderLabel.Location = new System.Drawing.Point(143, 196);
            this.CurrentOrderLabel.Name = "CurrentOrderLabel";
            this.CurrentOrderLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentOrderLabel.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Programmed by Geoff Campbell";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PizzaQuantityTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.NextItemButton);
            this.Controls.Add(this.Summarybutton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentOrderLabel);
            this.Name = "Form1";
            this.Text = "Tony\'s Pizza Shop";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox PepperoniCheckbox;
        private System.Windows.Forms.CheckBox SausageCheckbox;
        private System.Windows.Forms.CheckBox MushroomCheckbox;
        private System.Windows.Forms.CheckBox OnionCheckbox;
        private System.Windows.Forms.CheckBox GreenPepperCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton PersonalRadioButton;
        private System.Windows.Forms.RadioButton LargeRadioButton;
        private System.Windows.Forms.RadioButton ExtraLargeRadioButton;
        private System.Windows.Forms.TextBox PizzaQuantityTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button NextItemButton;
        private System.Windows.Forms.Button Summarybutton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DisplayTotalPizzas;
        private System.Windows.Forms.TextBox DisplayTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CurrentOrderLabel;
        private System.Windows.Forms.Label label3;
    }
}

