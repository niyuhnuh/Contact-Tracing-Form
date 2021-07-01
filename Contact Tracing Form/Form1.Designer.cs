
namespace Contact_Tracing_Form
{
    partial class form_Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.cmb_Day = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.txtbx_LName = new System.Windows.Forms.TextBox();
            this.txtbx_Address = new System.Windows.Forms.TextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.txtbx_Contact1 = new System.Windows.Forms.TextBox();
            this.txtbx_Contact2 = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txtbx_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.txtbx_Time = new System.Windows.Forms.TextBox();
            this.cmb_AMPM = new System.Windows.Forms.ComboBox();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txtbx_FName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Req1 = new System.Windows.Forms.Label();
            this.lbl_Req2 = new System.Windows.Forms.Label();
            this.lbl_Req3 = new System.Windows.Forms.Label();
            this.lbl_Req5 = new System.Windows.Forms.Label();
            this.lbl_Req6 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.txtbx_Age = new System.Windows.Forms.TextBox();
            this.lbl_Req4 = new System.Windows.Forms.Label();
            this.lbl_Timemin = new System.Windows.Forms.TextBox();
            this.lbl_Colon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(49, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(374, 41);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Contact Tracing Form";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LName.Location = new System.Drawing.Point(66, 111);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(114, 22);
            this.lbl_LName.TabIndex = 1;
            this.lbl_LName.Text = "Last Name:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.Location = new System.Drawing.Point(86, 142);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(100, 22);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address: ";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Birthday.Location = new System.Drawing.Point(49, 175);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(137, 22);
            this.lbl_Birthday.TabIndex = 3;
            this.lbl_Birthday.Text = "Date of Birth: ";
            // 
            // cmb_Day
            // 
            this.cmb_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Day.FormattingEnabled = true;
            this.cmb_Day.Location = new System.Drawing.Point(191, 175);
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(46, 23);
            this.cmb_Day.TabIndex = 4;
            this.cmb_Day.SelectedIndexChanged += new System.EventHandler(this.cmb_Day_SelectedIndexChanged);
            // 
            // cmb_Month
            // 
            this.cmb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Location = new System.Drawing.Point(242, 175);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(77, 23);
            this.cmb_Month.TabIndex = 5;
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(324, 175);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(56, 23);
            this.cmb_Year.TabIndex = 6;
            this.cmb_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Year_SelectedIndexChanged);
            // 
            // txtbx_LName
            // 
            this.txtbx_LName.Location = new System.Drawing.Point(191, 111);
            this.txtbx_LName.Name = "txtbx_LName";
            this.txtbx_LName.Size = new System.Drawing.Size(232, 23);
            this.txtbx_LName.TabIndex = 7;
            this.txtbx_LName.TextChanged += new System.EventHandler(this.txtbx_LName_TextChanged);
            this.txtbx_LName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_LName_KeyPress);
            // 
            // txtbx_Address
            // 
            this.txtbx_Address.Location = new System.Drawing.Point(191, 143);
            this.txtbx_Address.Name = "txtbx_Address";
            this.txtbx_Address.Size = new System.Drawing.Size(232, 23);
            this.txtbx_Address.TabIndex = 8;
            this.txtbx_Address.TextChanged += new System.EventHandler(this.txtbx_Address_TextChanged);
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contact.Location = new System.Drawing.Point(52, 233);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(129, 22);
            this.lbl_Contact.TabIndex = 9;
            this.lbl_Contact.Text = "Contact Info:";
            // 
            // txtbx_Contact1
            // 
            this.txtbx_Contact1.Location = new System.Drawing.Point(191, 233);
            this.txtbx_Contact1.Name = "txtbx_Contact1";
            this.txtbx_Contact1.Size = new System.Drawing.Size(111, 23);
            this.txtbx_Contact1.TabIndex = 10;
            this.txtbx_Contact1.TextChanged += new System.EventHandler(this.txtbx_Contact1_TextChanged);
            // 
            // txtbx_Contact2
            // 
            this.txtbx_Contact2.Location = new System.Drawing.Point(312, 233);
            this.txtbx_Contact2.Name = "txtbx_Contact2";
            this.txtbx_Contact2.Size = new System.Drawing.Size(111, 23);
            this.txtbx_Contact2.TabIndex = 11;
            this.txtbx_Contact2.TextChanged += new System.EventHandler(this.txtbx_Contact2_TextChanged);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gender.Location = new System.Drawing.Point(94, 205);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(86, 22);
            this.lbl_Gender.TabIndex = 12;
            this.lbl_Gender.Text = "Gender:";
            // 
            // txtbx_Gender
            // 
            this.txtbx_Gender.Location = new System.Drawing.Point(191, 204);
            this.txtbx_Gender.Name = "txtbx_Gender";
            this.txtbx_Gender.Size = new System.Drawing.Size(111, 23);
            this.txtbx_Gender.TabIndex = 13;
            this.txtbx_Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Gender_KeyPress);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time.Location = new System.Drawing.Point(118, 262);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(68, 22);
            this.lbl_Time.TabIndex = 14;
            this.lbl_Time.Text = "Time: ";
            // 
            // txtbx_Time
            // 
            this.txtbx_Time.Location = new System.Drawing.Point(191, 262);
            this.txtbx_Time.Name = "txtbx_Time";
            this.txtbx_Time.Size = new System.Drawing.Size(32, 23);
            this.txtbx_Time.TabIndex = 15;
            this.txtbx_Time.TextChanged += new System.EventHandler(this.txtbx_Time_TextChanged);
            this.txtbx_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Time_KeyPress);
            // 
            // cmb_AMPM
            // 
            this.cmb_AMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AMPM.FormattingEnabled = true;
            this.cmb_AMPM.Location = new System.Drawing.Point(280, 261);
            this.cmb_AMPM.Name = "cmb_AMPM";
            this.cmb_AMPM.Size = new System.Drawing.Size(46, 23);
            this.cmb_AMPM.TabIndex = 16;
            this.cmb_AMPM.SelectedIndexChanged += new System.EventHandler(this.cmb_AMPM_SelectedIndexChanged);
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_FName.Location = new System.Drawing.Point(65, 81);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(116, 22);
            this.lbl_FName.TabIndex = 17;
            this.lbl_FName.Text = "First Name:";
            // 
            // txtbx_FName
            // 
            this.txtbx_FName.Location = new System.Drawing.Point(191, 82);
            this.txtbx_FName.Name = "txtbx_FName";
            this.txtbx_FName.Size = new System.Drawing.Size(232, 23);
            this.txtbx_FName.TabIndex = 18;
            this.txtbx_FName.TextChanged += new System.EventHandler(this.txtbx_FName_TextChanged);
            this.txtbx_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_FName_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(348, 308);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(267, 308);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Req1
            // 
            this.lbl_Req1.AutoSize = true;
            this.lbl_Req1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req1.Location = new System.Drawing.Point(429, 85);
            this.lbl_Req1.Name = "lbl_Req1";
            this.lbl_Req1.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req1.TabIndex = 21;
            this.lbl_Req1.Text = "*";
            this.lbl_Req1.Visible = false;
            // 
            // lbl_Req2
            // 
            this.lbl_Req2.AutoSize = true;
            this.lbl_Req2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req2.Location = new System.Drawing.Point(429, 115);
            this.lbl_Req2.Name = "lbl_Req2";
            this.lbl_Req2.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req2.TabIndex = 22;
            this.lbl_Req2.Text = "*";
            this.lbl_Req2.Visible = false;
            // 
            // lbl_Req3
            // 
            this.lbl_Req3.AutoSize = true;
            this.lbl_Req3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req3.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req3.Location = new System.Drawing.Point(429, 146);
            this.lbl_Req3.Name = "lbl_Req3";
            this.lbl_Req3.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req3.TabIndex = 23;
            this.lbl_Req3.Text = "*";
            this.lbl_Req3.Visible = false;
            // 
            // lbl_Req5
            // 
            this.lbl_Req5.AutoSize = true;
            this.lbl_Req5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req5.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req5.Location = new System.Drawing.Point(429, 234);
            this.lbl_Req5.Name = "lbl_Req5";
            this.lbl_Req5.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req5.TabIndex = 25;
            this.lbl_Req5.Text = "*";
            this.lbl_Req5.Visible = false;
            // 
            // lbl_Req6
            // 
            this.lbl_Req6.AutoSize = true;
            this.lbl_Req6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req6.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req6.Location = new System.Drawing.Point(332, 260);
            this.lbl_Req6.Name = "lbl_Req6";
            this.lbl_Req6.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req6.TabIndex = 26;
            this.lbl_Req6.Text = "*";
            this.lbl_Req6.Visible = false;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Location = new System.Drawing.Point(12, 293);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(211, 38);
            this.lbl_Status.TabIndex = 27;
            this.lbl_Status.Text = "* Required fields. \r\nPlease do not leave empty.";
            this.lbl_Status.Visible = false;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Age.Location = new System.Drawing.Point(308, 205);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(53, 22);
            this.lbl_Age.TabIndex = 28;
            this.lbl_Age.Text = "Age:";
            // 
            // txtbx_Age
            // 
            this.txtbx_Age.Location = new System.Drawing.Point(363, 204);
            this.txtbx_Age.Name = "txtbx_Age";
            this.txtbx_Age.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbx_Age.Size = new System.Drawing.Size(60, 23);
            this.txtbx_Age.TabIndex = 29;
            this.txtbx_Age.TextChanged += new System.EventHandler(this.txtbx_Age_TextChanged);
            this.txtbx_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_Age_KeyPress);
            // 
            // lbl_Req4
            // 
            this.lbl_Req4.AutoSize = true;
            this.lbl_Req4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Req4.ForeColor = System.Drawing.Color.Red;
            this.lbl_Req4.Location = new System.Drawing.Point(429, 204);
            this.lbl_Req4.Name = "lbl_Req4";
            this.lbl_Req4.Size = new System.Drawing.Size(17, 22);
            this.lbl_Req4.TabIndex = 30;
            this.lbl_Req4.Text = "*";
            this.lbl_Req4.Visible = false;
            // 
            // lbl_Timemin
            // 
            this.lbl_Timemin.Location = new System.Drawing.Point(242, 262);
            this.lbl_Timemin.Name = "lbl_Timemin";
            this.lbl_Timemin.Size = new System.Drawing.Size(32, 23);
            this.lbl_Timemin.TabIndex = 31;
            this.lbl_Timemin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbl_Timemin_KeyPress);
            // 
            // lbl_Colon
            // 
            this.lbl_Colon.AutoSize = true;
            this.lbl_Colon.Location = new System.Drawing.Point(227, 265);
            this.lbl_Colon.Name = "lbl_Colon";
            this.lbl_Colon.Size = new System.Drawing.Size(10, 15);
            this.lbl_Colon.TabIndex = 32;
            this.lbl_Colon.Text = ":";
            // 
            // form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 347);
            this.Controls.Add(this.lbl_Colon);
            this.Controls.Add(this.lbl_Timemin);
            this.Controls.Add(this.lbl_Req4);
            this.Controls.Add(this.txtbx_Age);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Req6);
            this.Controls.Add(this.lbl_Req5);
            this.Controls.Add(this.lbl_Req3);
            this.Controls.Add(this.lbl_Req2);
            this.Controls.Add(this.lbl_Req1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtbx_FName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.cmb_AMPM);
            this.Controls.Add(this.txtbx_Time);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.txtbx_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.txtbx_Contact2);
            this.Controls.Add(this.txtbx_Contact1);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.txtbx_Address);
            this.Controls.Add(this.txtbx_LName);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.cmb_Day);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_Registration";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.ComboBox cmb_Day;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.TextBox txtbx_LName;
        private System.Windows.Forms.TextBox txtbx_Address;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txtbx_Contact1;
        private System.Windows.Forms.TextBox txtbx_Contact2;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox txtbx_Gender;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TextBox txtbx_Time;
        private System.Windows.Forms.ComboBox cmb_AMPM;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox txtbx_FName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Req1;
        private System.Windows.Forms.Label lbl_Req2;
        private System.Windows.Forms.Label lbl_Req3;
        private System.Windows.Forms.Label lbl_Req5;
        private System.Windows.Forms.Label lbl_Req6;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txtbx_Age;
        private System.Windows.Forms.Label lbl_Req4;
        private System.Windows.Forms.TextBox lbl_Timemin;
        private System.Windows.Forms.Label lbl_Colon;
    }
}

