﻿namespace Treeview
{
    partial class MainAP
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
            this.btnEditTFile = new System.Windows.Forms.Button();
            this.btnEditTCatalog = new System.Windows.Forms.Button();
            this.btnEditTKeyword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditTFile
            // 
            this.btnEditTFile.Location = new System.Drawing.Point(48, 47);
            this.btnEditTFile.Name = "btnEditTFile";
            this.btnEditTFile.Size = new System.Drawing.Size(387, 38);
            this.btnEditTFile.TabIndex = 0;
            this.btnEditTFile.Text = "Редактировать таблицу TFile (Файлы)";
            this.btnEditTFile.UseVisualStyleBackColor = true;
            this.btnEditTFile.Click += new System.EventHandler(this.btnEditTFile_Click);
            // 
            // btnEditTCatalog
            // 
            this.btnEditTCatalog.Location = new System.Drawing.Point(48, 110);
            this.btnEditTCatalog.Name = "btnEditTCatalog";
            this.btnEditTCatalog.Size = new System.Drawing.Size(387, 38);
            this.btnEditTCatalog.TabIndex = 1;
            this.btnEditTCatalog.Text = "Редактировать таблицу TCatalog (Каталоги)";
            this.btnEditTCatalog.UseVisualStyleBackColor = true;
            this.btnEditTCatalog.Click += new System.EventHandler(this.btnEditTCatalog_Click);
            // 
            // btnEditTKeyword
            // 
            this.btnEditTKeyword.Location = new System.Drawing.Point(48, 166);
            this.btnEditTKeyword.Name = "btnEditTKeyword";
            this.btnEditTKeyword.Size = new System.Drawing.Size(387, 38);
            this.btnEditTKeyword.TabIndex = 2;
            this.btnEditTKeyword.Text = "Редактировать таблицу TKeyword (Ключевые слова)";
            this.btnEditTKeyword.UseVisualStyleBackColor = true;
            this.btnEditTKeyword.Click += new System.EventHandler(this.btnEditTKeyword_Click);
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 258);
            this.Controls.Add(this.btnEditTKeyword);
            this.Controls.Add(this.btnEditTCatalog);
            this.Controls.Add(this.btnEditTFile);
            this.Name = "MainAP";
            this.Text = "MainAP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditTFile;
        private System.Windows.Forms.Button btnEditTCatalog;
        private System.Windows.Forms.Button btnEditTKeyword;
    }
}