
namespace Contact_Tracing_Form
{
    partial class Form1
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
            this.lbl_Name = new System.Windows.Forms.Label();
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
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(66, 111);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(114, 22);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Last Name:";
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
            this.lbl_Address.Click += new System.EventHandler(this.label1_Click);
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
            this.cmb_Day.FormattingEnabled = true;
            this.cmb_Day.Location = new System.Drawing.Point(191, 175);
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(46, 23);
            this.cmb_Day.TabIndex = 4;
            // 
            // cmb_Month
            // 
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Location = new System.Drawing.Point(242, 175);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(77, 23);
            this.cmb_Month.TabIndex = 5;
            // 
            // cmb_Year
            // 
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(324, 175);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(56, 23);
            this.cmb_Year.TabIndex = 6;
            // 
            // txtbx_LName
            // 
            this.txtbx_LName.Location = new System.Drawing.Point(191, 111);
            this.txtbx_LName.Name = "txtbx_LName";
            this.txtbx_LName.Size = new System.Drawing.Size(232, 23);
            this.txtbx_LName.TabIndex = 7;
            // 
            // txtbx_Address
            // 
            this.txtbx_Address.Location = new System.Drawing.Point(191, 143);
            this.txtbx_Address.Name = "txtbx_Address";
            this.txtbx_Address.Size = new System.Drawing.Size(232, 23);
            this.txtbx_Address.TabIndex = 8;
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
            // 
            // txtbx_Contact2
            // 
            this.txtbx_Contact2.Location = new System.Drawing.Point(312, 233);
            this.txtbx_Contact2.Name = "txtbx_Contact2";
            this.txtbx_Contact2.Size = new System.Drawing.Size(111, 23);
            this.txtbx_Contact2.TabIndex = 11;
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
            this.txtbx_Time.Size = new System.Drawing.Size(111, 23);
            this.txtbx_Time.TabIndex = 15;
            // 
            // cmb_AMPM
            // 
            this.cmb_AMPM.FormattingEnabled = true;
            this.cmb_AMPM.Location = new System.Drawing.Point(308, 261);
            this.cmb_AMPM.Name = "cmb_AMPM";
            this.cmb_AMPM.Size = new System.Drawing.Size(46, 23);
            this.cmb_AMPM.TabIndex = 16;
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
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(348, 308);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 347);
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
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Name;
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
    }
}

