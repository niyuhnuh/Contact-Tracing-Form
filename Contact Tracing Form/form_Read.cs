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

            List<string> info = new List<string>();
            using (StreamReader readInfo = File.OpenText("saved.txt"))
            {
                while(!readInfo.EndOfStream)
                {
                    info.Add(readInfo.ReadLine());
                }
            }

            dg_SavedInfo.DataSource = tb_SavedInfo;

            tb_SavedInfo.Columns.Add("First Name");
            tb_SavedInfo.Columns.Add("Last Name");
            tb_SavedInfo.Columns.Add("Address");
            tb_SavedInfo.Columns.Add("Birthday");
            tb_SavedInfo.Columns.Add("Gender (Optional)");
            tb_SavedInfo.Columns.Add("Contact Info");
            tb_SavedInfo.Columns.Add("Time Logged");
        }
    }
}
