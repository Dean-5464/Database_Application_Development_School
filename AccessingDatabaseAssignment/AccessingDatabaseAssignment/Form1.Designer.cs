
namespace AccessingDatabaseAssignment
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
            this.LBDisplay = new System.Windows.Forms.ListBox();
            this.BTNShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBDisplay
            // 
            this.LBDisplay.FormattingEnabled = true;
            this.LBDisplay.ItemHeight = 16;
            this.LBDisplay.Location = new System.Drawing.Point(99, 56);
            this.LBDisplay.Name = "LBDisplay";
            this.LBDisplay.Size = new System.Drawing.Size(614, 276);
            this.LBDisplay.TabIndex = 0;
            // 
            // BTNShow
            // 
            this.BTNShow.Location = new System.Drawing.Point(285, 357);
            this.BTNShow.Name = "BTNShow";
            this.BTNShow.Size = new System.Drawing.Size(194, 55);
            this.BTNShow.TabIndex = 1;
            this.BTNShow.Text = "Show Sales";
            this.BTNShow.UseVisualStyleBackColor = true;
            this.BTNShow.Click += new System.EventHandler(this.BTNShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNShow);
            this.Controls.Add(this.LBDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBDisplay;
        private System.Windows.Forms.Button BTNShow;
    }
}

