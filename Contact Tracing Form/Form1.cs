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
            this.cmbMonths();
            this.cmbYears();
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
            System.Object[] dates = new System.Object[31];
            for (byte i = 0; i <= 30; i++)
            {
                dates[i] = i + 1;
            }
            cmb_Day.Items.AddRange(dates);

        }


        private void cmb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDays();

        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMonths();
        }

        private void cmbMonths()
        {
            cmb_Month.Items.Add("January");
            cmb_Month.Items.Add("February");
            cmb_Month.Items.Add("March");
            cmb_Month.Items.Add("April");
            cmb_Month.Items.Add("May");
            cmb_Month.Items.Add("June");
            cmb_Month.Items.Add("July");
            cmb_Month.Items.Add("August");
            cmb_Month.Items.Add("September");
            cmb_Month.Items.Add("October");
            cmb_Month.Items.Add("November");
            cmb_Month.Items.Add("December");
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbYears();
        }

        private void cmbYears()
        {
            System.Object[] years = new System.Object[800];
            for (int i = 0; i <= 799; i++)
            {
                years[i] = i + 1900;
            }
            cmb_Year.Items.AddRange(years);
        }

    }
}
