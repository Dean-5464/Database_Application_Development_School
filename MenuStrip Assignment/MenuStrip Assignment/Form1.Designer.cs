
namespace MenuStrip_Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.listToppings = new System.Windows.Forms.ListBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.Menustrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.processOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toppings ($1.50 each)";
            // 
            // listToppings
            // 
            this.listToppings.FormattingEnabled = true;
            this.listToppings.ItemHeight = 16;
            this.listToppings.Items.AddRange(new object[] {
            "Sausage",
            "Peperoni",
            "Bacon",
            "Onion",
            "Green Pepper",
            "Extra Cheese"});
            this.listToppings.Location = new System.Drawing.Point(582, 33);
            this.listToppings.Name = "listToppings";
            this.listToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listToppings.Size = new System.Drawing.Size(120, 100);
            this.listToppings.TabIndex = 1;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbSize.Location = new System.Drawing.Point(242, 33);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 24);
            this.cbSize.TabIndex = 2;
            this.cbSize.Text = "Choose Size";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(242, 292);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(76, 17);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Total Price";
            // 
            // Menustrip
            // 
            this.Menustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.Menustrip.Location = new System.Drawing.Point(0, 0);
            this.Menustrip.Name = "Menustrip";
            this.Menustrip.Size = new System.Drawing.Size(800, 28);
            this.Menustrip.TabIndex = 4;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // processOrderToolStripMenuItem
            // 
            this.processOrderToolStripMenuItem.Name = "processOrderToolStripMenuItem";
            this.processOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.processOrderToolStripMenuItem.Text = "ProcessOrder";
            this.processOrderToolStripMenuItem.Click += new System.EventHandler(this.processOrderToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.listToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menustrip);
            this.MainMenuStrip = this.Menustrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStrip Guided Example";
            this.Menustrip.ResumeLayout(false);
            this.Menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listToppings;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.MenuStrip Menustrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem processOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

