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
            this.LbInfo = new System.Windows.Forms.Label();
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
            this.TbPageRoutes = new System.Windows.Forms.TabPage();
            this.BtnImportXml = new System.Windows.Forms.Button();
            this.BtnExportXml = new System.Windows.Forms.Button();
            this.TbFuelUsed = new System.Windows.Forms.TextBox();
            this.TbKilometers = new System.Windows.Forms.TextBox();
            this.TbTimeHours = new System.Windows.Forms.TextBox();
            this.BtnCreateRoute = new System.Windows.Forms.Button();
            this.BtnUpdateRoute = new System.Windows.Forms.Button();
            this.BtnDeleteRoute = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TbIdRoute = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbCitiesB = new System.Windows.Forms.ComboBox();
            this.CbCitiesA = new System.Windows.Forms.ComboBox();
            this.TbAvgSpeed = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LbRoutes = new System.Windows.Forms.ListBox();
            this.TbPageSetup = new System.Windows.Forms.TabPage();
            this.BtnCleanDatabaseRecords = new System.Windows.Forms.Button();
            this.BtnInsertExampleRecords = new System.Windows.Forms.Button();
            this.BtnDbToXml = new System.Windows.Forms.Button();
            this.BtnXmlToDb = new System.Windows.Forms.Button();
            this.TbControl.SuspendLayout();
            this.TbPageDrivers.SuspendLayout();
            this.TbPageTravelWarrants.SuspendLayout();
            this.TbPageRoutes.SuspendLayout();
            this.TbPageSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbControl
            // 
            this.TbControl.Controls.Add(this.TbPageDrivers);
            this.TbControl.Controls.Add(this.TbPageTravelWarrants);
            this.TbControl.Controls.Add(this.TbPageRoutes);
            this.TbControl.Controls.Add(this.TbPageSetup);
            this.TbControl.Location = new System.Drawing.Point(11, 2);
            this.TbControl.Margin = new System.Windows.Forms.Padding(2);
            this.TbControl.Name = "TbControl";
            this.TbControl.SelectedIndex = 0;
            this.TbControl.Size = new System.Drawing.Size(568, 446);
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
            this.TbPageDrivers.Location = new System.Drawing.Point(4, 22);
            this.TbPageDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.TbPageDrivers.Name = "TbPageDrivers";
            this.TbPageDrivers.Padding = new System.Windows.Forms.Padding(2);
            this.TbPageDrivers.Size = new System.Drawing.Size(560, 420);
            this.TbPageDrivers.TabIndex = 0;
            this.TbPageDrivers.Text = "Drivers";
            this.TbPageDrivers.UseVisualStyleBackColor = true;
            // 
            // LbInfo
            // 
            this.LbInfo.AutoSize = true;
            this.LbInfo.Location = new System.Drawing.Point(5, 384);
            this.LbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(0, 15);
            this.LbInfo.TabIndex = 15;
            // 
            // BtnClearDriversForm
            // 
            this.BtnClearDriversForm.Location = new System.Drawing.Point(202, 379);
            this.BtnClearDriversForm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClearDriversForm.Name = "BtnClearDriversForm";
            this.BtnClearDriversForm.Size = new System.Drawing.Size(86, 19);
            this.BtnClearDriversForm.TabIndex = 14;
            this.BtnClearDriversForm.Text = "Clear";
            this.BtnClearDriversForm.UseVisualStyleBackColor = true;
            this.BtnClearDriversForm.Click += new System.EventHandler(this.BtnClearDriversForm_Click);
            // 
            // TbDrivingLicenceNumber
            // 
            this.TbDrivingLicenceNumber.Location = new System.Drawing.Point(322, 202);
            this.TbDrivingLicenceNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TbDrivingLicenceNumber.Name = "TbDrivingLicenceNumber";
            this.TbDrivingLicenceNumber.Size = new System.Drawing.Size(96, 20);
            this.TbDrivingLicenceNumber.TabIndex = 13;
            // 
            // TbTelephone
            // 
            this.TbTelephone.Location = new System.Drawing.Point(263, 128);
            this.TbTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.TbTelephone.Name = "TbTelephone";
            this.TbTelephone.Size = new System.Drawing.Size(96, 20);
            this.TbTelephone.TabIndex = 12;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(442, 66);
            this.TbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(96, 20);
            this.TbLastName.TabIndex = 11;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Location = new System.Drawing.Point(263, 66);
            this.TbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(96, 20);
            this.TbFirstName.TabIndex = 10;
            // 
            // TbIdDriver
            // 
            this.TbIdDriver.Enabled = false;
            this.TbIdDriver.Location = new System.Drawing.Point(263, 6);
            this.TbIdDriver.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdDriver.Name = "TbIdDriver";
            this.TbIdDriver.Size = new System.Drawing.Size(96, 20);
            this.TbIdDriver.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Driving licence number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // BtnDeleteDriver
            // 
            this.BtnDeleteDriver.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteDriver.Location = new System.Drawing.Point(459, 379);
            this.BtnDeleteDriver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteDriver.Name = "BtnDeleteDriver";
            this.BtnDeleteDriver.Size = new System.Drawing.Size(86, 19);
            this.BtnDeleteDriver.TabIndex = 3;
            this.BtnDeleteDriver.Text = "Delete";
            this.BtnDeleteDriver.UseVisualStyleBackColor = false;
            this.BtnDeleteDriver.Click += new System.EventHandler(this.BtnDeleteDriver_Click);
            // 
            // BtnUpdateDriver
            // 
            this.BtnUpdateDriver.Location = new System.Drawing.Point(329, 379);
            this.BtnUpdateDriver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateDriver.Name = "BtnUpdateDriver";
            this.BtnUpdateDriver.Size = new System.Drawing.Size(86, 19);
            this.BtnUpdateDriver.TabIndex = 2;
            this.BtnUpdateDriver.Text = "Update";
            this.BtnUpdateDriver.UseVisualStyleBackColor = true;
            this.BtnUpdateDriver.Click += new System.EventHandler(this.BtnUpdateDriver_Click);
            // 
            // BtnAddNewDriver
            // 
            this.BtnAddNewDriver.Location = new System.Drawing.Point(329, 250);
            this.BtnAddNewDriver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddNewDriver.Name = "BtnAddNewDriver";
            this.BtnAddNewDriver.Size = new System.Drawing.Size(86, 19);
            this.BtnAddNewDriver.TabIndex = 1;
            this.BtnAddNewDriver.Text = "Add new";
            this.BtnAddNewDriver.UseVisualStyleBackColor = true;
            this.BtnAddNewDriver.Click += new System.EventHandler(this.BtnAddNewDriver_Click);
            // 
            // LbDrivers
            // 
            this.LbDrivers.FormattingEnabled = true;
            this.LbDrivers.Location = new System.Drawing.Point(5, 6);
            this.LbDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.LbDrivers.Name = "LbDrivers";
            this.LbDrivers.Size = new System.Drawing.Size(177, 368);
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
            this.TbPageTravelWarrants.Location = new System.Drawing.Point(4, 22);
            this.TbPageTravelWarrants.Margin = new System.Windows.Forms.Padding(2);
            this.TbPageTravelWarrants.Name = "TbPageTravelWarrants";
            this.TbPageTravelWarrants.Padding = new System.Windows.Forms.Padding(2);
            this.TbPageTravelWarrants.Size = new System.Drawing.Size(560, 420);
            this.TbPageTravelWarrants.TabIndex = 1;
            this.TbPageTravelWarrants.Text = "Travel warrants";
            this.TbPageTravelWarrants.UseVisualStyleBackColor = true;
            // 
            // BtnCreateTW
            // 
            this.BtnCreateTW.Location = new System.Drawing.Point(346, 379);
            this.BtnCreateTW.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateTW.Name = "BtnCreateTW";
            this.BtnCreateTW.Size = new System.Drawing.Size(56, 29);
            this.BtnCreateTW.TabIndex = 22;
            this.BtnCreateTW.Text = "Create";
            this.BtnCreateTW.UseVisualStyleBackColor = true;
            this.BtnCreateTW.Click += new System.EventHandler(this.BtnCreateTW_Click);
            // 
            // BtnUpdateTW
            // 
            this.BtnUpdateTW.Location = new System.Drawing.Point(427, 379);
            this.BtnUpdateTW.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateTW.Name = "BtnUpdateTW";
            this.BtnUpdateTW.Size = new System.Drawing.Size(56, 29);
            this.BtnUpdateTW.TabIndex = 21;
            this.BtnUpdateTW.Text = "Update";
            this.BtnUpdateTW.UseVisualStyleBackColor = true;
            this.BtnUpdateTW.Click += new System.EventHandler(this.BtnUpdateTW_Click);
            // 
            // BtnDeleteTW
            // 
            this.BtnDeleteTW.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteTW.Location = new System.Drawing.Point(502, 379);
            this.BtnDeleteTW.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteTW.Name = "BtnDeleteTW";
            this.BtnDeleteTW.Size = new System.Drawing.Size(56, 29);
            this.BtnDeleteTW.TabIndex = 20;
            this.BtnDeleteTW.Text = "Delete";
            this.BtnDeleteTW.UseVisualStyleBackColor = false;
            this.BtnDeleteTW.Click += new System.EventHandler(this.BtnDeleteTW_Click);
            // 
            // CbTravelWarrantType
            // 
            this.CbTravelWarrantType.FormattingEnabled = true;
            this.CbTravelWarrantType.Location = new System.Drawing.Point(298, 296);
            this.CbTravelWarrantType.Margin = new System.Windows.Forms.Padding(2);
            this.CbTravelWarrantType.Name = "CbTravelWarrantType";
            this.CbTravelWarrantType.Size = new System.Drawing.Size(104, 21);
            this.CbTravelWarrantType.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 298);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Status:";
            // 
            // BtnFuture
            // 
            this.BtnFuture.Location = new System.Drawing.Point(160, 389);
            this.BtnFuture.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFuture.Name = "BtnFuture";
            this.BtnFuture.Size = new System.Drawing.Size(55, 27);
            this.BtnFuture.TabIndex = 17;
            this.BtnFuture.Text = "Future";
            this.BtnFuture.UseVisualStyleBackColor = true;
            this.BtnFuture.Click += new System.EventHandler(this.BtnFuture_Click);
            // 
            // BtnActive
            // 
            this.BtnActive.Location = new System.Drawing.Point(108, 389);
            this.BtnActive.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActive.Name = "BtnActive";
            this.BtnActive.Size = new System.Drawing.Size(47, 27);
            this.BtnActive.TabIndex = 16;
            this.BtnActive.Text = "Active";
            this.BtnActive.UseVisualStyleBackColor = true;
            this.BtnActive.Click += new System.EventHandler(this.BtnActive_Click);
            // 
            // BtnClosed
            // 
            this.BtnClosed.Location = new System.Drawing.Point(56, 389);
            this.BtnClosed.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Size = new System.Drawing.Size(47, 27);
            this.BtnClosed.TabIndex = 15;
            this.BtnClosed.Text = "Closed";
            this.BtnClosed.UseVisualStyleBackColor = true;
            this.BtnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(4, 389);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(47, 27);
            this.BtnAll.TabIndex = 14;
            this.BtnAll.Text = "All";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // TbTravelWarrantID
            // 
            this.TbTravelWarrantID.Enabled = false;
            this.TbTravelWarrantID.Location = new System.Drawing.Point(268, 5);
            this.TbTravelWarrantID.Margin = new System.Windows.Forms.Padding(2);
            this.TbTravelWarrantID.Name = "TbTravelWarrantID";
            this.TbTravelWarrantID.Size = new System.Drawing.Size(96, 20);
            this.TbTravelWarrantID.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "ID:";
            // 
            // CbStopCities
            // 
            this.CbStopCities.FormattingEnabled = true;
            this.CbStopCities.Location = new System.Drawing.Point(449, 180);
            this.CbStopCities.Margin = new System.Windows.Forms.Padding(2);
            this.CbStopCities.Name = "CbStopCities";
            this.CbStopCities.Size = new System.Drawing.Size(109, 21);
            this.CbStopCities.TabIndex = 11;
            // 
            // CbStartCities
            // 
            this.CbStartCities.FormattingEnabled = true;
            this.CbStartCities.Location = new System.Drawing.Point(268, 180);
            this.CbStartCities.Margin = new System.Windows.Forms.Padding(2);
            this.CbStartCities.Name = "CbStartCities";
            this.CbStartCities.Size = new System.Drawing.Size(111, 21);
            this.CbStartCities.TabIndex = 10;
            // 
            // CbCars
            // 
            this.CbCars.FormattingEnabled = true;
            this.CbCars.Location = new System.Drawing.Point(268, 109);
            this.CbCars.Margin = new System.Windows.Forms.Padding(2);
            this.CbCars.Name = "CbCars";
            this.CbCars.Size = new System.Drawing.Size(134, 21);
            this.CbCars.TabIndex = 9;
            // 
            // CbDrivers
            // 
            this.CbDrivers.FormattingEnabled = true;
            this.CbDrivers.Location = new System.Drawing.Point(268, 46);
            this.CbDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.CbDrivers.Name = "CbDrivers";
            this.CbDrivers.Size = new System.Drawing.Size(134, 21);
            this.CbDrivers.TabIndex = 8;
            // 
            // TbTravelTime
            // 
            this.TbTravelTime.Location = new System.Drawing.Point(298, 250);
            this.TbTravelTime.Margin = new System.Windows.Forms.Padding(2);
            this.TbTravelTime.Name = "TbTravelTime";
            this.TbTravelTime.Size = new System.Drawing.Size(104, 20);
            this.TbTravelTime.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Travel time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Destination:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Start:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Car:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Driver:";
            // 
            // LbTravelWarrants
            // 
            this.LbTravelWarrants.FormattingEnabled = true;
            this.LbTravelWarrants.Location = new System.Drawing.Point(4, 5);
            this.LbTravelWarrants.Margin = new System.Windows.Forms.Padding(2);
            this.LbTravelWarrants.Name = "LbTravelWarrants";
            this.LbTravelWarrants.Size = new System.Drawing.Size(204, 381);
            this.LbTravelWarrants.TabIndex = 1;
            this.LbTravelWarrants.SelectedIndexChanged += new System.EventHandler(this.LbTravelWarrants_SelectedIndexChanged);
            // 
            // TbPageRoutes
            // 
            this.TbPageRoutes.Controls.Add(this.BtnImportXml);
            this.TbPageRoutes.Controls.Add(this.BtnExportXml);
            this.TbPageRoutes.Controls.Add(this.TbFuelUsed);
            this.TbPageRoutes.Controls.Add(this.TbKilometers);
            this.TbPageRoutes.Controls.Add(this.TbTimeHours);
            this.TbPageRoutes.Controls.Add(this.BtnCreateRoute);
            this.TbPageRoutes.Controls.Add(this.BtnUpdateRoute);
            this.TbPageRoutes.Controls.Add(this.BtnDeleteRoute);
            this.TbPageRoutes.Controls.Add(this.label13);
            this.TbPageRoutes.Controls.Add(this.TbIdRoute);
            this.TbPageRoutes.Controls.Add(this.label14);
            this.TbPageRoutes.Controls.Add(this.CbCitiesB);
            this.TbPageRoutes.Controls.Add(this.CbCitiesA);
            this.TbPageRoutes.Controls.Add(this.TbAvgSpeed);
            this.TbPageRoutes.Controls.Add(this.label15);
            this.TbPageRoutes.Controls.Add(this.label16);
            this.TbPageRoutes.Controls.Add(this.label17);
            this.TbPageRoutes.Controls.Add(this.label18);
            this.TbPageRoutes.Controls.Add(this.label19);
            this.TbPageRoutes.Controls.Add(this.LbRoutes);
            this.TbPageRoutes.Location = new System.Drawing.Point(4, 22);
            this.TbPageRoutes.Name = "TbPageRoutes";
            this.TbPageRoutes.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageRoutes.Size = new System.Drawing.Size(560, 420);
            this.TbPageRoutes.TabIndex = 3;
            this.TbPageRoutes.Text = "Routes";
            this.TbPageRoutes.UseVisualStyleBackColor = true;
            // 
            // BtnImportXml
            // 
            this.BtnImportXml.Location = new System.Drawing.Point(466, 35);
            this.BtnImportXml.Name = "BtnImportXml";
            this.BtnImportXml.Size = new System.Drawing.Size(88, 23);
            this.BtnImportXml.TabIndex = 44;
            this.BtnImportXml.Text = "Import route";
            this.BtnImportXml.UseVisualStyleBackColor = true;
            this.BtnImportXml.Click += new System.EventHandler(this.BtnImportXml_Click);
            // 
            // BtnExportXml
            // 
            this.BtnExportXml.Location = new System.Drawing.Point(466, 6);
            this.BtnExportXml.Name = "BtnExportXml";
            this.BtnExportXml.Size = new System.Drawing.Size(88, 23);
            this.BtnExportXml.TabIndex = 43;
            this.BtnExportXml.Text = "Export route";
            this.BtnExportXml.UseVisualStyleBackColor = true;
            this.BtnExportXml.Click += new System.EventHandler(this.BtnExportXml_Click);
            // 
            // TbFuelUsed
            // 
            this.TbFuelUsed.Location = new System.Drawing.Point(295, 303);
            this.TbFuelUsed.Margin = new System.Windows.Forms.Padding(2);
            this.TbFuelUsed.Name = "TbFuelUsed";
            this.TbFuelUsed.Size = new System.Drawing.Size(104, 20);
            this.TbFuelUsed.TabIndex = 42;
            // 
            // TbKilometers
            // 
            this.TbKilometers.Location = new System.Drawing.Point(295, 113);
            this.TbKilometers.Margin = new System.Windows.Forms.Padding(2);
            this.TbKilometers.Name = "TbKilometers";
            this.TbKilometers.Size = new System.Drawing.Size(96, 20);
            this.TbKilometers.TabIndex = 41;
            // 
            // TbTimeHours
            // 
            this.TbTimeHours.Location = new System.Drawing.Point(270, 53);
            this.TbTimeHours.Margin = new System.Windows.Forms.Padding(2);
            this.TbTimeHours.Name = "TbTimeHours";
            this.TbTimeHours.Size = new System.Drawing.Size(96, 20);
            this.TbTimeHours.TabIndex = 40;
            // 
            // BtnCreateRoute
            // 
            this.BtnCreateRoute.Location = new System.Drawing.Point(343, 384);
            this.BtnCreateRoute.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateRoute.Name = "BtnCreateRoute";
            this.BtnCreateRoute.Size = new System.Drawing.Size(56, 29);
            this.BtnCreateRoute.TabIndex = 39;
            this.BtnCreateRoute.Text = "Create";
            this.BtnCreateRoute.UseVisualStyleBackColor = true;
            this.BtnCreateRoute.Click += new System.EventHandler(this.BtnCreateRoute_Click);
            // 
            // BtnUpdateRoute
            // 
            this.BtnUpdateRoute.Location = new System.Drawing.Point(424, 384);
            this.BtnUpdateRoute.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateRoute.Name = "BtnUpdateRoute";
            this.BtnUpdateRoute.Size = new System.Drawing.Size(56, 29);
            this.BtnUpdateRoute.TabIndex = 38;
            this.BtnUpdateRoute.Text = "Update";
            this.BtnUpdateRoute.UseVisualStyleBackColor = true;
            this.BtnUpdateRoute.Click += new System.EventHandler(this.BtnUpdateRoute_Click);
            // 
            // BtnDeleteRoute
            // 
            this.BtnDeleteRoute.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteRoute.Location = new System.Drawing.Point(499, 384);
            this.BtnDeleteRoute.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteRoute.Name = "BtnDeleteRoute";
            this.BtnDeleteRoute.Size = new System.Drawing.Size(56, 29);
            this.BtnDeleteRoute.TabIndex = 37;
            this.BtnDeleteRoute.Text = "Delete";
            this.BtnDeleteRoute.UseVisualStyleBackColor = false;
            this.BtnDeleteRoute.Click += new System.EventHandler(this.BtnDeleteRoute_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "Fuel used:";
            // 
            // TbIdRoute
            // 
            this.TbIdRoute.Enabled = false;
            this.TbIdRoute.Location = new System.Drawing.Point(265, 10);
            this.TbIdRoute.Margin = new System.Windows.Forms.Padding(2);
            this.TbIdRoute.Name = "TbIdRoute";
            this.TbIdRoute.Size = new System.Drawing.Size(96, 20);
            this.TbIdRoute.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "ID:";
            // 
            // CbCitiesB
            // 
            this.CbCitiesB.FormattingEnabled = true;
            this.CbCitiesB.Location = new System.Drawing.Point(446, 185);
            this.CbCitiesB.Margin = new System.Windows.Forms.Padding(2);
            this.CbCitiesB.Name = "CbCitiesB";
            this.CbCitiesB.Size = new System.Drawing.Size(109, 21);
            this.CbCitiesB.TabIndex = 32;
            // 
            // CbCitiesA
            // 
            this.CbCitiesA.FormattingEnabled = true;
            this.CbCitiesA.Location = new System.Drawing.Point(255, 185);
            this.CbCitiesA.Margin = new System.Windows.Forms.Padding(2);
            this.CbCitiesA.Name = "CbCitiesA";
            this.CbCitiesA.Size = new System.Drawing.Size(111, 21);
            this.CbCitiesA.TabIndex = 31;
            // 
            // TbAvgSpeed
            // 
            this.TbAvgSpeed.Location = new System.Drawing.Point(295, 255);
            this.TbAvgSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.TbAvgSpeed.Name = "TbAvgSpeed";
            this.TbAvgSpeed.Size = new System.Drawing.Size(104, 20);
            this.TbAvgSpeed.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 258);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Avg speed:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 188);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Destination:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 188);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "Start:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(216, 116);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Kilometers:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(216, 53);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "Hours:";
            // 
            // LbRoutes
            // 
            this.LbRoutes.FormattingEnabled = true;
            this.LbRoutes.Location = new System.Drawing.Point(5, 5);
            this.LbRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.LbRoutes.Name = "LbRoutes";
            this.LbRoutes.Size = new System.Drawing.Size(206, 407);
            this.LbRoutes.TabIndex = 2;
            this.LbRoutes.SelectedIndexChanged += new System.EventHandler(this.LbTwsRoutes_SelectedIndexChanged);
            // 
            // TbPageSetup
            // 
            this.TbPageSetup.Controls.Add(this.BtnXmlToDb);
            this.TbPageSetup.Controls.Add(this.BtnDbToXml);
            this.TbPageSetup.Controls.Add(this.BtnCleanDatabaseRecords);
            this.TbPageSetup.Controls.Add(this.BtnInsertExampleRecords);
            this.TbPageSetup.Location = new System.Drawing.Point(4, 22);
            this.TbPageSetup.Margin = new System.Windows.Forms.Padding(2);
            this.TbPageSetup.Name = "TbPageSetup";
            this.TbPageSetup.Padding = new System.Windows.Forms.Padding(2);
            this.TbPageSetup.Size = new System.Drawing.Size(560, 420);
            this.TbPageSetup.TabIndex = 2;
            this.TbPageSetup.Text = "Setup";
            this.TbPageSetup.UseVisualStyleBackColor = true;
            // 
            // BtnCleanDatabaseRecords
            // 
            this.BtnCleanDatabaseRecords.BackColor = System.Drawing.Color.Red;
            this.BtnCleanDatabaseRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCleanDatabaseRecords.Location = new System.Drawing.Point(327, 49);
            this.BtnCleanDatabaseRecords.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCleanDatabaseRecords.Name = "BtnCleanDatabaseRecords";
            this.BtnCleanDatabaseRecords.Size = new System.Drawing.Size(165, 112);
            this.BtnCleanDatabaseRecords.TabIndex = 1;
            this.BtnCleanDatabaseRecords.Text = "Clean database records";
            this.BtnCleanDatabaseRecords.UseVisualStyleBackColor = false;
            this.BtnCleanDatabaseRecords.Click += new System.EventHandler(this.BtnCleanDatabaseRecords_Click);
            // 
            // BtnInsertExampleRecords
            // 
            this.BtnInsertExampleRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnInsertExampleRecords.Location = new System.Drawing.Point(63, 49);
            this.BtnInsertExampleRecords.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertExampleRecords.Name = "BtnInsertExampleRecords";
            this.BtnInsertExampleRecords.Size = new System.Drawing.Size(165, 112);
            this.BtnInsertExampleRecords.TabIndex = 0;
            this.BtnInsertExampleRecords.Text = "Insert example records";
            this.BtnInsertExampleRecords.UseVisualStyleBackColor = true;
            this.BtnInsertExampleRecords.Click += new System.EventHandler(this.BtnInsertExampleRecords_Click);
            // 
            // BtnDbToXml
            // 
            this.BtnDbToXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDbToXml.Location = new System.Drawing.Point(63, 230);
            this.BtnDbToXml.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDbToXml.Name = "BtnDbToXml";
            this.BtnDbToXml.Size = new System.Drawing.Size(165, 112);
            this.BtnDbToXml.TabIndex = 2;
            this.BtnDbToXml.Text = "Database to XML";
            this.BtnDbToXml.UseVisualStyleBackColor = true;
            this.BtnDbToXml.Click += new System.EventHandler(this.BtnDbToXml_Click);
            // 
            // BtnXmlToDb
            // 
            this.BtnXmlToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnXmlToDb.Location = new System.Drawing.Point(327, 230);
            this.BtnXmlToDb.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXmlToDb.Name = "BtnXmlToDb";
            this.BtnXmlToDb.Size = new System.Drawing.Size(165, 112);
            this.BtnXmlToDb.TabIndex = 3;
            this.BtnXmlToDb.Text = "XML to Database";
            this.BtnXmlToDb.UseVisualStyleBackColor = true;
            this.BtnXmlToDb.Click += new System.EventHandler(this.BtnXmlToDb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.TbControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TbControl.ResumeLayout(false);
            this.TbPageDrivers.ResumeLayout(false);
            this.TbPageDrivers.PerformLayout();
            this.TbPageTravelWarrants.ResumeLayout(false);
            this.TbPageTravelWarrants.PerformLayout();
            this.TbPageRoutes.ResumeLayout(false);
            this.TbPageRoutes.PerformLayout();
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
        private System.Windows.Forms.TabPage TbPageRoutes;
        private System.Windows.Forms.Button BtnCreateRoute;
        private System.Windows.Forms.Button BtnUpdateRoute;
        private System.Windows.Forms.Button BtnDeleteRoute;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbIdRoute;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CbCitiesB;
        private System.Windows.Forms.ComboBox CbCitiesA;
        private System.Windows.Forms.TextBox TbAvgSpeed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox LbRoutes;
        private System.Windows.Forms.TextBox TbTimeHours;
        private System.Windows.Forms.TextBox TbKilometers;
        private System.Windows.Forms.TextBox TbFuelUsed;
        private System.Windows.Forms.Button BtnImportXml;
        private System.Windows.Forms.Button BtnExportXml;
        private System.Windows.Forms.Button BtnXmlToDb;
        private System.Windows.Forms.Button BtnDbToXml;
    }
}