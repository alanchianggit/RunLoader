﻿namespace RunLoader
{
    partial class Analysis_Management
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
            this.cmb_RunNum = new System.Windows.Forms.ComboBox();
            this.txt_Directory = new System.Windows.Forms.TextBox();
            this.Label_Directory = new System.Windows.Forms.Label();
            this.label_RunNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_RunNum
            // 
            this.cmb_RunNum.FormattingEnabled = true;
            this.cmb_RunNum.Location = new System.Drawing.Point(12, 97);
            this.cmb_RunNum.Name = "cmb_RunNum";
            this.cmb_RunNum.Size = new System.Drawing.Size(276, 21);
            this.cmb_RunNum.TabIndex = 0;
            // 
            // txt_Directory
            // 
            this.txt_Directory.Location = new System.Drawing.Point(12, 47);
            this.txt_Directory.Name = "txt_Directory";
            this.txt_Directory.Size = new System.Drawing.Size(276, 20);
            this.txt_Directory.TabIndex = 1;
            this.txt_Directory.Text = "C:\\Agilent\\ICPMH\\1\\Sequence\\";
            // 
            // Label_Directory
            // 
            this.Label_Directory.AutoSize = true;
            this.Label_Directory.Location = new System.Drawing.Point(12, 9);
            this.Label_Directory.Name = "Label_Directory";
            this.Label_Directory.Size = new System.Drawing.Size(52, 13);
            this.Label_Directory.TabIndex = 2;
            this.Label_Directory.Text = "Directory:";
            // 
            // label_RunNumber
            // 
            this.label_RunNumber.AutoSize = true;
            this.label_RunNumber.Location = new System.Drawing.Point(12, 81);
            this.label_RunNumber.Name = "label_RunNumber";
            this.label_RunNumber.Size = new System.Drawing.Size(70, 13);
            this.label_RunNumber.TabIndex = 2;
            this.label_RunNumber.Text = "Run Number:";
            // 
            // Analysis_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 240);
            this.Controls.Add(this.label_RunNumber);
            this.Controls.Add(this.Label_Directory);
            this.Controls.Add(this.txt_Directory);
            this.Controls.Add(this.cmb_RunNum);
            this.Name = "Analysis_Management";
            this.Text = "Analysis_Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_RunNum;
        private System.Windows.Forms.TextBox txt_Directory;
        private System.Windows.Forms.Label Label_Directory;
        private System.Windows.Forms.Label label_RunNumber;
    }
}