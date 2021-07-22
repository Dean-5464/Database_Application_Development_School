using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextFileCreationAssignment
{
    public partial class Form1 : Form
    {
        private StreamWriter outFile; //Output (To File)
        private StreamReader inFile; //Input (Text Boxes)

        public String Clear = ""; //Clear String

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                outFile = new StreamWriter(@"../../Info.text", true);
               
                //Name
                if(TBName.TextLength > 0)
                {
                    outFile.WriteLine(TBName.Text);
                }
                TBName.Text = Clear;
                TBName.Focus();

                //Address
                if(TBAddress.TextLength > 0)
                {
                    outFile.WriteLine(TBAddress.Text);
                }

                //Phone Number
                if(TBPhone.TextLength > 0)
                {
                    outFile.WriteLine(TBPhone.Text);
                }

                //Output Updating
                LBLOutput.Visible = true;
                LBLOutput.Text = "Your information has been written to the file.";


                //Catch Statement (No File Created)
            }
            catch (IOException exc)
            {
                TBName.Text = exc.Message;
                LBLOutput.Visible = true;
                LBLOutput.Text = "Error!";
            }

            //Finally Statement
            finally
            {
                outFile.Close();
            }
        }
    }
}
