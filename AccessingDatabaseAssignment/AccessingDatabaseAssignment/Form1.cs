using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AccessingDatabaseAssignment
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;
        string connectionString;
        string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNShow_Click(object sender, EventArgs e)
        {
            //Try Statement (Try To Connect To Database)
            try
            {

                connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = QuarterlySales; Integrated Security = true";

                connection = new SqlConnection(connectionString);
                //Must Close Connection Before Opening Another
                connection.Open();

                sql = "select Quarter, Year, Amount from Sales";
                command = new SqlCommand(sql, connection);

                dataReader = command.ExecuteReader();

                this.LBDisplay.Items.Clear();
                String value;
                while (dataReader.Read())
                {
                    value = dataReader.GetValue(0) + "\t" + dataReader.GetValue(1) + "\t" + dataReader.GetValue(2);

                    this.LBDisplay.Items.Add(value);
                }

                //Termination of Connections
                dataReader.Close();
                command.Dispose();
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
