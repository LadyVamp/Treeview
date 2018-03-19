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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAP));
            this.btnEditTFile = new System.Windows.Forms.Button();
            this.btnEditTCatalog = new System.Windows.Forms.Button();
            this.btnEditTKeyword = new System.Windows.Forms.Button();
            this.btnEditTRole = new System.Windows.Forms.Button();
            this.btnEditTType = new System.Windows.Forms.Button();
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
            // btnEditTRole
            // 
            this.btnEditTRole.Location = new System.Drawing.Point(48, 223);
            this.btnEditTRole.Name = "btnEditTRole";
            this.btnEditTRole.Size = new System.Drawing.Size(387, 38);
            this.btnEditTRole.TabIndex = 3;
            this.btnEditTRole.Text = "Редактировать таблицу TRole (Роли)";
            this.btnEditTRole.UseVisualStyleBackColor = true;
            this.btnEditTRole.Click += new System.EventHandler(this.btnEditTRole_Click);
            // 
            // btnEditTType
            // 
            this.btnEditTType.Location = new System.Drawing.Point(48, 278);
            this.btnEditTType.Name = "btnEditTType";
            this.btnEditTType.Size = new System.Drawing.Size(387, 38);
            this.btnEditTType.TabIndex = 4;
            this.btnEditTType.Text = "Редактировать таблицу TType (Права доступа)";
            this.btnEditTType.UseVisualStyleBackColor = true;
            this.btnEditTType.Click += new System.EventHandler(this.btnEditTType_Click);
            // 
            // MainAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 363);
            this.Controls.Add(this.btnEditTType);
            this.Controls.Add(this.btnEditTRole);
            this.Controls.Add(this.btnEditTKeyword);
            this.Controls.Add(this.btnEditTCatalog);
            this.Controls.Add(this.btnEditTFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAP";
            this.Text = "MainAP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditTFile;
        private System.Windows.Forms.Button btnEditTCatalog;
        private System.Windows.Forms.Button btnEditTKeyword;
        private System.Windows.Forms.Button btnEditTRole;
        private System.Windows.Forms.Button btnEditTType;
    }
}