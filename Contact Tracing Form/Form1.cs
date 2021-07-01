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

        bool f_Name, l_Name, address, age, contact_Info1, contact_Info2, time, spec_Time = false;

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbx_FName.Text = "";
            txtbx_LName.Text = "";
            txtbx_Address.Text = "";
            txtbx_Gender.Text = "";
            txtbx_Contact1.Text = "";
            txtbx_Contact2.Text = "";
            txtbx_Time.Text = "";
            txtbx_Timemin.Text = "";
            txtbx_Age.Text = "";

            cmb_Day.SelectedIndex = -1;
            cmb_Day.ResetText();
            cmb_Month.SelectedIndex = -1;
            cmb_Month.ResetText();
            cmb_Year.SelectedIndex = -1;
            cmb_Year.ResetText();
            cmb_AMPM.SelectedIndex = -1;
            cmb_AMPM.ResetText();
            lbl_Req1.Visible = false;
            lbl_Req2.Visible = false;
            lbl_Req3.Visible = false;
            lbl_Req4.Visible = false;
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
            if (txtbx_Time.Text == "" && txtbx_Timemin.Text == "")
            {
                spec_Time = false;
            }
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
        }

        private void txtbx_Age_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_Age.Text == "")
                age = false;
            else
            {
                age = true;
            }
        }

        private void txtbx_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbx_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbx_Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbx_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtbx_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar >= 1 && e.KeyChar <=9))
            {
                return;
            }
            e.Handled = true;
        }

        private void lbl_Timemin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar >= 0 && e.KeyChar <= 9))
            {
                return;
            }
            e.Handled = true;
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
            System.Object[] years = new System.Object[92];
            for (int i = 0; i <= 91; i++)
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

            if(age == false)
            {
                lbl_Req4.Visible = true;
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
                if (((cmb_Month.SelectedItem.ToString() == "February" || cmb_Month.SelectedItem.ToString() == "April" || cmb_Month.SelectedItem.ToString() == "June" || cmb_Month.SelectedItem.ToString() == "September" || cmb_Month.SelectedItem.ToString() == "November") && cmb_Day.SelectedItem.ToString() == "31"))
                {
                    StreamWriter savedInfo;
                    savedInfo = File.AppendText("saved.txt");
                    savedInfo.WriteLine(txtbx_FName.Text + ", " + txtbx_LName.Text + ", " + txtbx_Address.Text + ", "
                        + "Invalid Birthday " + ", " +
                        txtbx_Gender.Text + ", " + txtbx_Age.Text + "," + txtbx_Contact1.Text + " | " + txtbx_Contact2.Text + ", " + txtbx_Time.Text + ":" + txtbx_Timemin.Text + " " + cmb_AMPM.SelectedItem + ", ");

                    savedInfo.Close();
                    txtbx_FName.Text = "";
                    txtbx_LName.Text = "";
                    txtbx_Address.Text = "";
                    txtbx_Gender.Text = "";
                    txtbx_Contact1.Text = "";
                    txtbx_Contact2.Text = "";
                    txtbx_Time.Text = "";
                    txtbx_Timemin.Text = "";
                    txtbx_Age.Text = "";
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
                    lbl_Req4.Visible = false;
                    lbl_Req5.Visible = false;
                    lbl_Req6.Visible = false;
                    lbl_Status.Visible = false;

                    this.Hide();

                    form_Read f2 = new form_Read();
                    f2.ShowDialog();

                    int hour, min;
                    hour = int.Parse(txtbx_Time.Text);
                    min = int.Parse(txtbx_Timemin.Text);

                    if (hour >= 13 || min >= 60)
                    {
                        savedInfo = File.AppendText("saved.txt");
                        savedInfo.WriteLine(txtbx_FName.Text + ", " + txtbx_LName.Text + ", " + txtbx_Address.Text + ", "
                            + "Invalid Birthday " + ", " +
                            txtbx_Gender.Text + ", " + txtbx_Age.Text + "," + txtbx_Contact1.Text + " | " + txtbx_Contact2.Text + ", " + "Invalid Time" + ", ");

                        savedInfo.Close();
                    }
                }
                else
                {

                    StreamWriter savedInfo;
                    savedInfo = File.AppendText("saved.txt");
                    savedInfo.WriteLine(txtbx_FName.Text + ", " + txtbx_LName.Text + ", " + txtbx_Address.Text + ", "
                        + "" + cmb_Month.SelectedItem + " " + cmb_Day.SelectedItem + " " + cmb_Year.SelectedItem + ", " +
                        txtbx_Gender.Text + ", " + txtbx_Age.Text + "," + txtbx_Contact1.Text + " | " + txtbx_Contact2.Text + ", " + txtbx_Time.Text + ":" + txtbx_Timemin.Text + " " + cmb_AMPM.SelectedItem + ", ");

                    savedInfo.Close();

                    txtbx_FName.Text = "";
                    txtbx_LName.Text = "";
                    txtbx_Address.Text = "";
                    txtbx_Gender.Text = "";
                    txtbx_Contact1.Text = "";
                    txtbx_Contact2.Text = "";
                    txtbx_Time.Text = "";
                    txtbx_Timemin.Text = "";
                    txtbx_Age.Text = "";
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
                    lbl_Req4.Visible = false;
                    lbl_Req5.Visible = false;
                    lbl_Req6.Visible = false;
                    lbl_Status.Visible = false;

                    this.Hide();

                    form_Read f2 = new form_Read();
                    f2.ShowDialog();

                    int hour, min;
                    hour = int.Parse(txtbx_Time.Text);
                    min = int.Parse(txtbx_Timemin.Text);

                    if (hour >= 13 || min >= 60)
                    {
                        savedInfo = File.AppendText("saved.txt");
                        savedInfo.WriteLine(txtbx_FName.Text + ", " + txtbx_LName.Text + ", " + txtbx_Address.Text + ", "
                            + "Invalid Birthday " + ", " +
                            txtbx_Gender.Text + ", " + txtbx_Age.Text + "," + txtbx_Contact1.Text + " | " + txtbx_Contact2.Text + ", " + "Invalid Time" + ", ");

                        savedInfo.Close();
                    }
                }
            }
        }
    }
}
