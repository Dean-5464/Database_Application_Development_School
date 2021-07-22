using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_9
{
    public partial class Form1 : Form
    {

        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string SConnection;
        private string sql;

        private OleDbDataAdapter Adapt;
        private DataSet CustomerDs;
        private OleDbCommandBuilder CmdBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //Method Below
            LoadData();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CmdBuilder = new OleDbCommandBuilder(Adapt);
                Adapt.Update(CustomerDs, "CustomerTable");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Update Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Method Below
            LoadData();
        }

        public void LoadData()
        {
            try
            {

                SConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Customers.accdb";

                dbConn = new OleDbConnection(SConnection);
                dbConn.Open();

                sql = "Select * From CustomerTable";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;

                dbCmd.Connection = dbConn;

                Adapt = new OleDbDataAdapter();
                Adapt.SelectCommand = dbCmd;
                CustomerDs = new DataSet();
                Adapt.Fill(CustomerDs, "CustomerTable");
                DisplayGrid.DataSource = CustomerDs;
                DisplayGrid.DataMember = "CustomerTable";


                dbConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred");
            }
        }
    }
}
