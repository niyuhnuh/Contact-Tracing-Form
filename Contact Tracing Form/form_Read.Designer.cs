
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_SavedInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_SavedInfo
            // 
            this.dg_SavedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SavedInfo.Location = new System.Drawing.Point(12, 12);
            this.dg_SavedInfo.Name = "dg_SavedInfo";
            this.dg_SavedInfo.RowTemplate.Height = 25;
            this.dg_SavedInfo.Size = new System.Drawing.Size(440, 324);
            this.dg_SavedInfo.TabIndex = 0;
            // 
            // form_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 348);
            this.Controls.Add(this.dg_SavedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_Read";
            this.Text = "form_Read";
            this.Load += new System.EventHandler(this.form_Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SavedInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_SavedInfo;
    }
}