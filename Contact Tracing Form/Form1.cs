using System;
using System.IO;
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
    public partial class form_Registration : Form
    {
        public form_Registration()
        {
            InitializeComponent();
            this.cmbDays();
            this.cmbMonths();
            this.cmbYears();
            this.cmbAMPM();
        }

        bool f_Name, l_Name, address, day, month, year, contact_Info1, contact_Info2, time, spec_Time = false;

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbx_FName.Text = "";
            txtbx_LName.Text = "";
            txtbx_Address.Text = "";
            txtbx_Gender.Text = "";
            txtbx_Contact1.Text = "";
            txtbx_Contact2.Text = "";
            txtbx_Time.Text = "";
            cmb_Day.Items.Clear();
            cmb_Day.ResetText();
            cmb_Month.Items.Clear();
            cmb_Month.ResetText();
            cmb_Year.Items.Clear();
            cmb_Year.ResetText();
            cmb_AMPM.Items.Clear();
            cmb_AMPM.ResetText();
            lbl_Req1.Visible = false;
            lbl_Req2.Visible = false;
            lbl_Req3.Visible = false;
            lbl_Req5.Visible = false;
            lbl_Req6.Visible = false;
            lbl_Status.Visible = false;
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

        private void txtbx_FName_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_FName.Text == "")
                f_Name = false;
            else
            {
                f_Name = true;
            }
        }

        private void txtbx_LName_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_LName.Text == "")
                l_Name = false;
            else
            {
                l_Name = true;
            }
        }

        private void txtbx_Address_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_Address.Text == "")
                address = false;
            else
            {
                address = true;
            }
        }

        private void txtbx_Contact1_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_Contact1.Text == "")
                contact_Info1 = false;
            else
            {
                contact_Info1 = true;
            }
        }

        private void txtbx_Time_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_Time.Text == "")
                spec_Time = true;
            else
            {
                spec_Time = true;
            }
        }

        private void txtbx_Contact2_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_Contact2.Text == "")
                contact_Info2 = false;
            else
            {
                contact_Info2 = true;
            }
        }

        private void cmb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDays();
            if (cmb_Day.SelectedIndex > -1)
            {
                day = true;
            }
            else
            {
                day = false;
            }
            
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMonths();
            if (cmb_Month.SelectedIndex > -1)
            {
                month = true;
            }
            else
            {
                month = false;
            }
            
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
            if (cmb_Year.SelectedIndex > -1)
            {
                year = true;
            }
            else
            {
                year = false;
            }
        }

        private void cmbYears()
        {
            System.Object[] years = new System.Object[122];
            for (int i = 0; i <= 121; i++)
            {
                years[i] = i + 1930;
            }
            cmb_Year.Items.AddRange(years);
        }

        private void cmb_AMPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAMPM();
            time = true;
        }
        
        private void cmbAMPM()
        {
            cmb_AMPM.Items.Add("AM");
            cmb_AMPM.Items.Add("PM");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (f_Name == false)
            {
                lbl_Req1.Visible = true;
                lbl_Status.Visible = true;
            }
            if(l_Name == false)
            {
                lbl_Req2.Visible = true;
                lbl_Status.Visible = true;
            }
            if(address == false)
            {
                lbl_Req3.Visible = true;
                lbl_Status.Visible = true;
            }
            if (time == false)
            {
                lbl_Req6.Visible = true;
                lbl_Status.Visible = true;
            }
            if (spec_Time == false)
            {
                lbl_Req6.Visible = true;
                lbl_Status.Visible = true;
            }
            if((contact_Info1 == false && contact_Info2 == false))
            { 
                lbl_Req5.Visible = true;
                lbl_Status.Visible = true;
            }
            else
            {

                //Data from user
                StreamWriter savedInfo;
                savedInfo = File.CreateText("saved.txt");
                savedInfo.WriteLine(txtbx_FName.Text +", ");
                savedInfo.WriteLine(txtbx_LName.Text + ", ");
                savedInfo.WriteLine(txtbx_Address.Text + ", ");
                savedInfo.WriteLine("" + cmb_Month.SelectedItem + "" + cmb_Day.SelectedItem + "" + cmb_Year.SelectedItem + ", ");
                savedInfo.WriteLine(txtbx_Gender.Text + ", ");
                savedInfo.WriteLine(txtbx_Contact1.Text + ", ");
                savedInfo.WriteLine(txtbx_Contact2.Text + ", ");
                savedInfo.WriteLine(txtbx_Time.Text + cmb_AMPM.SelectedItem + ", ");
                savedInfo.Close();

                txtbx_FName.Text = "";
                txtbx_LName.Text = "";
                txtbx_Address.Text = "";
                txtbx_Gender.Text = "";
                txtbx_Contact1.Text = "";
                txtbx_Contact2.Text = "";
                txtbx_Time.Text = "";
                cmb_Day.Items.Clear();
                cmb_Day.ResetText();
                cmb_Month.Items.Clear();
                cmb_Month.ResetText();
                cmb_Year.Items.Clear();
                cmb_Year.ResetText();
                cmb_AMPM.Items.Clear();
                cmb_AMPM.ResetText();
                lbl_Req1.Visible = false;
                lbl_Req2.Visible = false;
                lbl_Req3.Visible = false;
                lbl_Req5.Visible = false;
                lbl_Req6.Visible = false;
                lbl_Status.Visible = false;

                this.Hide();

                form_Read f2 = new form_Read();
                f2.ShowDialog();
            }
        }
    }
}
