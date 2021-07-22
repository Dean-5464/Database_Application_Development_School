
namespace DeanKammerer_Project1
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
            this.TCPrimary = new System.Windows.Forms.TabControl();
            this.PizzaTab = new System.Windows.Forms.TabPage();
            this.BeverageTab = new System.Windows.Forms.TabPage();
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtherItemsTab = new System.Windows.Forms.TabPage();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.BTNReset = new System.Windows.Forms.Button();
            this.BTNSubmit = new System.Windows.Forms.Button();
            this.SizeOptions = new System.Windows.Forms.GroupBox();
            this.RBSmall = new System.Windows.Forms.RadioButton();
            this.RBMedium = new System.Windows.Forms.RadioButton();
            this.RBLarge = new System.Windows.Forms.RadioButton();
            this.LBToppings = new System.Windows.Forms.ListBox();
            this.LBLToppings = new System.Windows.Forms.Label();
            this.CBSoda = new System.Windows.Forms.ComboBox();
            this.LBLSoda = new System.Windows.Forms.Label();
            this.CBWater = new System.Windows.Forms.ComboBox();
            this.LBLWater = new System.Windows.Forms.Label();
            this.LBQuantity = new System.Windows.Forms.Label();
            this.LBLBeverageInfo = new System.Windows.Forms.Label();
            this.GroupOther = new System.Windows.Forms.GroupBox();
            this.CBWings = new System.Windows.Forms.CheckBox();
            this.CBCheeseSticks = new System.Windows.Forms.CheckBox();
            this.CBGarlicBread = new System.Windows.Forms.CheckBox();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLPhone = new System.Windows.Forms.Label();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBLPhone = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCPrimary.SuspendLayout();
            this.PizzaTab.SuspendLayout();
            this.BeverageTab.SuspendLayout();
            this.MSMain.SuspendLayout();
            this.OtherItemsTab.SuspendLayout();
            this.CustomerTab.SuspendLayout();
            this.SizeOptions.SuspendLayout();
            this.GroupOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCPrimary
            // 
            this.TCPrimary.Controls.Add(this.PizzaTab);
            this.TCPrimary.Controls.Add(this.BeverageTab);
            this.TCPrimary.Controls.Add(this.OtherItemsTab);
            this.TCPrimary.Controls.Add(this.CustomerTab);
            this.TCPrimary.Location = new System.Drawing.Point(0, 31);
            this.TCPrimary.Name = "TCPrimary";
            this.TCPrimary.SelectedIndex = 0;
            this.TCPrimary.Size = new System.Drawing.Size(563, 371);
            this.TCPrimary.TabIndex = 0;
            // 
            // PizzaTab
            // 
            this.PizzaTab.Controls.Add(this.LBLToppings);
            this.PizzaTab.Controls.Add(this.LBToppings);
            this.PizzaTab.Controls.Add(this.SizeOptions);
            this.PizzaTab.Location = new System.Drawing.Point(4, 25);
            this.PizzaTab.Name = "PizzaTab";
            this.PizzaTab.Padding = new System.Windows.Forms.Padding(3);
            this.PizzaTab.Size = new System.Drawing.Size(555, 342);
            this.PizzaTab.TabIndex = 0;
            this.PizzaTab.Text = "Pizza";
            this.PizzaTab.UseVisualStyleBackColor = true;
            // 
            // BeverageTab
            // 
            this.BeverageTab.Controls.Add(this.LBLBeverageInfo);
            this.BeverageTab.Controls.Add(this.LBQuantity);
            this.BeverageTab.Controls.Add(this.LBLWater);
            this.BeverageTab.Controls.Add(this.CBWater);
            this.BeverageTab.Controls.Add(this.LBLSoda);
            this.BeverageTab.Controls.Add(this.CBSoda);
            this.BeverageTab.Location = new System.Drawing.Point(4, 25);
            this.BeverageTab.Name = "BeverageTab";
            this.BeverageTab.Padding = new System.Windows.Forms.Padding(3);
            this.BeverageTab.Size = new System.Drawing.Size(555, 342);
            this.BeverageTab.TabIndex = 1;
            this.BeverageTab.Text = "Berverages";
            this.BeverageTab.UseVisualStyleBackColor = true;
            // 
            // MSMain
            // 
            this.MSMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Size = new System.Drawing.Size(569, 30);
            this.MSMain.TabIndex = 1;
            this.MSMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OtherItemsTab
            // 
            this.OtherItemsTab.Controls.Add(this.GroupOther);
            this.OtherItemsTab.Location = new System.Drawing.Point(4, 25);
            this.OtherItemsTab.Name = "OtherItemsTab";
            this.OtherItemsTab.Size = new System.Drawing.Size(555, 342);
            this.OtherItemsTab.TabIndex = 2;
            this.OtherItemsTab.Text = "Other Items";
            this.OtherItemsTab.UseVisualStyleBackColor = true;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.TBEmail);
            this.CustomerTab.Controls.Add(this.TBLPhone);
            this.CustomerTab.Controls.Add(this.TBName);
            this.CustomerTab.Controls.Add(this.LBLEmail);
            this.CustomerTab.Controls.Add(this.LBLPhone);
            this.CustomerTab.Controls.Add(this.LBLName);
            this.CustomerTab.Location = new System.Drawing.Point(4, 25);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Size = new System.Drawing.Size(555, 342);
            this.CustomerTab.TabIndex = 3;
            this.CustomerTab.Text = "Customer Info";
            this.CustomerTab.UseVisualStyleBackColor = true;
            // 
            // BTNReset
            // 
            this.BTNReset.Location = new System.Drawing.Point(64, 408);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(113, 30);
            this.BTNReset.TabIndex = 2;
            this.BTNReset.Text = "Reset Order";
            this.BTNReset.UseVisualStyleBackColor = true;
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.Location = new System.Drawing.Point(394, 404);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.Size = new System.Drawing.Size(132, 30);
            this.BTNSubmit.TabIndex = 3;
            this.BTNSubmit.Text = "Place Order";
            this.BTNSubmit.UseVisualStyleBackColor = true;
            // 
            // SizeOptions
            // 
            this.SizeOptions.Controls.Add(this.RBLarge);
            this.SizeOptions.Controls.Add(this.RBMedium);
            this.SizeOptions.Controls.Add(this.RBSmall);
            this.SizeOptions.Location = new System.Drawing.Point(60, 44);
            this.SizeOptions.Name = "SizeOptions";
            this.SizeOptions.Size = new System.Drawing.Size(161, 151);
            this.SizeOptions.TabIndex = 0;
            this.SizeOptions.TabStop = false;
            this.SizeOptions.Text = "Size";
            // 
            // RBSmall
            // 
            this.RBSmall.AutoSize = true;
            this.RBSmall.Location = new System.Drawing.Point(7, 32);
            this.RBSmall.Name = "RBSmall";
            this.RBSmall.Size = new System.Drawing.Size(63, 21);
            this.RBSmall.TabIndex = 0;
            this.RBSmall.TabStop = true;
            this.RBSmall.Text = "Small";
            this.RBSmall.UseVisualStyleBackColor = true;
            // 
            // RBMedium
            // 
            this.RBMedium.AutoSize = true;
            this.RBMedium.Location = new System.Drawing.Point(7, 69);
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.Size = new System.Drawing.Size(78, 21);
            this.RBMedium.TabIndex = 1;
            this.RBMedium.TabStop = true;
            this.RBMedium.Text = "Medium";
            this.RBMedium.UseVisualStyleBackColor = true;
            // 
            // RBLarge
            // 
            this.RBLarge.AutoSize = true;
            this.RBLarge.Location = new System.Drawing.Point(7, 109);
            this.RBLarge.Name = "RBLarge";
            this.RBLarge.Size = new System.Drawing.Size(66, 21);
            this.RBLarge.TabIndex = 2;
            this.RBLarge.TabStop = true;
            this.RBLarge.Text = "Large";
            this.RBLarge.UseVisualStyleBackColor = true;
            // 
            // LBToppings
            // 
            this.LBToppings.FormattingEnabled = true;
            this.LBToppings.ItemHeight = 16;
            this.LBToppings.Items.AddRange(new object[] {
            "Black Olives",
            "Extra Cheese",
            "Garlic",
            "Green Olives",
            "Green Peppers",
            "Mushrooms",
            "Onions",
            "Pepperoni",
            "Pinapple",
            "Sausage",
            "Spinach"});
            this.LBToppings.Location = new System.Drawing.Point(386, 44);
            this.LBToppings.Name = "LBToppings";
            this.LBToppings.Size = new System.Drawing.Size(136, 180);
            this.LBToppings.TabIndex = 1;
            // 
            // LBLToppings
            // 
            this.LBLToppings.AutoSize = true;
            this.LBLToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLToppings.ForeColor = System.Drawing.Color.Blue;
            this.LBLToppings.Location = new System.Drawing.Point(382, 21);
            this.LBLToppings.Name = "LBLToppings";
            this.LBLToppings.Size = new System.Drawing.Size(149, 20);
            this.LBLToppings.TabIndex = 2;
            this.LBLToppings.Text = "Toppings - $1.50";
            // 
            // CBSoda
            // 
            this.CBSoda.FormattingEnabled = true;
            this.CBSoda.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBSoda.Location = new System.Drawing.Point(235, 101);
            this.CBSoda.Name = "CBSoda";
            this.CBSoda.Size = new System.Drawing.Size(121, 24);
            this.CBSoda.TabIndex = 0;
            // 
            // LBLSoda
            // 
            this.LBLSoda.AutoSize = true;
            this.LBLSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSoda.ForeColor = System.Drawing.Color.Blue;
            this.LBLSoda.Location = new System.Drawing.Point(138, 104);
            this.LBLSoda.Name = "LBLSoda";
            this.LBLSoda.Size = new System.Drawing.Size(65, 17);
            this.LBLSoda.TabIndex = 1;
            this.LBLSoda.Text = "Soda(s)";
            // 
            // CBWater
            // 
            this.CBWater.FormattingEnabled = true;
            this.CBWater.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBWater.Location = new System.Drawing.Point(235, 164);
            this.CBWater.Name = "CBWater";
            this.CBWater.Size = new System.Drawing.Size(121, 24);
            this.CBWater.TabIndex = 2;
            // 
            // LBLWater
            // 
            this.LBLWater.AutoSize = true;
            this.LBLWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLWater.ForeColor = System.Drawing.Color.Blue;
            this.LBLWater.Location = new System.Drawing.Point(138, 167);
            this.LBLWater.Name = "LBLWater";
            this.LBLWater.Size = new System.Drawing.Size(71, 17);
            this.LBLWater.TabIndex = 3;
            this.LBLWater.Text = "Water(s)";
            // 
            // LBQuantity
            // 
            this.LBQuantity.AutoSize = true;
            this.LBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBQuantity.Location = new System.Drawing.Point(242, 67);
            this.LBQuantity.Name = "LBQuantity";
            this.LBQuantity.Size = new System.Drawing.Size(70, 18);
            this.LBQuantity.TabIndex = 4;
            this.LBQuantity.Text = "Quantity";
            // 
            // LBLBeverageInfo
            // 
            this.LBLBeverageInfo.AutoSize = true;
            this.LBLBeverageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBeverageInfo.ForeColor = System.Drawing.Color.Blue;
            this.LBLBeverageInfo.Location = new System.Drawing.Point(117, 229);
            this.LBLBeverageInfo.Name = "LBLBeverageInfo";
            this.LBLBeverageInfo.Size = new System.Drawing.Size(300, 20);
            this.LBLBeverageInfo.TabIndex = 5;
            this.LBLBeverageInfo.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // GroupOther
            // 
            this.GroupOther.Controls.Add(this.CBGarlicBread);
            this.GroupOther.Controls.Add(this.CBCheeseSticks);
            this.GroupOther.Controls.Add(this.CBWings);
            this.GroupOther.Location = new System.Drawing.Point(148, 49);
            this.GroupOther.Name = "GroupOther";
            this.GroupOther.Size = new System.Drawing.Size(200, 231);
            this.GroupOther.TabIndex = 0;
            this.GroupOther.TabStop = false;
            this.GroupOther.Text = "Choose Other Items";
            // 
            // CBWings
            // 
            this.CBWings.AutoSize = true;
            this.CBWings.Location = new System.Drawing.Point(19, 43);
            this.CBWings.Name = "CBWings";
            this.CBWings.Size = new System.Drawing.Size(118, 21);
            this.CBWings.TabIndex = 0;
            this.CBWings.Text = "Wings - $5.00";
            this.CBWings.UseVisualStyleBackColor = true;
            // 
            // CBCheeseSticks
            // 
            this.CBCheeseSticks.AutoSize = true;
            this.CBCheeseSticks.Location = new System.Drawing.Point(19, 105);
            this.CBCheeseSticks.Name = "CBCheeseSticks";
            this.CBCheeseSticks.Size = new System.Drawing.Size(168, 21);
            this.CBCheeseSticks.TabIndex = 1;
            this.CBCheeseSticks.Text = "Cheese Sticks - $4.00";
            this.CBCheeseSticks.UseVisualStyleBackColor = true;
            // 
            // CBGarlicBread
            // 
            this.CBGarlicBread.AutoSize = true;
            this.CBGarlicBread.Location = new System.Drawing.Point(19, 167);
            this.CBGarlicBread.Name = "CBGarlicBread";
            this.CBGarlicBread.Size = new System.Drawing.Size(158, 21);
            this.CBGarlicBread.TabIndex = 2;
            this.CBGarlicBread.Text = "Garlic Bread - $3.00";
            this.CBGarlicBread.UseVisualStyleBackColor = true;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLName.ForeColor = System.Drawing.Color.Blue;
            this.LBLName.Location = new System.Drawing.Point(9, 37);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(69, 20);
            this.LBLName.TabIndex = 0;
            this.LBLName.Text = "Name: ";
            // 
            // LBLPhone
            // 
            this.LBLPhone.AutoSize = true;
            this.LBLPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPhone.ForeColor = System.Drawing.Color.Blue;
            this.LBLPhone.Location = new System.Drawing.Point(10, 129);
            this.LBLPhone.Name = "LBLPhone";
            this.LBLPhone.Size = new System.Drawing.Size(73, 20);
            this.LBLPhone.TabIndex = 1;
            this.LBLPhone.Text = "Phone: ";
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.ForeColor = System.Drawing.Color.Blue;
            this.LBLEmail.Location = new System.Drawing.Point(10, 218);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(68, 20);
            this.LBLEmail.TabIndex = 2;
            this.LBLEmail.Text = "Email: ";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(85, 37);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(242, 22);
            this.TBName.TabIndex = 3;
            // 
            // TBLPhone
            // 
            this.TBLPhone.Location = new System.Drawing.Point(90, 129);
            this.TBLPhone.Name = "TBLPhone";
            this.TBLPhone.Size = new System.Drawing.Size(193, 22);
            this.TBLPhone.TabIndex = 4;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(90, 218);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(237, 22);
            this.TBEmail.TabIndex = 5;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.TCPrimary);
            this.Controls.Add(this.MSMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATC Pizza";
            this.TCPrimary.ResumeLayout(false);
            this.PizzaTab.ResumeLayout(false);
            this.PizzaTab.PerformLayout();
            this.BeverageTab.ResumeLayout(false);
            this.BeverageTab.PerformLayout();
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            this.OtherItemsTab.ResumeLayout(false);
            this.CustomerTab.ResumeLayout(false);
            this.CustomerTab.PerformLayout();
            this.SizeOptions.ResumeLayout(false);
            this.SizeOptions.PerformLayout();
            this.GroupOther.ResumeLayout(false);
            this.GroupOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCPrimary;
        private System.Windows.Forms.TabPage PizzaTab;
        private System.Windows.Forms.TabPage BeverageTab;
        private System.Windows.Forms.TabPage OtherItemsTab;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label LBLToppings;
        private System.Windows.Forms.ListBox LBToppings;
        private System.Windows.Forms.GroupBox SizeOptions;
        private System.Windows.Forms.RadioButton RBLarge;
        private System.Windows.Forms.RadioButton RBMedium;
        private System.Windows.Forms.RadioButton RBSmall;
        private System.Windows.Forms.Label LBLBeverageInfo;
        private System.Windows.Forms.Label LBQuantity;
        private System.Windows.Forms.Label LBLWater;
        private System.Windows.Forms.ComboBox CBWater;
        private System.Windows.Forms.Label LBLSoda;
        private System.Windows.Forms.ComboBox CBSoda;
        private System.Windows.Forms.GroupBox GroupOther;
        private System.Windows.Forms.CheckBox CBGarlicBread;
        private System.Windows.Forms.CheckBox CBCheeseSticks;
        private System.Windows.Forms.CheckBox CBWings;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBLPhone;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.Label LBLPhone;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BTNReset;
        private System.Windows.Forms.Button BTNSubmit;
    }
}

