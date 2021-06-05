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
        public DataTable tb_SavedInfo = new DataTable("Saved Information");
       
        public form_Read()
        {
            InitializeComponent();
        }

        private void form_Read_Load(object sender, EventArgs e)
        {
            DataTable saved = new DataTable();
            string[] column_Names = new string[] { "First Name", "Last Name", "Address", "Birthdate", "Gender", "Contact Information", "Time Logged"};

            List<string> info = new List<string>();
            using (StreamReader readInfo = File.OpenText(@"C:\Users\Annie-Max\source\repos\Contact Tracing Form\Contact Tracing Form\bin\Debug\netcoreapp3.1"))
            {
                while (!readInfo.EndOfStream)
                {
                    info.Add(readInfo.ReadLine());
                    for(int x = 0; x < 8; x++)
                    {
                        col
                    }
                }
            }

        }
    }
}
