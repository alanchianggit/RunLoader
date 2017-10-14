﻿namespace RunLoader
{
    partial class FileAccessForm
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
            this.btn_ConnectDB = new System.Windows.Forms.Button();
            this.btn_BrowseAccess = new System.Windows.Forms.Button();
            this.btn_SelectOutput = new System.Windows.Forms.Button();
            this.btn_LoadFileTable = new System.Windows.Forms.Button();
            this.txt_FileLocation = new System.Windows.Forms.TextBox();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.tv_OutputFiles = new System.Windows.Forms.TreeView();
            this.tv_InputFiles = new System.Windows.Forms.TreeView();
            this.btn_SelectInputFiles = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ConnectDB
            // 
            this.btn_ConnectDB.Location = new System.Drawing.Point(365, 29);
            this.btn_ConnectDB.Name = "btn_ConnectDB";
            this.btn_ConnectDB.Size = new System.Drawing.Size(75, 20);
            this.btn_ConnectDB.TabIndex = 1;
            this.btn_ConnectDB.Text = "Connect";
            this.btn_ConnectDB.UseVisualStyleBackColor = true;
            this.btn_ConnectDB.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_BrowseAccess
            // 
            this.btn_BrowseAccess.Location = new System.Drawing.Point(325, 29);
            this.btn_BrowseAccess.Name = "btn_BrowseAccess";
            this.btn_BrowseAccess.Size = new System.Drawing.Size(31, 20);
            this.btn_BrowseAccess.TabIndex = 1;
            this.btn_BrowseAccess.Text = "...";
            this.btn_BrowseAccess.UseVisualStyleBackColor = true;
            this.btn_BrowseAccess.Click += new System.EventHandler(this.btn_BrowseAccess_Click);
            // 
            // btn_SelectOutput
            // 
            this.btn_SelectOutput.Location = new System.Drawing.Point(325, 376);
            this.btn_SelectOutput.Name = "btn_SelectOutput";
            this.btn_SelectOutput.Size = new System.Drawing.Size(31, 20);
            this.btn_SelectOutput.TabIndex = 1;
            this.btn_SelectOutput.Text = "...";
            this.btn_SelectOutput.UseVisualStyleBackColor = true;
            this.btn_SelectOutput.Click += new System.EventHandler(this.btn_SelectOutput_Click);
            // 
            // btn_LoadFileTable
            // 
            this.btn_LoadFileTable.Location = new System.Drawing.Point(19, 332);
            this.btn_LoadFileTable.Name = "btn_LoadFileTable";
            this.btn_LoadFileTable.Size = new System.Drawing.Size(106, 23);
            this.btn_LoadFileTable.TabIndex = 1;
            this.btn_LoadFileTable.Text = "Load File Table";
            this.btn_LoadFileTable.UseVisualStyleBackColor = true;
            this.btn_LoadFileTable.Click += new System.EventHandler(this.btn_LoadFileTable_Click);
            // 
            // txt_FileLocation
            // 
            this.txt_FileLocation.Location = new System.Drawing.Point(19, 29);
            this.txt_FileLocation.Name = "txt_FileLocation";
            this.txt_FileLocation.Size = new System.Drawing.Size(300, 20);
            this.txt_FileLocation.TabIndex = 2;
            // 
            // txt_Output
            // 
            this.txt_Output.Enabled = false;
            this.txt_Output.Location = new System.Drawing.Point(19, 376);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(300, 20);
            this.txt_Output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Database (Access (*.accdb, *.db, *.mdb):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Download Folder:";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(19, 412);
            this.txt_status.Multiline = true;
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(719, 91);
            this.txt_status.TabIndex = 7;
            // 
            // tv_OutputFiles
            // 
            this.tv_OutputFiles.CheckBoxes = true;
            this.tv_OutputFiles.Location = new System.Drawing.Point(19, 55);
            this.tv_OutputFiles.Name = "tv_OutputFiles";
            this.tv_OutputFiles.Size = new System.Drawing.Size(374, 271);
            this.tv_OutputFiles.TabIndex = 8;
            // 
            // tv_InputFiles
            // 
            this.tv_InputFiles.CheckBoxes = true;
            this.tv_InputFiles.Location = new System.Drawing.Point(399, 55);
            this.tv_InputFiles.Name = "tv_InputFiles";
            this.tv_InputFiles.Size = new System.Drawing.Size(339, 271);
            this.tv_InputFiles.TabIndex = 8;
            this.tv_InputFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_InputFiles_AfterCheck);
            // 
            // btn_SelectInputFiles
            // 
            this.btn_SelectInputFiles.Location = new System.Drawing.Point(399, 332);
            this.btn_SelectInputFiles.Name = "btn_SelectInputFiles";
            this.btn_SelectInputFiles.Size = new System.Drawing.Size(110, 23);
            this.btn_SelectInputFiles.TabIndex = 1;
            this.btn_SelectInputFiles.Text = "Select Input Files";
            this.btn_SelectInputFiles.UseVisualStyleBackColor = true;
            this.btn_SelectInputFiles.Click += new System.EventHandler(this.btn_SelectInputFiles_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(318, 332);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 9;
            this.btn_Download.Text = "Download Files";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(663, 332);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 10;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // FileAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 528);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.tv_InputFiles);
            this.Controls.Add(this.tv_OutputFiles);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.txt_FileLocation);
            this.Controls.Add(this.btn_SelectInputFiles);
            this.Controls.Add(this.btn_LoadFileTable);
            this.Controls.Add(this.btn_SelectOutput);
            this.Controls.Add(this.btn_BrowseAccess);
            this.Controls.Add(this.btn_ConnectDB);
            this.Name = "FileAccessForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ConnectDB;
        private System.Windows.Forms.Button btn_BrowseAccess;
        private System.Windows.Forms.Button btn_SelectOutput;
        private System.Windows.Forms.Button btn_LoadFileTable;
        private System.Windows.Forms.TextBox txt_FileLocation;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TreeView tv_OutputFiles;
        private System.Windows.Forms.TreeView tv_InputFiles;
        private System.Windows.Forms.Button btn_SelectInputFiles;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Upload;
    }
}
