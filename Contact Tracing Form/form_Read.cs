﻿using System;
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
            DataTable savedInfo = new DataTable("Saved Information");

            List<string> info = new List<string>();
            using (StreamReader readInfo = File.OpenText(@"saved.txt"))
            {
                while (!readInfo.EndOfStream)
                {
                    info.Add(readInfo.ReadLine());

                }
            }
            //string[] info_Saved = info.ToArray();
            string[] info_Saved = { "First Name", "Last Name", "Address", "Birthdate",
                                    "Gender", "Contact Info1", "Contact Info2", "Time Logged", "ABC"};


            DataColumn col;

            col = new DataColumn();
            col.ColumnName = "First Name";



            //foreach (string column_Name in info_Saved)
            {
               

                //StreamWriter columns;
                //columns = File.CreateText("col.txt");
                //columns.WriteLine(column_Name);
                //columns.Close();

                //string[] info_Rows = new string[data.Length];
               // for (int y = 0; y < data.Length; y++)
                {
                   // info_Rows[y] = data[y].Trim();
                   // savedInfo.Rows.Add(info_Rows);
                }
                
            }

        }
    }
}
