namespace Ishod1.Forms
{
    partial class MainForm
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
            this.TbControl = new System.Windows.Forms.TabControl();
            this.TbPageDrivers = new System.Windows.Forms.TabPage();
            this.BtnClearDriversForm = new System.Windows.Forms.Button();
            this.TbDrivingLicenceNumber = new System.Windows.Forms.TextBox();
            this.TbTelephone = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.TbIdDriver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteDriver = new System.Windows.Forms.Button();
            this.BtnUpdateDriver = new System.Windows.Forms.Button();
            this.BtnAddNewDriver = new System.Windows.Forms.Button();
            this.LbDrivers = new System.Windows.Forms.ListBox();
            this.TbPageTravelWarrants = new System.Windows.Forms.TabPage();
            this.BtnCreateTW = new System.Windows.Forms.Button();
            this.BtnUpdateTW = new System.Windows.Forms.Button();
            this.BtnDeleteTW = new System.Windows.Forms.Button();
            this.CbTravelWarrantType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnFuture = new System.Windows.Forms.Button();
            this.BtnActive = new System.Windows.Forms.Button();
            this.BtnClosed = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.TbTravelWarrantID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbStopCities = new System.Windows.Forms.ComboBox();
            this.CbStartCities = new System.Windows.Forms.ComboBox();
            this.CbCars = new System.Windows.Forms.ComboBox();
            this.CbDrivers = new System.Windows.Forms.ComboBox();
            this.TbTravelTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbTravelWarrants = new System.Windows.Forms.ListBox();
            this.TbPageSetup = new System.Windows.Forms.TabPage();
            this.BtnCleanDatabaseRecords = new System.Windows.Forms.Button();
            this.BtnInsertExampleRecords = new System.Windows.Forms.Button();
            this.LbInfo = new System.Windows.Forms.Label();
            this.TbControl.SuspendLayout();
            this.TbPageDrivers.SuspendLayout();
            this.TbPageTravelWarrants.SuspendLayout();
            this.TbPageSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbControl
            // 
            this.TbControl.Controls.Add(this.TbPageDrivers);
            this.TbControl.Controls.Add(this.TbPageTravelWarrants);
            this.TbControl.Controls.Add(this.TbPageSetup);
            this.TbControl.Location = new System.Drawing.Point(13, 4);
            this.TbControl.Name = "TbControl";
            this.TbControl.SelectedIndex = 0;
            this.TbControl.Size = new System.Drawing.Size(757, 537);
            this.TbControl.TabIndex = 0;
            this.TbControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TbControl_Selecting);
            // 
            // TbPageDrivers
            // 
            this.TbPageDrivers.Controls.Add(this.LbInfo);
            this.TbPageDrivers.Controls.Add(this.BtnClearDriversForm);
            this.TbPageDrivers.Controls.Add(this.TbDrivingLicenceNumber);
            this.TbPageDrivers.Controls.Add(this.TbTelephone);
            this.TbPageDrivers.Controls.Add(this.TbLastName);
            this.TbPageDrivers.Controls.Add(this.TbFirstName);
            this.TbPageDrivers.Controls.Add(this.TbIdDriver);
            this.TbPageDrivers.Controls.Add(this.label5);
            this.TbPageDrivers.Controls.Add(this.label4);
            this.TbPageDrivers.Controls.Add(this.label3);
            this.TbPageDrivers.Controls.Add(this.label2);
            this.TbPageDrivers.Controls.Add(this.label1);
            this.TbPageDrivers.Controls.Add(this.BtnDeleteDriver);
            this.TbPageDrivers.Controls.Add(this.BtnUpdateDriver);
            this.TbPageDrivers.Controls.Add(this.BtnAddNewDriver);
            this.TbPageDrivers.Controls.Add(this.LbDrivers);
            this.TbPageDrivers.Location = new System.Drawing.Point(4, 25);
            this.TbPageDrivers.Name = "TbPageDrivers";
            this.TbPageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageDrivers.Size = new System.Drawing.Size(749, 508);
            this.TbPageDrivers.TabIndex = 0;
            this.TbPageDrivers.Text = "Drivers";
            this.TbPageDrivers.UseVisualStyleBackColor = true;
            // 
            // BtnClearDriversForm
            // 
            this.BtnClearDriversForm.Location = new System.Drawing.Point(270, 467);
            this.BtnClearDriversForm.Name = "BtnClearDriversForm";
            this.BtnClearDriversForm.Size = new System.Drawing.Size(115, 23);
            this.BtnClearDriversForm.TabIndex = 14;
            this.BtnClearDriversForm.Text = "Clear";
            this.BtnClearDriversForm.UseVisualStyleBackColor = true;
            this.BtnClearDriversForm.Click += new System.EventHandler(this.BtnClearDriversForm_Click);
            // 
            // TbDrivingLicenceNumber
            // 
            this.TbDrivingLicenceNumber.Location = new System.Drawing.Point(429, 248);
            this.TbDrivingLicenceNumber.Name = "TbDrivingLicenceNumber";
            this.TbDrivingLicenceNumber.Size = new System.Drawing.Size(126, 22);
            this.TbDrivingLicenceNumber.TabIndex = 13;
            // 
            // TbTelephone
            // 
            this.TbTelephone.Location = new System.Drawing.Point(351, 158);
            this.TbTelephone.Name = "TbTelephone";
            this.TbTelephone.Size = new System.Drawing.Size(126, 22);
            this.TbTelephone.TabIndex = 12;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(590, 81);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(126, 22);
            this.TbLastName.TabIndex = 11;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Location = new System.Drawing.Point(351, 81);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(126, 22);
            this.TbFirstName.TabIndex = 10;
            // 
            // TbIdDriver
            // 
            this.TbIdDriver.Enabled = false;
            this.TbIdDriver.Location = new System.Drawing.Point(351, 7);
            this.TbIdDriver.Name = "TbIdDriver";
            this.TbIdDriver.Size = new System.Drawing.Size(126, 22);
            this.TbIdDriver.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Driving licence number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // BtnDeleteDriver
            // 
            this.BtnDeleteDriver.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteDriver.Location = new System.Drawing.Point(612, 467);
            this.BtnDeleteDriver.Name = "BtnDeleteDriver";
            this.BtnDeleteDriver.Size = new System.Drawing.Size(115, 23);
            this.BtnDeleteDriver.TabIndex = 3;
            this.BtnDeleteDriver.Text = "Delete";
            this.BtnDeleteDriver.UseVisualStyleBackColor = false;
            this.BtnDeleteDriver.Click += new System.EventHandler(this.BtnDeleteDriver_Click);
            // 
            // BtnUpdateDriver
            // 
            this.BtnUpdateDriver.Location = new System.Drawing.Point(439, 467);
            this.BtnUpdateDriver.Name = "BtnUpdateDriver";
            this.BtnUpdateDriver.Size = new System.Drawing.Size(115, 23);
            this.BtnUpdateDriver.TabIndex = 2;
            this.BtnUpdateDriver.Text = "Update";
            this.BtnUpdateDriver.UseVisualStyleBackColor = true;
            this.BtnUpdateDriver.Click += new System.EventHandler(this.BtnUpdateDriver_Click);
            // 
            // BtnAddNewDriver
            // 
            this.BtnAddNewDriver.Location = new System.Drawing.Point(439, 308);
            this.BtnAddNewDriver.Name = "BtnAddNewDriver";
            this.BtnAddNewDriver.Size = new System.Drawing.Size(115, 23);
            this.BtnAddNewDriver.TabIndex = 1;
            this.BtnAddNewDriver.Text = "Add new";
            this.BtnAddNewDriver.UseVisualStyleBackColor = true;
            this.BtnAddNewDriver.Click += new System.EventHandler(this.BtnAddNewDriver_Click);
            // 
            // LbDrivers
            // 
            this.LbDrivers.FormattingEnabled = true;
            this.LbDrivers.ItemHeight = 16;
            this.LbDrivers.Location = new System.Drawing.Point(7, 7);
            this.LbDrivers.Name = "LbDrivers";
            this.LbDrivers.Size = new System.Drawing.Size(235, 452);
            this.LbDrivers.TabIndex = 0;
            this.LbDrivers.SelectedIndexChanged += new System.EventHandler(this.LbDrivers_SelectedIndexChanged);
            // 
            // TbPageTravelWarrants
            // 
            this.TbPageTravelWarrants.Controls.Add(this.BtnCreateTW);
            this.TbPageTravelWarrants.Controls.Add(this.BtnUpdateTW);
            this.TbPageTravelWarrants.Controls.Add(this.BtnDeleteTW);
            this.TbPageTravelWarrants.Controls.Add(this.CbTravelWarrantType);
            this.TbPageTravelWarrants.Controls.Add(this.label12);
            this.TbPageTravelWarrants.Controls.Add(this.BtnFuture);
            this.TbPageTravelWarrants.Controls.Add(this.BtnActive);
            this.TbPageTravelWarrants.Controls.Add(this.BtnClosed);
            this.TbPageTravelWarrants.Controls.Add(this.BtnAll);
            this.TbPageTravelWarrants.Controls.Add(this.TbTravelWarrantID);
            this.TbPageTravelWarrants.Controls.Add(this.label11);
            this.TbPageTravelWarrants.Controls.Add(this.CbStopCities);
            this.TbPageTravelWarrants.Controls.Add(this.CbStartCities);
            this.TbPageTravelWarrants.Controls.Add(this.CbCars);
            this.TbPageTravelWarrants.Controls.Add(this.CbDrivers);
            this.TbPageTravelWarrants.Controls.Add(this.TbTravelTime);
            this.TbPageTravelWarrants.Controls.Add(this.label10);
            this.TbPageTravelWarrants.Controls.Add(this.label9);
            this.TbPageTravelWarrants.Controls.Add(this.label8);
            this.TbPageTravelWarrants.Controls.Add(this.label7);
            this.TbPageTravelWarrants.Controls.Add(this.label6);
            this.TbPageTravelWarrants.Controls.Add(this.LbTravelWarrants);
            this.TbPageTravelWarrants.Location = new System.Drawing.Point(4, 25);
            this.TbPageTravelWarrants.Name = "TbPageTravelWarrants";
            this.TbPageTravelWarrants.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageTravelWarrants.Size = new System.Drawing.Size(749, 508);
            this.TbPageTravelWarrants.TabIndex = 1;
            this.TbPageTravelWarrants.Text = "Travel warrants";
            this.TbPageTravelWarrants.UseVisualStyleBackColor = true;
            // 
            // BtnCreateTW
            // 
            this.BtnCreateTW.Location = new System.Drawing.Point(461, 466);
            this.BtnCreateTW.Name = "BtnCreateTW";
            this.BtnCreateTW.Size = new System.Drawing.Size(74, 36);
            this.BtnCreateTW.TabIndex = 22;
            this.BtnCreateTW.Text = "Create";
            this.BtnCreateTW.UseVisualStyleBackColor = true;
            this.BtnCreateTW.Click += new System.EventHandler(this.BtnCreateTW_Click);
            // 
            // BtnUpdateTW
            // 
            this.BtnUpdateTW.Location = new System.Drawing.Point(569, 466);
            this.BtnUpdateTW.Name = "BtnUpdateTW";
            this.BtnUpdateTW.Size = new System.Drawing.Size(74, 36);
            this.BtnUpdateTW.TabIndex = 21;
            this.BtnUpdateTW.Text = "Update";
            this.BtnUpdateTW.UseVisualStyleBackColor = true;
            this.BtnUpdateTW.Click += new System.EventHandler(this.BtnUpdateTW_Click);
            // 
            // BtnDeleteTW
            // 
            this.BtnDeleteTW.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteTW.Location = new System.Drawing.Point(669, 466);
            this.BtnDeleteTW.Name = "BtnDeleteTW";
            this.BtnDeleteTW.Size = new System.Drawing.Size(74, 36);
            this.BtnDeleteTW.TabIndex = 20;
            this.BtnDeleteTW.Text = "Delete";
            this.BtnDeleteTW.UseVisualStyleBackColor = false;
            this.BtnDeleteTW.Click += new System.EventHandler(this.BtnDeleteTW_Click);
            // 
            // CbTravelWarrantType
            // 
            this.CbTravelWarrantType.FormattingEnabled = true;
            this.CbTravelWarrantType.Location = new System.Drawing.Point(397, 364);
            this.CbTravelWarrantType.Name = "CbTravelWarrantType";
            this.CbTravelWarrantType.Size = new System.Drawing.Size(138, 24);
            this.CbTravelWarrantType.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Status:";
            // 
            // BtnFuture
            // 
            this.BtnFuture.Location = new System.Drawing.Point(213, 479);
            this.BtnFuture.Name = "BtnFuture";
            this.BtnFuture.Size = new System.Drawing.Size(63, 23);
            this.BtnFuture.TabIndex = 17;
            this.BtnFuture.Text = "Future";
            this.BtnFuture.UseVisualStyleBackColor = true;
            this.BtnFuture.Click += new System.EventHandler(this.BtnFuture_Click);
            // 
            // BtnActive
            // 
            this.BtnActive.Location = new System.Drawing.Point(144, 479);
            this.BtnActive.Name = "BtnActive";
            this.BtnActive.Size = new System.Drawing.Size(63, 23);
            this.BtnActive.TabIndex = 16;
            this.BtnActive.Text = "Active";
            this.BtnActive.UseVisualStyleBackColor = true;
            this.BtnActive.Click += new System.EventHandler(this.BtnActive_Click);
            // 
            // BtnClosed
            // 
            this.BtnClosed.Location = new System.Drawing.Point(75, 479);
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Size = new System.Drawing.Size(63, 23);
            this.BtnClosed.TabIndex = 15;
            this.BtnClosed.Text = "Closed";
            this.BtnClosed.UseVisualStyleBackColor = true;
            this.BtnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(6, 479);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(63, 23);
            this.BtnAll.TabIndex = 14;
            this.BtnAll.Text = "All";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // TbTravelWarrantID
            // 
            this.TbTravelWarrantID.Enabled = false;
            this.TbTravelWarrantID.Location = new System.Drawing.Point(357, 6);
            this.TbTravelWarrantID.Name = "TbTravelWarrantID";
            this.TbTravelWarrantID.Size = new System.Drawing.Size(126, 22);
            this.TbTravelWarrantID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "ID:";
            // 
            // CbStopCities
            // 
            this.CbStopCities.FormattingEnabled = true;
            this.CbStopCities.Location = new System.Drawing.Point(599, 222);
            this.CbStopCities.Name = "CbStopCities";
            this.CbStopCities.Size = new System.Drawing.Size(144, 24);
            this.CbStopCities.TabIndex = 11;
            // 
            // CbStartCities
            // 
            this.CbStartCities.FormattingEnabled = true;
            this.CbStartCities.Location = new System.Drawing.Point(357, 222);
            this.CbStartCities.Name = "CbStartCities";
            this.CbStartCities.Size = new System.Drawing.Size(147, 24);
            this.CbStartCities.TabIndex = 10;
            // 
            // CbCars
            // 
            this.CbCars.FormattingEnabled = true;
            this.CbCars.Location = new System.Drawing.Point(357, 134);
            this.CbCars.Name = "CbCars";
            this.CbCars.Size = new System.Drawing.Size(178, 24);
            this.CbCars.TabIndex = 9;
            // 
            // CbDrivers
            // 
            this.CbDrivers.FormattingEnabled = true;
            this.CbDrivers.Location = new System.Drawing.Point(357, 56);
            this.CbDrivers.Name = "CbDrivers";
            this.CbDrivers.Size = new System.Drawing.Size(178, 24);
            this.CbDrivers.TabIndex = 8;
            // 
            // TbTravelTime
            // 
            this.TbTravelTime.Location = new System.Drawing.Point(397, 308);
            this.TbTravelTime.Name = "TbTravelTime";
            this.TbTravelTime.Size = new System.Drawing.Size(138, 22);
            this.TbTravelTime.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Travel time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Destination:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Start:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Car:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Driver:";
            // 
            // LbTravelWarrants
            // 
            this.LbTravelWarrants.FormattingEnabled = true;
            this.LbTravelWarrants.ItemHeight = 16;
            this.LbTravelWarrants.Location = new System.Drawing.Point(6, 6);
            this.LbTravelWarrants.Name = "LbTravelWarrants";
            this.LbTravelWarrants.Size = new System.Drawing.Size(270, 468);
            this.LbTravelWarrants.TabIndex = 1;
            this.LbTravelWarrants.SelectedIndexChanged += new System.EventHandler(this.LbTravelWarrants_SelectedIndexChanged);
            // 
            // TbPageSetup
            // 
            this.TbPageSetup.Controls.Add(this.BtnCleanDatabaseRecords);
            this.TbPageSetup.Controls.Add(this.BtnInsertExampleRecords);
            this.TbPageSetup.Location = new System.Drawing.Point(4, 25);
            this.TbPageSetup.Name = "TbPageSetup";
            this.TbPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageSetup.Size = new System.Drawing.Size(749, 508);
            this.TbPageSetup.TabIndex = 2;
            this.TbPageSetup.Text = "Setup";
            this.TbPageSetup.UseVisualStyleBackColor = true;
            // 
            // BtnCleanDatabaseRecords
            // 
            this.BtnCleanDatabaseRecords.BackColor = System.Drawing.Color.Red;
            this.BtnCleanDatabaseRecords.Location = new System.Drawing.Point(431, 167);
            this.BtnCleanDatabaseRecords.Name = "BtnCleanDatabaseRecords";
            this.BtnCleanDatabaseRecords.Size = new System.Drawing.Size(220, 138);
            this.BtnCleanDatabaseRecords.TabIndex = 1;
            this.BtnCleanDatabaseRecords.Text = "Clean database records";
            this.BtnCleanDatabaseRecords.UseVisualStyleBackColor = false;
            this.BtnCleanDatabaseRecords.Click += new System.EventHandler(this.BtnCleanDatabaseRecords_Click);
            // 
            // BtnInsertExampleRecords
            // 
            this.BtnInsertExampleRecords.Location = new System.Drawing.Point(86, 167);
            this.BtnInsertExampleRecords.Name = "BtnInsertExampleRecords";
            this.BtnInsertExampleRecords.Size = new System.Drawing.Size(220, 138);
            this.BtnInsertExampleRecords.TabIndex = 0;
            this.BtnInsertExampleRecords.Text = "Insert example records";
            this.BtnInsertExampleRecords.UseVisualStyleBackColor = true;
            this.BtnInsertExampleRecords.Click += new System.EventHandler(this.BtnInsertExampleRecords_Click);
            // 
            // LbInfo
            // 
            this.LbInfo.AutoSize = true;
            this.LbInfo.Location = new System.Drawing.Point(7, 472);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(0, 17);
            this.LbInfo.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.TbControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TbControl.ResumeLayout(false);
            this.TbPageDrivers.ResumeLayout(false);
            this.TbPageDrivers.PerformLayout();
            this.TbPageTravelWarrants.ResumeLayout(false);
            this.TbPageTravelWarrants.PerformLayout();
            this.TbPageSetup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbControl;
        private System.Windows.Forms.TabPage TbPageDrivers;
        private System.Windows.Forms.TabPage TbPageTravelWarrants;
        private System.Windows.Forms.TabPage TbPageSetup;
        private System.Windows.Forms.Button BtnCleanDatabaseRecords;
        private System.Windows.Forms.Button BtnInsertExampleRecords;
        private System.Windows.Forms.Button BtnDeleteDriver;
        private System.Windows.Forms.Button BtnUpdateDriver;
        private System.Windows.Forms.Button BtnAddNewDriver;
        private System.Windows.Forms.ListBox LbDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDrivingLicenceNumber;
        private System.Windows.Forms.TextBox TbTelephone;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.TextBox TbIdDriver;
        private System.Windows.Forms.Button BtnClearDriversForm;
        private System.Windows.Forms.ListBox LbTravelWarrants;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbTravelTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbStopCities;
        private System.Windows.Forms.ComboBox CbStartCities;
        private System.Windows.Forms.ComboBox CbCars;
        private System.Windows.Forms.ComboBox CbDrivers;
        private System.Windows.Forms.TextBox TbTravelWarrantID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnFuture;
        private System.Windows.Forms.Button BtnActive;
        private System.Windows.Forms.Button BtnClosed;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.ComboBox CbTravelWarrantType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCreateTW;
        private System.Windows.Forms.Button BtnUpdateTW;
        private System.Windows.Forms.Button BtnDeleteTW;
        private System.Windows.Forms.Label LbInfo;
    }
}