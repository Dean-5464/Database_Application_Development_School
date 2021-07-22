
namespace RadioButton_Assignemnt
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
            this.GBBeverages = new System.Windows.Forms.GroupBox();
            this.RBCoke = new System.Windows.Forms.RadioButton();
            this.RBPepsi = new System.Windows.Forms.RadioButton();
            this.RBMTNDew = new System.Windows.Forms.RadioButton();
            this.lbSelection = new System.Windows.Forms.Label();
            this.GBBeverages.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBBeverages
            // 
            this.GBBeverages.Controls.Add(this.RBCoke);
            this.GBBeverages.Controls.Add(this.RBMTNDew);
            this.GBBeverages.Controls.Add(this.RBPepsi);
            this.GBBeverages.Location = new System.Drawing.Point(54, 33);
            this.GBBeverages.Name = "GBBeverages";
            this.GBBeverages.Size = new System.Drawing.Size(200, 130);
            this.GBBeverages.TabIndex = 0;
            this.GBBeverages.TabStop = false;
            this.GBBeverages.Text = "Beverages";
            // 
            // RBCoke
            // 
            this.RBCoke.AutoSize = true;
            this.RBCoke.Location = new System.Drawing.Point(50, 63);
            this.RBCoke.Name = "RBCoke";
            this.RBCoke.Size = new System.Drawing.Size(61, 21);
            this.RBCoke.TabIndex = 1;
            this.RBCoke.TabStop = true;
            this.RBCoke.Text = "Coke";
            this.RBCoke.UseVisualStyleBackColor = true;
            this.RBCoke.Click += new System.EventHandler(this.Beverage_CheckedChanged);
            // 
            // RBPepsi
            // 
            this.RBPepsi.AutoSize = true;
            this.RBPepsi.Location = new System.Drawing.Point(50, 35);
            this.RBPepsi.Name = "RBPepsi";
            this.RBPepsi.Size = new System.Drawing.Size(64, 21);
            this.RBPepsi.TabIndex = 0;
            this.RBPepsi.TabStop = true;
            this.RBPepsi.Text = "Pepsi";
            this.RBPepsi.UseVisualStyleBackColor = true;
            this.RBPepsi.Click += new System.EventHandler(this.Beverage_CheckedChanged);
            // 
            // RBMTNDew
            // 
            this.RBMTNDew.AutoSize = true;
            this.RBMTNDew.Location = new System.Drawing.Point(50, 90);
            this.RBMTNDew.Name = "RBMTNDew";
            this.RBMTNDew.Size = new System.Drawing.Size(118, 21);
            this.RBMTNDew.TabIndex = 1;
            this.RBMTNDew.TabStop = true;
            this.RBMTNDew.Text = "Mountain Dew";
            this.RBMTNDew.UseVisualStyleBackColor = true;
            this.RBMTNDew.Click += new System.EventHandler(this.Beverage_CheckedChanged);
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.Location = new System.Drawing.Point(51, 185);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(66, 17);
            this.lbSelection.TabIndex = 2;
            this.lbSelection.Text = "Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSelection);
            this.Controls.Add(this.GBBeverages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBBeverages.ResumeLayout(false);
            this.GBBeverages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBBeverages;
        private System.Windows.Forms.RadioButton RBCoke;
        private System.Windows.Forms.RadioButton RBPepsi;
        private System.Windows.Forms.RadioButton RBMTNDew;
        private System.Windows.Forms.Label lbSelection;
    }
}

