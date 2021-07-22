using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_Assignemnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Beverage_CheckedChanged(Object sender, EventArgs e)
        {
            if (RBPepsi.Checked)
            {
                lbSelection.Text = "Pepsi";
            }
            else if (RBCoke.Checked)
            {
                lbSelection.Text = RBCoke.Text;
            }
            else if (RBMTNDew.Checked)
            {
                lbSelection.Text = RBMTNDew.Text;
            }
        }
    }
}
