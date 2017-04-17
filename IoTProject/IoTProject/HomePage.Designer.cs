namespace IoTProject
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.FingerPrintMenu = new System.Windows.Forms.MenuStrip();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FingerPrintMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FingerPrintMenu
            // 
            this.FingerPrintMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.FingerPrintMenu.Location = new System.Drawing.Point(0, 0);
            this.FingerPrintMenu.Name = "FingerPrintMenu";
            this.FingerPrintMenu.Size = new System.Drawing.Size(750, 25);
            this.FingerPrintMenu.TabIndex = 1;
            this.FingerPrintMenu.Text = "menuStrip1";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.deviceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollmentToolStripMenuItem,
            this.scanToolStripMenuItem});
            this.modeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // enrollmentToolStripMenuItem
            // 
            this.enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            this.enrollmentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.enrollmentToolStripMenuItem.Text = "Enrollment Mode";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.scanToolStripMenuItem.Text = "Scan Mode";
            this.scanToolStripMenuItem.Click += new System.EventHandler(this.scanToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logSummaryToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.dataToolStripMenuItem.Text = "Help";
            // 
            // logSummaryToolStripMenuItem
            // 
            this.logSummaryToolStripMenuItem.Name = "logSummaryToolStripMenuItem";
            this.logSummaryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logSummaryToolStripMenuItem.Text = "Log Summary";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Green;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(636, 38);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(102, 34);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnrollmentButton.BackgroundImage")));
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnrollmentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentButton.ForeColor = System.Drawing.Color.DeepPink;
            this.EnrollmentButton.Location = new System.Drawing.Point(12, 103);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(163, 142);
            this.EnrollmentButton.TabIndex = 5;
            this.EnrollmentButton.UseVisualStyleBackColor = true;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportButton.BackgroundImage")));
            this.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImportButton.Location = new System.Drawing.Point(201, 103);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(163, 142);
            this.ImportButton.TabIndex = 6;
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReportButton.BackgroundImage")));
            this.ReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReportButton.Location = new System.Drawing.Point(391, 103);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(163, 142);
            this.ReportButton.TabIndex = 7;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingButton.BackgroundImage")));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingButton.Location = new System.Drawing.Point(575, 103);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(163, 142);
            this.SettingButton.TabIndex = 8;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Logged As :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel2.Text = "Admin";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel3.Text = "Status :";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel4.Text = "Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(24, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enrollment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(231, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Import ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(421, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(601, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Settings";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.FingerPrintMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FingerPrintMenu;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.FingerPrintMenu.ResumeLayout(false);
            this.FingerPrintMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FingerPrintMenu;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logSummaryToolStripMenuItem;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}