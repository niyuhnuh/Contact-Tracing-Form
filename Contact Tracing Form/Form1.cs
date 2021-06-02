using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.cmbDays();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbx_FName.Text = "";
            txtbx_LName.Text = "";
            txtbx_Address.Text = "";
            txtbx_Gender.Text = "";
            txtbx_Contact1.Text = "";
            txtbx_Contact2.Text = "";
            txtbx_Time.Text = "";
        }

       private void cmbDays()
        {
            System.Object[] dates = new System.Object[32];
            for (int i = 0; i <= 31; i++)
            {
                dates[i] = i;
            }
            cmb_Day.Items.AddRange(dates);

       }
        private void cmb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDays();
        }
    }
}
