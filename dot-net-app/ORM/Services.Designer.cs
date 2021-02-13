
namespace ORM
{
    partial class Services
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
            this.LbCars = new System.Windows.Forms.ListBox();
            this.CbServices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbServiceDesc = new System.Windows.Forms.TextBox();
            this.DtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnHtmlReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbCars
            // 
            this.LbCars.FormattingEnabled = true;
            this.LbCars.ItemHeight = 16;
            this.LbCars.Location = new System.Drawing.Point(15, 14);
            this.LbCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbCars.Name = "LbCars";
            this.LbCars.Size = new System.Drawing.Size(256, 484);
            this.LbCars.TabIndex = 1;
            this.LbCars.SelectedIndexChanged += new System.EventHandler(this.LbCars_SelectedIndexChanged);
            // 
            // CbServices
            // 
            this.CbServices.FormattingEnabled = true;
            this.CbServices.Location = new System.Drawing.Point(296, 15);
            this.CbServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbServices.Name = "CbServices";
            this.CbServices.Size = new System.Drawing.Size(468, 24);
            this.CbServices.TabIndex = 2;
            this.CbServices.SelectedIndexChanged += new System.EventHandler(this.CbServices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description:";
            // 
            // TbServiceDesc
            // 
            this.TbServiceDesc.Location = new System.Drawing.Point(384, 69);
            this.TbServiceDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbServiceDesc.Multiline = true;
            this.TbServiceDesc.Name = "TbServiceDesc";
            this.TbServiceDesc.Size = new System.Drawing.Size(380, 94);
            this.TbServiceDesc.TabIndex = 4;
            // 
            // DtpServiceDate
            // 
            this.DtpServiceDate.Location = new System.Drawing.Point(384, 197);
            this.DtpServiceDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpServiceDate.Name = "DtpServiceDate";
            this.DtpServiceDate.Size = new System.Drawing.Size(380, 22);
            this.DtpServiceDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(296, 510);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 28);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(487, 510);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 28);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(665, 510);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 28);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnHtmlReport
            // 
            this.BtnHtmlReport.Location = new System.Drawing.Point(56, 510);
            this.BtnHtmlReport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHtmlReport.Name = "BtnHtmlReport";
            this.BtnHtmlReport.Size = new System.Drawing.Size(160, 28);
            this.BtnHtmlReport.TabIndex = 10;
            this.BtnHtmlReport.Text = "HTML report";
            this.BtnHtmlReport.UseVisualStyleBackColor = true;
            this.BtnHtmlReport.Click += new System.EventHandler(this.BtnHtmlReport_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.BtnHtmlReport);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpServiceDate);
            this.Controls.Add(this.TbServiceDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbServices);
            this.Controls.Add(this.LbCars);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Services";
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbCars;
        private System.Windows.Forms.ComboBox CbServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbServiceDesc;
        private System.Windows.Forms.DateTimePicker DtpServiceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnHtmlReport;
    }
}

