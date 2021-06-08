using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_Form
{
    public partial class form_Read : Form
    {
       
        public form_Read()
        {
            InitializeComponent();
        }

        private void form_Read_Load(object sender, EventArgs e)
        {
            string[] infoSaved = System.IO.File.ReadAllLines(@"saved.txt");
            string[] info; 

            for(int count = 0; count < infoSaved.Length; count++)
            {
                info = infoSaved[count].ToString().Split(',');

                string[] data = new string[info.Length];

                for(int dataCount = 0; dataCount < info.Length; dataCount++)
                {
                    data[dataCount] = info[dataCount].Trim();
                }

                dg_SavedInfo.Rows.Add(data);
            }

        }

       
    }
}
