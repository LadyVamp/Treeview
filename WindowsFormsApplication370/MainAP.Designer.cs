namespace Treeview
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
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 258);
            this.Controls.Add(this.btnEditTFile);
            this.Name = "MainAP";
            this.Text = "MainAP";
            this.Load += new System.EventHandler(this.MainAP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditTFile;
    }
}