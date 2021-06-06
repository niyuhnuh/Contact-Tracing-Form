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

            List<string> info = new List<string>();
            using (StreamReader readInfo = File.OpenText(@"C:\Users\Annie-Max\source\repos\Contact Tracing Form\Contact Tracing Form\bin\Debug\netcoreapp3.1"))
            {
                while (!readInfo.EndOfStream)
                {
                    info.Add(readInfo.ReadLine());

                }
            }
            string[] info_Saved = info.ToArray();
            string[] data;
            for (int x = 0; x < info_Saved.Length; x++)
            {
                data = info_Saved[x].ToString().Split(',');
            }

        }
    }
}
