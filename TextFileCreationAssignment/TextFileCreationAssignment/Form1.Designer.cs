
namespace TextFileCreationAssignment
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
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.BTNSubmit = new System.Windows.Forms.Button();
            this.LBLOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address: ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(52, 239);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(205, 30);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Phone Number: ";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(133, 69);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(535, 22);
            this.TBName.TabIndex = 3;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(153, 150);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(515, 22);
            this.TBAddress.TabIndex = 4;
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(211, 241);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(242, 22);
            this.TBPhone.TabIndex = 5;
            // 
            // BTNSubmit
            // 
            this.BTNSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSubmit.Location = new System.Drawing.Point(347, 368);
            this.BTNSubmit.Name = "BTNSubmit";
            this.BTNSubmit.Size = new System.Drawing.Size(158, 48);
            this.BTNSubmit.TabIndex = 6;
            this.BTNSubmit.Text = "Store Data";
            this.BTNSubmit.UseVisualStyleBackColor = true;
            this.BTNSubmit.Click += new System.EventHandler(this.BTNSubmit_Click);
            // 
            // LBLOutput
            // 
            this.LBLOutput.AutoSize = true;
            this.LBLOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOutput.Location = new System.Drawing.Point(238, 443);
            this.LBLOutput.Name = "LBLOutput";
            this.LBLOutput.Size = new System.Drawing.Size(387, 25);
            this.LBLOutput.TabIndex = 7;
            this.LBLOutput.Text = "Your information has been written to the file.";
            this.LBLOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 514);
            this.Controls.Add(this.LBLOutput);
            this.Controls.Add(this.BTNSubmit);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.Button BTNSubmit;
        private System.Windows.Forms.Label LBLOutput;
    }
}

