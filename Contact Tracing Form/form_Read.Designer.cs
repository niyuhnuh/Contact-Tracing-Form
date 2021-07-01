
namespace Contact_Tracing_Form
{
    partial class form_Read
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_SavedInfo = new System.Windows.Forms.DataGridView();
            this.col_FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ContactInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SavedInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_SavedInfo
            // 
            this.dg_SavedInfo.AllowUserToAddRows = false;
            this.dg_SavedInfo.AllowUserToDeleteRows = false;
            this.dg_SavedInfo.AllowUserToResizeColumns = false;
            this.dg_SavedInfo.AllowUserToResizeRows = false;
            this.dg_SavedInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_SavedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SavedInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_FName,
            this.col_LName,
            this.col_Address,
            this.col_Birthday,
            this.col_Gender,
            this.col_Age,
            this.col_ContactInf,
            this.col_Time});
            this.dg_SavedInfo.Location = new System.Drawing.Point(12, 22);
            this.dg_SavedInfo.Name = "dg_SavedInfo";
            this.dg_SavedInfo.ReadOnly = true;
            this.dg_SavedInfo.RowTemplate.Height = 25;
            this.dg_SavedInfo.Size = new System.Drawing.Size(694, 314);
            this.dg_SavedInfo.TabIndex = 0;
            // 
            // col_FName
            // 
            this.col_FName.HeaderText = "First Name";
            this.col_FName.Name = "col_FName";
            this.col_FName.ReadOnly = true;
            this.col_FName.Width = 89;
            // 
            // col_LName
            // 
            this.col_LName.HeaderText = "Last Name";
            this.col_LName.Name = "col_LName";
            this.col_LName.ReadOnly = true;
            this.col_LName.Width = 88;
            // 
            // col_Address
            // 
            this.col_Address.HeaderText = "Address";
            this.col_Address.Name = "col_Address";
            this.col_Address.ReadOnly = true;
            this.col_Address.Width = 74;
            // 
            // col_Birthday
            // 
            this.col_Birthday.HeaderText = "Birthday";
            this.col_Birthday.Name = "col_Birthday";
            this.col_Birthday.ReadOnly = true;
            this.col_Birthday.Width = 76;
            // 
            // col_Gender
            // 
            this.col_Gender.HeaderText = "Gender";
            this.col_Gender.Name = "col_Gender";
            this.col_Gender.ReadOnly = true;
            this.col_Gender.Width = 70;
            // 
            // col_Age
            // 
            this.col_Age.HeaderText = "Age";
            this.col_Age.Name = "col_Age";
            this.col_Age.ReadOnly = true;
            this.col_Age.Width = 53;
            // 
            // col_ContactInf
            // 
            this.col_ContactInf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_ContactInf.HeaderText = "Contact Information";
            this.col_ContactInf.Name = "col_ContactInf";
            this.col_ContactInf.ReadOnly = true;
            this.col_ContactInf.Width = 128;
            // 
            // col_Time
            // 
            this.col_Time.HeaderText = "Time Logged";
            this.col_Time.Name = "col_Time";
            this.col_Time.ReadOnly = true;
            this.col_Time.Width = 93;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(12, 341);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 23);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(93, 341);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // form_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 376);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.dg_SavedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Read";
            this.Text = "form_Read";
            this.Load += new System.EventHandler(this.form_Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SavedInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_SavedInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ContactInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Exit;
    }
}