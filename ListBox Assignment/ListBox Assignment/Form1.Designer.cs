
namespace ListBox_Assignment
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
            this.listitems = new System.Windows.Forms.ListBox();
            this.IbTotalCost = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.IbSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listitems
            // 
            this.listitems.FormattingEnabled = true;
            this.listitems.ItemHeight = 16;
            this.listitems.Items.AddRange(new object[] {
            "Coke",
            "Pepsi",
            "Mountain Dew",
            "Diet Coke",
            "Diet Pepsi"});
            this.listitems.Location = new System.Drawing.Point(223, 95);
            this.listitems.Name = "listitems";
            this.listitems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listitems.Size = new System.Drawing.Size(121, 84);
            this.listitems.TabIndex = 0;
            this.listitems.SelectedIndexChanged += new System.EventHandler(this.listitems_SelectedIndexChanged);
            // 
            // IbTotalCost
            // 
            this.IbTotalCost.AutoSize = true;
            this.IbTotalCost.Location = new System.Drawing.Point(223, 196);
            this.IbTotalCost.Name = "IbTotalCost";
            this.IbTotalCost.Size = new System.Drawing.Size(108, 17);
            this.IbTotalCost.TabIndex = 1;
            this.IbTotalCost.Text = "$1.75 per bottle";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "Coke",
            "Pepsi",
            "Mountain Dew",
            "Diet Coke",
            "Diet Pepsi"});
            this.cbItems.Location = new System.Drawing.Point(483, 95);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 24);
            this.cbItems.TabIndex = 2;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // IbSelection
            // 
            this.IbSelection.AutoSize = true;
            this.IbSelection.Location = new System.Drawing.Point(483, 196);
            this.IbSelection.Name = "IbSelection";
            this.IbSelection.Size = new System.Drawing.Size(100, 17);
            this.IbSelection.TabIndex = 3;
            this.IbSelection.Text = "Your Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IbSelection);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.IbTotalCost);
            this.Controls.Add(this.listitems);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox and ComboBox Control Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listitems;
        private System.Windows.Forms.Label IbTotalCost;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label IbSelection;
    }
}

