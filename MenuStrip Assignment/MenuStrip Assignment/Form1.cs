using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processOrderToolStripMenuItem_Click(object sender, EventArgs e)
         {
                double totalPrice = 0.00;
                const double SMALL = 9.00;
                const double MEDIUM = 11.00;
                const double LARGE = 13.00;
                const double TOPPING = 1.50;
                if (cbSize.Text.Equals("Small"))
                {
                    totalPrice += SMALL;
                }
                else if (cbSize.Text.Equals("Medium"))
                {
                    totalPrice += MEDIUM;
                }
                else if (cbSize.Text.Equals("Large"))
                {
                    totalPrice += LARGE;
                }
                foreach (string activity in listToppings.SelectedItems)
                {
                    totalPrice += TOPPING;
                }
                lbPrice.Text = "Total Price is " + totalPrice.ToString("C");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
