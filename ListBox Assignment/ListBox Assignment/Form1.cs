using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string totalCost;
            int numItemsSelected = 0;
            const double COST_PER_ITEM = 1.75;
            foreach (string activity in listitems.SelectedItems)
            {
                numItemsSelected++;
            }
            totalCost = (numItemsSelected * COST_PER_ITEM).ToString("C");
            this.IbTotalCost.Text = totalCost;
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.cbItems.Text;
        }
    }
}
