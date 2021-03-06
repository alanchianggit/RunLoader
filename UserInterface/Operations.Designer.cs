﻿namespace ALSTools
{
    partial class Operations
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSigninToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.openFileAccessFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAccessFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.eventsWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.openFileAccessFormToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSigninToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectLogToolStripMenuItem});
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSessionToolStripMenuItem.Text = "&Session";
            // 
            // newSigninToolStripMenuItem
            // 
            this.newSigninToolStripMenuItem.Name = "newSigninToolStripMenuItem";
            this.newSigninToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSigninToolStripMenuItem.Text = "Sign-In";
            this.newSigninToolStripMenuItem.Click += new System.EventHandler(this.newSigninToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // selectLogToolStripMenuItem
            // 
            this.selectLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectInstrumentToolStripMenuItem});
            this.selectLogToolStripMenuItem.Name = "selectLogToolStripMenuItem";
            this.selectLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectLogToolStripMenuItem.Text = "Select Log";
            // 
            // selectInstrumentToolStripMenuItem
            // 
            this.selectInstrumentToolStripMenuItem.Name = "selectInstrumentToolStripMenuItem";
            this.selectInstrumentToolStripMenuItem.Size = new System.Drawing.Size(166, 23);
            this.selectInstrumentToolStripMenuItem.Text = "Select Instrument";
            this.selectInstrumentToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.selectInstrumentToolStripMenuItem_SelectedIndexChanged);
            // 
            // openFileAccessFormToolStripMenuItem
            // 
            this.openFileAccessFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.openFileAccessFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiverToolStripMenuItem,
            this.fileAccessFormToolStripMenuItem,
            this.dataCheckerToolStripMenuItem,
            this.toolStripSeparator1,
            this.eventsWindowsToolStripMenuItem,
            this.productionManagementToolStripMenuItem,
            this.analysisManagementToolStripMenuItem,
            this.xMLControlToolStripMenuItem});
            this.openFileAccessFormToolStripMenuItem.Name = "openFileAccessFormToolStripMenuItem";
            this.openFileAccessFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileAccessFormToolStripMenuItem.Text = "&Open";
            // 
            // archiverToolStripMenuItem
            // 
            this.archiverToolStripMenuItem.Name = "archiverToolStripMenuItem";
            this.archiverToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.archiverToolStripMenuItem.Text = "A&rchiver";
            this.archiverToolStripMenuItem.Click += new System.EventHandler(this.archiverToolStripMenuItem_Click);
            // 
            // fileAccessFormToolStripMenuItem
            // 
            this.fileAccessFormToolStripMenuItem.Name = "fileAccessFormToolStripMenuItem";
            this.fileAccessFormToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fileAccessFormToolStripMenuItem.Text = "&File Access Form";
            this.fileAccessFormToolStripMenuItem.Click += new System.EventHandler(this.fileAccessFormToolStripMenuItem_Click);
            // 
            // dataCheckerToolStripMenuItem
            // 
            this.dataCheckerToolStripMenuItem.Name = "dataCheckerToolStripMenuItem";
            this.dataCheckerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dataCheckerToolStripMenuItem.Text = "Data Checker";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // eventsWindowsToolStripMenuItem
            // 
            this.eventsWindowsToolStripMenuItem.Name = "eventsWindowsToolStripMenuItem";
            this.eventsWindowsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.eventsWindowsToolStripMenuItem.Text = "Events Management";
            this.eventsWindowsToolStripMenuItem.Click += new System.EventHandler(this.eventsWindowsToolStripMenuItem_Click);
            // 
            // productionManagementToolStripMenuItem
            // 
            this.productionManagementToolStripMenuItem.Name = "productionManagementToolStripMenuItem";
            this.productionManagementToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.productionManagementToolStripMenuItem.Text = "Production Management";
            this.productionManagementToolStripMenuItem.Click += new System.EventHandler(this.productionManagementToolStripMenuItem_Click);
            // 
            // analysisManagementToolStripMenuItem
            // 
            this.analysisManagementToolStripMenuItem.Name = "analysisManagementToolStripMenuItem";
            this.analysisManagementToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.analysisManagementToolStripMenuItem.Text = "&Analysis Management";
            this.analysisManagementToolStripMenuItem.Click += new System.EventHandler(this.analysisManagementToolStripMenuItem_Click);
            // 
            // xMLControlToolStripMenuItem
            // 
            this.xMLControlToolStripMenuItem.Name = "xMLControlToolStripMenuItem";
            this.xMLControlToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.xMLControlToolStripMenuItem.Text = "XML Control";
            this.xMLControlToolStripMenuItem.Click += new System.EventHandler(this.xMLControlToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 803);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1491, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1491, 825);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Operations";
            this.Text = "Operations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileAccessFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileAccessFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSigninToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eventsWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox selectInstrumentToolStripMenuItem;
    }
}