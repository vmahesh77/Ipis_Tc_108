
namespace ArecaIPIS.Forms
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.AutoIntensityTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblHeadingIpis = new System.Windows.Forms.Label();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblDynamicStationName = new System.Windows.Forms.Label();
            this.lblEthernetDevices = new System.Windows.Forms.Label();
            this.lblEtDeviceCount = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblNtes = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnVdc = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateAndTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIPISHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAboutUs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUserGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripColorConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPlayListConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVDC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripBoardDiagnosis = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDiagnosis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripBoardConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLanguageSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRedundancyPc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCCTVSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCommonSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripRegionalLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDefectiveLines = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAnnouncement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMessageScript = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StationDetailsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainInformationToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.hubConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoachDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ipAddressControlsystemaddress = new IPAddressControlLib.IPAddressControl();
            this.NtesTimer = new System.Windows.Forms.Timer(this.components);
            this.LocalAutoModeTimer = new System.Windows.Forms.Timer(this.components);
            this.LocalAutoDataDeletionTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.BtnApplicationExit = new System.Windows.Forms.Button();
            this.btnMinize = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.LblSlaveStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panForms = new System.Windows.Forms.Panel();
            this.CdotTimer = new System.Windows.Forms.Timer(this.components);
            this.btnNetwork = new System.Windows.Forms.Button();
            this.btnCdot = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSlogans = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnIntensity = new System.Windows.Forms.Button();
            this.btnSetUp = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnLcdTV = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnOnlineTrains = new System.Windows.Forms.Button();
            this.PanelSmallHeader = new System.Windows.Forms.Panel();
            this.PlayListTimer = new System.Windows.Forms.Timer(this.components);
            this.cmsAboutUs.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.cmsVDC.SuspendLayout();
            this.cmsDiagnosis.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            this.cmsView.SuspendLayout();
            this.cmsFile.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.PanelSmallHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoIntensityTimer
            // 
            this.AutoIntensityTimer.Tick += new System.EventHandler(this.AutoIntensityTimer_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(372, 51);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(94, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblHeadingIpis
            // 
            this.lblHeadingIpis.AutoSize = true;
            this.lblHeadingIpis.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadingIpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingIpis.ForeColor = System.Drawing.Color.White;
            this.lblHeadingIpis.Location = new System.Drawing.Point(195, 3);
            this.lblHeadingIpis.Name = "lblHeadingIpis";
            this.lblHeadingIpis.Size = new System.Drawing.Size(591, 33);
            this.lblHeadingIpis.TabIndex = 33;
            this.lblHeadingIpis.Text = "Integrated Passenger Information System";
            this.lblHeadingIpis.Click += new System.EventHandler(this.lblHeadingIpis_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.BackColor = System.Drawing.Color.Transparent;
            this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStationName.Location = new System.Drawing.Point(10, 101);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(128, 20);
            this.lblStationName.TabIndex = 35;
            this.lblStationName.Text = "Station Name :";
            // 
            // lblDynamicStationName
            // 
            this.lblDynamicStationName.AutoSize = true;
            this.lblDynamicStationName.BackColor = System.Drawing.Color.Transparent;
            this.lblDynamicStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDynamicStationName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDynamicStationName.Location = new System.Drawing.Point(136, 101);
            this.lblDynamicStationName.Name = "lblDynamicStationName";
            this.lblDynamicStationName.Size = new System.Drawing.Size(56, 20);
            this.lblDynamicStationName.TabIndex = 36;
            this.lblDynamicStationName.Text = "Areca";
            // 
            // lblEthernetDevices
            // 
            this.lblEthernetDevices.AutoSize = true;
            this.lblEthernetDevices.BackColor = System.Drawing.Color.Transparent;
            this.lblEthernetDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEthernetDevices.ForeColor = System.Drawing.Color.White;
            this.lblEthernetDevices.Location = new System.Drawing.Point(840, 104);
            this.lblEthernetDevices.Name = "lblEthernetDevices";
            this.lblEthernetDevices.Size = new System.Drawing.Size(164, 18);
            this.lblEthernetDevices.TabIndex = 39;
            this.lblEthernetDevices.Text = "Connected Devices :";
            // 
            // lblEtDeviceCount
            // 
            this.lblEtDeviceCount.AutoSize = true;
            this.lblEtDeviceCount.BackColor = System.Drawing.Color.Transparent;
            this.lblEtDeviceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtDeviceCount.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblEtDeviceCount.Location = new System.Drawing.Point(1010, 104);
            this.lblEtDeviceCount.Name = "lblEtDeviceCount";
            this.lblEtDeviceCount.Size = new System.Drawing.Size(116, 18);
            this.lblEtDeviceCount.TabIndex = 40;
            this.lblEtDeviceCount.Text = "999999999999";
            this.lblEtDeviceCount.Click += new System.EventHandler(this.lblEtDeviceCount_Click);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpAddress.ForeColor = System.Drawing.Color.White;
            this.lblIpAddress.Location = new System.Drawing.Point(470, 103);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(28, 18);
            this.lblIpAddress.TabIndex = 41;
            this.lblIpAddress.Text = "IP:";
            // 
            // lblNtes
            // 
            this.lblNtes.AutoSize = true;
            this.lblNtes.BackColor = System.Drawing.Color.Transparent;
            this.lblNtes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNtes.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNtes.Location = new System.Drawing.Point(1031, 8);
            this.lblNtes.Name = "lblNtes";
            this.lblNtes.Size = new System.Drawing.Size(116, 16);
            this.lblNtes.TabIndex = 42;
            this.lblNtes.Text = "NTES Disabled";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(234, 51);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(63, 30);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Visible = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(303, 52);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(63, 29);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.btnDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnDiagnosis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Location = new System.Drawing.Point(472, 52);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(100, 29);
            this.btnDiagnosis.TabIndex = 4;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Visible = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnVdc
            // 
            this.btnVdc.BackColor = System.Drawing.Color.Transparent;
            this.btnVdc.FlatAppearance.BorderSize = 0;
            this.btnVdc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVdc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVdc.ForeColor = System.Drawing.Color.White;
            this.btnVdc.Location = new System.Drawing.Point(578, 52);
            this.btnVdc.Name = "btnVdc";
            this.btnVdc.Size = new System.Drawing.Size(63, 29);
            this.btnVdc.TabIndex = 5;
            this.btnVdc.Text = "VDC";
            this.btnVdc.UseVisualStyleBackColor = false;
            this.btnVdc.Visible = false;
            this.btnVdc.Click += new System.EventHandler(this.btnVdc_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Location = new System.Drawing.Point(716, 52);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(94, 29);
            this.btnAboutUs.TabIndex = 7;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Visible = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(647, 52);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(63, 29);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Blue;
            this.lblUser.Location = new System.Drawing.Point(816, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 18);
            this.lblUser.TabIndex = 52;
            this.lblUser.Text = "USER :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(875, 56);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(112, 20);
            this.lblUserName.TabIndex = 53;
            this.lblUserName.Text = "Super Admin";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.ForeColor = System.Drawing.Color.White;
            this.lblDateAndTime.Location = new System.Drawing.Point(792, 10);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(107, 20);
            this.lblDateAndTime.TabIndex = 37;
            this.lblDateAndTime.Text = "DateAndTime";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateAndTimeTicker
            // 
            this.dateAndTimeTicker.Tick += new System.EventHandler(this.dateAndTimeTicker_Tick);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(114, 24);
            this.toolStripAbout.Text = "About";
            this.toolStripAbout.Visible = false;
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // toolStripIPISHelp
            // 
            this.toolStripIPISHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripIPISHelp.Name = "toolStripIPISHelp";
            this.toolStripIPISHelp.Size = new System.Drawing.Size(114, 24);
            this.toolStripIPISHelp.Text = "IPIS Help";
            this.toolStripIPISHelp.Visible = false;
            this.toolStripIPISHelp.Click += new System.EventHandler(this.toolStripIPISHelp_Click);
            // 
            // cmsAboutUs
            // 
            this.cmsAboutUs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAbout,
            this.toolStripIPISHelp});
            this.cmsAboutUs.Name = "cmsFile";
            this.cmsAboutUs.ShowImageMargin = false;
            this.cmsAboutUs.Size = new System.Drawing.Size(115, 52);
            // 
            // toolStripCreateUser
            // 
            this.toolStripCreateUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCreateUser.Name = "toolStripCreateUser";
            this.toolStripCreateUser.Size = new System.Drawing.Size(138, 24);
            this.toolStripCreateUser.Text = "Create User";
            this.toolStripCreateUser.Click += new System.EventHandler(this.toolStripCreateUser_Click);
            // 
            // toolStripUserGroups
            // 
            this.toolStripUserGroups.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripUserGroups.Name = "toolStripUserGroups";
            this.toolStripUserGroups.Size = new System.Drawing.Size(138, 24);
            this.toolStripUserGroups.Text = "User Groups";
            this.toolStripUserGroups.Click += new System.EventHandler(this.toolStripUserGroups_Click);
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreateUser,
            this.toolStripUserGroups});
            this.cmsUser.Name = "cmsFile";
            this.cmsUser.ShowImageMargin = false;
            this.cmsUser.Size = new System.Drawing.Size(139, 52);
            // 
            // toolStripColorConfiguration
            // 
            this.toolStripColorConfiguration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripColorConfiguration.Name = "toolStripColorConfiguration";
            this.toolStripColorConfiguration.Size = new System.Drawing.Size(206, 24);
            this.toolStripColorConfiguration.Text = "Color Configuration";
            this.toolStripColorConfiguration.Visible = false;
            this.toolStripColorConfiguration.Click += new System.EventHandler(this.toolStripColorConfiguration_Click);
            // 
            // toolStripPlayListConfiguration
            // 
            this.toolStripPlayListConfiguration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripPlayListConfiguration.Name = "toolStripPlayListConfiguration";
            this.toolStripPlayListConfiguration.Size = new System.Drawing.Size(206, 24);
            this.toolStripPlayListConfiguration.Text = "PlayList Configuration";
            this.toolStripPlayListConfiguration.Visible = false;
            this.toolStripPlayListConfiguration.Click += new System.EventHandler(this.toolStripPlayListConfiguration_Click);
            // 
            // cmsVDC
            // 
            this.cmsVDC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripColorConfiguration,
            this.toolStripPlayListConfiguration});
            this.cmsVDC.Name = "cmsFile";
            this.cmsVDC.ShowImageMargin = false;
            this.cmsVDC.Size = new System.Drawing.Size(207, 52);
            this.cmsVDC.Opening += new System.ComponentModel.CancelEventHandler(this.cmsVDC_Opening);
            // 
            // toolStripBoardDiagnosis
            // 
            this.toolStripBoardDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBoardDiagnosis.Name = "toolStripBoardDiagnosis";
            this.toolStripBoardDiagnosis.Size = new System.Drawing.Size(165, 24);
            this.toolStripBoardDiagnosis.Text = "Board Diagnosis";
            this.toolStripBoardDiagnosis.Visible = false;
            this.toolStripBoardDiagnosis.Click += new System.EventHandler(this.toolStripBoardDiagnosis_Click);
            // 
            // cmsDiagnosis
            // 
            this.cmsDiagnosis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoardDiagnosis});
            this.cmsDiagnosis.Name = "cmsFile";
            this.cmsDiagnosis.ShowImageMargin = false;
            this.cmsDiagnosis.Size = new System.Drawing.Size(166, 28);
            // 
            // toolStripBoardConfiguration
            // 
            this.toolStripBoardConfiguration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBoardConfiguration.Name = "toolStripBoardConfiguration";
            this.toolStripBoardConfiguration.Size = new System.Drawing.Size(194, 24);
            this.toolStripBoardConfiguration.Text = "Board Configuration";
            this.toolStripBoardConfiguration.Visible = false;
            this.toolStripBoardConfiguration.Click += new System.EventHandler(this.toolStripBoardConfiguration_Click);
            // 
            // toolStripLanguageSettings
            // 
            this.toolStripLanguageSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLanguageSettings.Name = "toolStripLanguageSettings";
            this.toolStripLanguageSettings.Size = new System.Drawing.Size(194, 24);
            this.toolStripLanguageSettings.Text = "Languages Settings ";
            this.toolStripLanguageSettings.Visible = false;
            this.toolStripLanguageSettings.Click += new System.EventHandler(this.toolStripLanguageSettings_Click);
            // 
            // toolStripRedundancyPc
            // 
            this.toolStripRedundancyPc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripRedundancyPc.ImageTransparentColor = System.Drawing.Color.Red;
            this.toolStripRedundancyPc.Name = "toolStripRedundancyPc";
            this.toolStripRedundancyPc.Size = new System.Drawing.Size(194, 24);
            this.toolStripRedundancyPc.Text = "Redundancy PC";
            this.toolStripRedundancyPc.Visible = false;
            this.toolStripRedundancyPc.Click += new System.EventHandler(this.toolStripRedundancyPc_Click);
            // 
            // toolStripCCTVSettings
            // 
            this.toolStripCCTVSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripCCTVSettings.Name = "toolStripCCTVSettings";
            this.toolStripCCTVSettings.Size = new System.Drawing.Size(194, 24);
            this.toolStripCCTVSettings.Text = "CCTV Settings";
            this.toolStripCCTVSettings.Visible = false;
            this.toolStripCCTVSettings.Click += new System.EventHandler(this.toolStripCCTVSettings_Click);
            // 
            // toolStripCommonSettings
            // 
            this.toolStripCommonSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripCommonSettings.Name = "toolStripCommonSettings";
            this.toolStripCommonSettings.Size = new System.Drawing.Size(194, 24);
            this.toolStripCommonSettings.Text = "Common Settings";
            this.toolStripCommonSettings.Visible = false;
            this.toolStripCommonSettings.Click += new System.EventHandler(this.toolStripCommonSettings_Click);
            // 
            // cmsSettings
            // 
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoardConfiguration,
            this.toolStripLanguageSettings,
            this.toolStripRedundancyPc,
            this.toolStripCCTVSettings,
            this.toolStripCommonSettings});
            this.cmsSettings.Name = "cmsFile";
            this.cmsSettings.ShowImageMargin = false;
            this.cmsSettings.Size = new System.Drawing.Size(195, 124);
            // 
            // toolStripRegionalLanguage
            // 
            this.toolStripRegionalLanguage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripRegionalLanguage.Name = "toolStripRegionalLanguage";
            this.toolStripRegionalLanguage.Size = new System.Drawing.Size(234, 24);
            this.toolStripRegionalLanguage.Text = "Regional Language Status";
            this.toolStripRegionalLanguage.Visible = false;
            this.toolStripRegionalLanguage.Click += new System.EventHandler(this.toolStripRegionalLanguage_Click);
            // 
            // toolStripDefectiveLines
            // 
            this.toolStripDefectiveLines.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripDefectiveLines.Name = "toolStripDefectiveLines";
            this.toolStripDefectiveLines.Size = new System.Drawing.Size(234, 24);
            this.toolStripDefectiveLines.Text = "Defective Lines In TADB";
            this.toolStripDefectiveLines.Visible = false;
            this.toolStripDefectiveLines.Click += new System.EventHandler(this.toolStripDefectiveLines_Click);
            // 
            // toolStripAnnouncement
            // 
            this.toolStripAnnouncement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripAnnouncement.ImageTransparentColor = System.Drawing.Color.Red;
            this.toolStripAnnouncement.Name = "toolStripAnnouncement";
            this.toolStripAnnouncement.Size = new System.Drawing.Size(234, 24);
            this.toolStripAnnouncement.Text = "Announcement Script";
            this.toolStripAnnouncement.Visible = false;
            this.toolStripAnnouncement.Click += new System.EventHandler(this.toolStripAnnouncement_Click);
            // 
            // toolStripMessageScript
            // 
            this.toolStripMessageScript.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripMessageScript.Name = "toolStripMessageScript";
            this.toolStripMessageScript.Size = new System.Drawing.Size(234, 24);
            this.toolStripMessageScript.Text = "Message Script";
            this.toolStripMessageScript.Visible = false;
            this.toolStripMessageScript.Click += new System.EventHandler(this.toolStripMessageScript_Click);
            // 
            // cmsView
            // 
            this.cmsView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRegionalLanguage,
            this.toolStripDefectiveLines,
            this.toolStripAnnouncement,
            this.toolStripMessageScript});
            this.cmsView.Name = "cmsFile";
            this.cmsView.ShowImageMargin = false;
            this.cmsView.Size = new System.Drawing.Size(235, 100);
            // 
            // StationDetailsToolStrip
            // 
            this.StationDetailsToolStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationDetailsToolStrip.ImageTransparentColor = System.Drawing.Color.Red;
            this.StationDetailsToolStrip.Name = "StationDetailsToolStrip";
            this.StationDetailsToolStrip.Size = new System.Drawing.Size(181, 24);
            this.StationDetailsToolStrip.Text = "Station Details";
            this.StationDetailsToolStrip.Visible = false;
            this.StationDetailsToolStrip.Click += new System.EventHandler(this.StationDetailsToolStrip_Click);
            // 
            // TrainInformationToolStrip
            // 
            this.TrainInformationToolStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.TrainInformationToolStrip.Name = "TrainInformationToolStrip";
            this.TrainInformationToolStrip.Size = new System.Drawing.Size(181, 24);
            this.TrainInformationToolStrip.Text = "Train Information";
            this.TrainInformationToolStrip.Visible = false;
            this.TrainInformationToolStrip.Click += new System.EventHandler(this.TrainInformationToolStrip_Click);
            // 
            // hubConfigurationToolStripMenuItem
            // 
            this.hubConfigurationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.hubConfigurationToolStripMenuItem.Name = "hubConfigurationToolStripMenuItem";
            this.hubConfigurationToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.hubConfigurationToolStripMenuItem.Text = "Hub Configuration";
            this.hubConfigurationToolStripMenuItem.Visible = false;
            this.hubConfigurationToolStripMenuItem.Click += new System.EventHandler(this.hubConfigurationToolStripMenuItem_Click);
            // 
            // addStationToolStripMenuItem
            // 
            this.addStationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.addStationToolStripMenuItem.Name = "addStationToolStripMenuItem";
            this.addStationToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addStationToolStripMenuItem.Text = "Add Station";
            this.addStationToolStripMenuItem.Visible = false;
            this.addStationToolStripMenuItem.Click += new System.EventHandler(this.addStationToolStripMenuItem_Click);
            // 
            // addCoachDataToolStripMenuItem
            // 
            this.addCoachDataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.addCoachDataToolStripMenuItem.Name = "addCoachDataToolStripMenuItem";
            this.addCoachDataToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.addCoachDataToolStripMenuItem.Text = "Add Coach Data";
            this.addCoachDataToolStripMenuItem.Visible = false;
            this.addCoachDataToolStripMenuItem.Click += new System.EventHandler(this.addCoachDataToolStripMenuItem_Click);
            // 
            // cmsFile
            // 
            this.cmsFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StationDetailsToolStrip,
            this.TrainInformationToolStrip,
            this.hubConfigurationToolStripMenuItem,
            this.addStationToolStripMenuItem,
            this.addCoachDataToolStripMenuItem});
            this.cmsFile.Name = "cmsFile";
            this.cmsFile.ShowImageMargin = false;
            this.cmsFile.Size = new System.Drawing.Size(182, 124);
            // 
            // ipAddressControlsystemaddress
            // 
            this.ipAddressControlsystemaddress.AllowInternalTab = false;
            this.ipAddressControlsystemaddress.AutoHeight = true;
            this.ipAddressControlsystemaddress.BackColor = System.Drawing.Color.White;
            this.ipAddressControlsystemaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipAddressControlsystemaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControlsystemaddress.ForeColor = System.Drawing.Color.Maroon;
            this.ipAddressControlsystemaddress.Location = new System.Drawing.Point(504, 103);
            this.ipAddressControlsystemaddress.MinimumSize = new System.Drawing.Size(120, 18);
            this.ipAddressControlsystemaddress.Name = "ipAddressControlsystemaddress";
            this.ipAddressControlsystemaddress.ReadOnly = false;
            this.ipAddressControlsystemaddress.Size = new System.Drawing.Size(132, 18);
            this.ipAddressControlsystemaddress.TabIndex = 24;
            this.ipAddressControlsystemaddress.Text = "...";
            // 
            // NtesTimer
            // 
            this.NtesTimer.Interval = 180000;
            this.NtesTimer.Tick += new System.EventHandler(this.NtesTimer_Tick);
            // 
            // LocalAutoModeTimer
            // 
            this.LocalAutoModeTimer.Interval = 100000000;
            this.LocalAutoModeTimer.Tick += new System.EventHandler(this.LocalAutoModeTimer_Tick);
            // 
            // LocalAutoDataDeletionTimer
            // 
            this.LocalAutoDataDeletionTimer.Interval = 10000000;
            this.LocalAutoDataDeletionTimer.Tick += new System.EventHandler(this.LocalAutoDataDeletionTimer_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.pnlMain.Controls.Add(this.BtnApplicationExit);
            this.pnlMain.Controls.Add(this.btnMinize);
            this.pnlMain.Controls.Add(this.picLogo);
            this.pnlMain.Controls.Add(this.LblSlaveStatus);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.btnLogOut);
            this.pnlMain.Controls.Add(this.pctLogo);
            this.pnlMain.Controls.Add(this.lblStationName);
            this.pnlMain.Controls.Add(this.btnFile);
            this.pnlMain.Controls.Add(this.lblHeadingIpis);
            this.pnlMain.Controls.Add(this.btnView);
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.lblDynamicStationName);
            this.pnlMain.Controls.Add(this.lblIpAddress);
            this.pnlMain.Controls.Add(this.ipAddressControlsystemaddress);
            this.pnlMain.Controls.Add(this.btnDiagnosis);
            this.pnlMain.Controls.Add(this.btnVdc);
            this.pnlMain.Controls.Add(this.btnUser);
            this.pnlMain.Controls.Add(this.lblEthernetDevices);
            this.pnlMain.Controls.Add(this.btnAboutUs);
            this.pnlMain.Controls.Add(this.lblDateAndTime);
            this.pnlMain.Controls.Add(this.lblUserName);
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Controls.Add(this.lblNtes);
            this.pnlMain.Controls.Add(this.lblEtDeviceCount);
            this.pnlMain.Controls.Add(this.panForms);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.ForeColor = System.Drawing.Color.DarkBlue;
            this.pnlMain.Location = new System.Drawing.Point(-2, -1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1358, 124);
            this.pnlMain.TabIndex = 70;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnApplicationExit
            // 
            this.BtnApplicationExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnApplicationExit.BackgroundImage")));
            this.BtnApplicationExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnApplicationExit.FlatAppearance.BorderSize = 0;
            this.BtnApplicationExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApplicationExit.Location = new System.Drawing.Point(1331, 4);
            this.BtnApplicationExit.Name = "BtnApplicationExit";
            this.BtnApplicationExit.Size = new System.Drawing.Size(23, 23);
            this.BtnApplicationExit.TabIndex = 81;
            this.BtnApplicationExit.UseVisualStyleBackColor = true;
            this.BtnApplicationExit.Click += new System.EventHandler(this.BtnApplicationExit_Click);
            // 
            // btnMinize
            // 
            this.btnMinize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinize.BackgroundImage")));
            this.btnMinize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinize.FlatAppearance.BorderSize = 0;
            this.btnMinize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinize.Location = new System.Drawing.Point(1300, 4);
            this.btnMinize.Name = "btnMinize";
            this.btnMinize.Size = new System.Drawing.Size(23, 23);
            this.btnMinize.TabIndex = 80;
            this.btnMinize.UseVisualStyleBackColor = true;
            this.btnMinize.Click += new System.EventHandler(this.btnMinize_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(1177, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(117, 92);
            this.picLogo.TabIndex = 76;
            this.picLogo.TabStop = false;
            // 
            // LblSlaveStatus
            // 
            this.LblSlaveStatus.AutoSize = true;
            this.LblSlaveStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblSlaveStatus.ForeColor = System.Drawing.Color.White;
            this.LblSlaveStatus.Location = new System.Drawing.Point(642, 104);
            this.LblSlaveStatus.Name = "LblSlaveStatus";
            this.LblSlaveStatus.Size = new System.Drawing.Size(192, 18);
            this.LblSlaveStatus.TabIndex = 72;
            this.LblSlaveStatus.Text = "Redundancy Mode(OFF)";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Snow;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::ArecaIPIS.Properties.Resources._8726304_refresh_icon;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1147, 97);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 24);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::ArecaIPIS.Properties.Resources._9068712_logout_icon;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1254, 97);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 22);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.Location = new System.Drawing.Point(3, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(189, 95);
            this.pctLogo.TabIndex = 71;
            this.pctLogo.TabStop = false;
            // 
            // panForms
            // 
            this.panForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panForms.AutoScroll = true;
            this.panForms.BackColor = System.Drawing.Color.Transparent;
            this.panForms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panForms.Location = new System.Drawing.Point(1034, 59);
            this.panForms.Name = "panForms";
            this.panForms.Size = new System.Drawing.Size(40, 36);
            this.panForms.TabIndex = 38;
            // 
            // CdotTimer
            // 
            this.CdotTimer.Interval = 120000;
            this.CdotTimer.Tick += new System.EventHandler(this.CdotTimer_Tick);
            // 
            // btnNetwork
            // 
            this.btnNetwork.BackColor = System.Drawing.Color.Transparent;
            this.btnNetwork.FlatAppearance.BorderSize = 0;
            this.btnNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetwork.ForeColor = System.Drawing.Color.Black;
            this.btnNetwork.Location = new System.Drawing.Point(859, 5);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(88, 37);
            this.btnNetwork.TabIndex = 17;
            this.btnNetwork.Text = "Network";
            this.btnNetwork.UseVisualStyleBackColor = false;
            this.btnNetwork.Visible = false;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnCdot
            // 
            this.btnCdot.BackColor = System.Drawing.Color.Transparent;
            this.btnCdot.FlatAppearance.BorderSize = 0;
            this.btnCdot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdot.ForeColor = System.Drawing.Color.Black;
            this.btnCdot.Location = new System.Drawing.Point(1108, 5);
            this.btnCdot.Name = "btnCdot";
            this.btnCdot.Size = new System.Drawing.Size(70, 37);
            this.btnCdot.TabIndex = 20;
            this.btnCdot.Text = "CDOT";
            this.btnCdot.UseVisualStyleBackColor = false;
            this.btnCdot.Visible = false;
            this.btnCdot.Click += new System.EventHandler(this.btnCdot_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(951, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(79, 37);
            this.btnReports.TabIndex = 18;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSlogans
            // 
            this.btnSlogans.BackColor = System.Drawing.Color.Transparent;
            this.btnSlogans.FlatAppearance.BorderSize = 0;
            this.btnSlogans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSlogans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlogans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlogans.ForeColor = System.Drawing.Color.Black;
            this.btnSlogans.Location = new System.Drawing.Point(1182, 5);
            this.btnSlogans.Name = "btnSlogans";
            this.btnSlogans.Size = new System.Drawing.Size(82, 37);
            this.btnSlogans.TabIndex = 21;
            this.btnSlogans.Text = "Slogans";
            this.btnSlogans.UseVisualStyleBackColor = false;
            this.btnSlogans.Visible = false;
            this.btnSlogans.Click += new System.EventHandler(this.btnSlogans_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(1034, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 37);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.BackColor = System.Drawing.Color.Transparent;
            this.btnInterface.FlatAppearance.BorderSize = 0;
            this.btnInterface.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterface.ForeColor = System.Drawing.Color.Black;
            this.btnInterface.Location = new System.Drawing.Point(764, 5);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(91, 37);
            this.btnInterface.TabIndex = 16;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = false;
            this.btnInterface.Visible = false;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnIntensity
            // 
            this.btnIntensity.BackColor = System.Drawing.Color.Transparent;
            this.btnIntensity.FlatAppearance.BorderSize = 0;
            this.btnIntensity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIntensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntensity.ForeColor = System.Drawing.Color.Black;
            this.btnIntensity.Location = new System.Drawing.Point(673, 5);
            this.btnIntensity.Name = "btnIntensity";
            this.btnIntensity.Size = new System.Drawing.Size(87, 37);
            this.btnIntensity.TabIndex = 15;
            this.btnIntensity.Text = "Intensity";
            this.btnIntensity.UseVisualStyleBackColor = false;
            this.btnIntensity.Visible = false;
            this.btnIntensity.Click += new System.EventHandler(this.btnIntensity_Click);
            // 
            // btnSetUp
            // 
            this.btnSetUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSetUp.FlatAppearance.BorderSize = 0;
            this.btnSetUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUp.ForeColor = System.Drawing.Color.Black;
            this.btnSetUp.Location = new System.Drawing.Point(592, 5);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(77, 37);
            this.btnSetUp.TabIndex = 14;
            this.btnSetUp.Text = "Setup";
            this.btnSetUp.UseVisualStyleBackColor = false;
            this.btnSetUp.Visible = false;
            this.btnSetUp.Click += new System.EventHandler(this.btnSetUp_Click);
            // 
            // btnPA
            // 
            this.btnPA.BackColor = System.Drawing.Color.Transparent;
            this.btnPA.FlatAppearance.BorderSize = 0;
            this.btnPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPA.ForeColor = System.Drawing.Color.Black;
            this.btnPA.Location = new System.Drawing.Point(250, 5);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(77, 37);
            this.btnPA.TabIndex = 10;
            this.btnPA.Text = "PA";
            this.btnPA.UseVisualStyleBackColor = false;
            this.btnPA.Visible = false;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.Color.Black;
            this.btnMessages.Location = new System.Drawing.Point(488, 5);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(100, 37);
            this.btnMessages.TabIndex = 13;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Visible = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnLcdTV
            // 
            this.btnLcdTV.BackColor = System.Drawing.Color.Transparent;
            this.btnLcdTV.FlatAppearance.BorderSize = 0;
            this.btnLcdTV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLcdTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLcdTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLcdTV.ForeColor = System.Drawing.Color.Black;
            this.btnLcdTV.Location = new System.Drawing.Point(405, 5);
            this.btnLcdTV.Name = "btnLcdTV";
            this.btnLcdTV.Size = new System.Drawing.Size(79, 37);
            this.btnLcdTV.TabIndex = 12;
            this.btnLcdTV.Text = "LCD TV";
            this.btnLcdTV.UseVisualStyleBackColor = false;
            this.btnLcdTV.Visible = false;
            this.btnLcdTV.Click += new System.EventHandler(this.btnLcdTV_Click_1);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Transparent;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.Black;
            this.btnMedia.Location = new System.Drawing.Point(331, 5);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(70, 37);
            this.btnMedia.TabIndex = 11;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Visible = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.Transparent;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.Color.Black;
            this.btnLink.Location = new System.Drawing.Point(176, 5);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(70, 37);
            this.btnLink.TabIndex = 9;
            this.btnLink.Text = "Link";
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Visible = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnOnlineTrains
            // 
            this.btnOnlineTrains.BackColor = System.Drawing.Color.Transparent;
            this.btnOnlineTrains.FlatAppearance.BorderSize = 0;
            this.btnOnlineTrains.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOnlineTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnlineTrains.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlineTrains.ForeColor = System.Drawing.Color.Black;
            this.btnOnlineTrains.Location = new System.Drawing.Point(49, 5);
            this.btnOnlineTrains.Name = "btnOnlineTrains";
            this.btnOnlineTrains.Size = new System.Drawing.Size(123, 37);
            this.btnOnlineTrains.TabIndex = 8;
            this.btnOnlineTrains.Text = "OnLine Trains";
            this.btnOnlineTrains.UseVisualStyleBackColor = false;
            this.btnOnlineTrains.Visible = false;
            this.btnOnlineTrains.Click += new System.EventHandler(this.btnOnlineTrains_Click);
            // 
            // PanelSmallHeader
            // 
            this.PanelSmallHeader.BackColor = System.Drawing.Color.White;
            this.PanelSmallHeader.Controls.Add(this.btnOnlineTrains);
            this.PanelSmallHeader.Controls.Add(this.btnLink);
            this.PanelSmallHeader.Controls.Add(this.btnMedia);
            this.PanelSmallHeader.Controls.Add(this.btnLcdTV);
            this.PanelSmallHeader.Controls.Add(this.btnMessages);
            this.PanelSmallHeader.Controls.Add(this.btnPA);
            this.PanelSmallHeader.Controls.Add(this.btnSetUp);
            this.PanelSmallHeader.Controls.Add(this.btnIntensity);
            this.PanelSmallHeader.Controls.Add(this.btnInterface);
            this.PanelSmallHeader.Controls.Add(this.btnHelp);
            this.PanelSmallHeader.Controls.Add(this.btnSlogans);
            this.PanelSmallHeader.Controls.Add(this.btnReports);
            this.PanelSmallHeader.Controls.Add(this.btnCdot);
            this.PanelSmallHeader.Controls.Add(this.btnNetwork);
            this.PanelSmallHeader.ForeColor = System.Drawing.Color.Black;
            this.PanelSmallHeader.Location = new System.Drawing.Point(-2, 124);
            this.PanelSmallHeader.Name = "PanelSmallHeader";
            this.PanelSmallHeader.Size = new System.Drawing.Size(1358, 46);
            this.PanelSmallHeader.TabIndex = 71;
            this.PanelSmallHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSmallHeader_Paint);
            // 
            // PlayListTimer
            // 
            this.PlayListTimer.Interval = 60000;
            this.PlayListTimer.Tick += new System.EventHandler(this.PlayListTimer_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1358, 170);
            this.Controls.Add(this.PanelSmallHeader);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.cmsAboutUs.ResumeLayout(false);
            this.cmsUser.ResumeLayout(false);
            this.cmsVDC.ResumeLayout(false);
            this.cmsDiagnosis.ResumeLayout(false);
            this.cmsSettings.ResumeLayout(false);
            this.cmsView.ResumeLayout(false);
            this.cmsFile.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.PanelSmallHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer AutoIntensityTimer;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblHeadingIpis;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblDynamicStationName;
        private System.Windows.Forms.Label lblEthernetDevices;
        private System.Windows.Forms.Label lblEtDeviceCount;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblNtes;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnVdc;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer dateAndTimeTicker;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripIPISHelp;
        private System.Windows.Forms.ContextMenuStrip cmsAboutUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripUserGroups;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripColorConfiguration;
        private System.Windows.Forms.ToolStripMenuItem toolStripPlayListConfiguration;
        private System.Windows.Forms.ContextMenuStrip cmsVDC;
        private System.Windows.Forms.ToolStripMenuItem toolStripBoardDiagnosis;
        private System.Windows.Forms.ContextMenuStrip cmsDiagnosis;
        private System.Windows.Forms.ToolStripMenuItem toolStripBoardConfiguration;
        private System.Windows.Forms.ToolStripMenuItem toolStripLanguageSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripRedundancyPc;
        private System.Windows.Forms.ToolStripMenuItem toolStripCCTVSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripCommonSettings;
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegionalLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolStripDefectiveLines;
        private System.Windows.Forms.ToolStripMenuItem toolStripAnnouncement;
        private System.Windows.Forms.ToolStripMenuItem toolStripMessageScript;
        private System.Windows.Forms.ContextMenuStrip cmsView;
        private System.Windows.Forms.ToolStripMenuItem StationDetailsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem TrainInformationToolStrip;
        private System.Windows.Forms.ToolStripMenuItem hubConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoachDataToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsFile;
        private IPAddressControlLib.IPAddressControl ipAddressControlsystemaddress;
        private System.Windows.Forms.Timer NtesTimer;
        private System.Windows.Forms.Timer LocalAutoModeTimer;
        private System.Windows.Forms.Timer LocalAutoDataDeletionTimer;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer CdotTimer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label LblSlaveStatus;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Button btnCdot;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSlogans;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnIntensity;
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.Button btnPA;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnLcdTV;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnOnlineTrains;
        private System.Windows.Forms.Panel PanelSmallHeader;
        private System.Windows.Forms.Panel panForms;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button BtnApplicationExit;
        private System.Windows.Forms.Button btnMinize;
        private System.Windows.Forms.Timer PlayListTimer;
    }
}