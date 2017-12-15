namespace Treeview
{
    partial class EditTFileForm
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
            this.dgvTFileEF = new System.Windows.Forms.DataGridView();
            this.btnInsertFile = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnUpdFile = new System.Windows.Forms.Button();
            this.btnViewFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbContentEF = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEF = new System.Windows.Forms.DateTimePicker();
            this.cmbTypeEF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatIDEF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSizeEF = new System.Windows.Forms.TextBox();
            this.txtKeyEF = new System.Windows.Forms.TextBox();
            this.txtFilenameEF = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFileEF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTFileEF
            // 
            this.dgvTFileEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTFileEF.Location = new System.Drawing.Point(403, 12);
            this.dgvTFileEF.Name = "dgvTFileEF";
            this.dgvTFileEF.RowTemplate.Height = 24;
            this.dgvTFileEF.Size = new System.Drawing.Size(772, 508);
            this.dgvTFileEF.TabIndex = 5;
            // 
            // btnInsertFile
            // 
            this.btnInsertFile.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_Save_26;
            this.btnInsertFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFile.Location = new System.Drawing.Point(13, 404);
            this.btnInsertFile.Name = "btnInsertFile";
            this.btnInsertFile.Size = new System.Drawing.Size(97, 42);
            this.btnInsertFile.TabIndex = 4;
            this.btnInsertFile.Text = "Insert";
            this.btnInsertFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertFile.UseVisualStyleBackColor = true;
            this.btnInsertFile.Click += new System.EventHandler(this.btnInsertFile_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_Trash_26;
            this.btnDelFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelFile.Location = new System.Drawing.Point(129, 452);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(97, 40);
            this.btnDelFile.TabIndex = 3;
            this.btnDelFile.Text = "Delete";
            this.btnDelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // btnUpdFile
            // 
            this.btnUpdFile.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_Data_Backup_261;
            this.btnUpdFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdFile.Location = new System.Drawing.Point(129, 404);
            this.btnUpdFile.Name = "btnUpdFile";
            this.btnUpdFile.Size = new System.Drawing.Size(97, 42);
            this.btnUpdFile.TabIndex = 2;
            this.btnUpdFile.Text = "Update";
            this.btnUpdFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdFile.UseVisualStyleBackColor = true;
            this.btnUpdFile.Click += new System.EventHandler(this.btnUpdFile_Click);
            // 
            // btnViewFile
            // 
            this.btnViewFile.BackgroundImage = global::WindowsFormsApplication370.Properties.Resources.icons8_Eye_26;
            this.btnViewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFile.Location = new System.Drawing.Point(256, 404);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(97, 42);
            this.btnViewFile.TabIndex = 0;
            this.btnViewFile.Text = "View";
            this.btnViewFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFile.UseVisualStyleBackColor = true;
            this.btnViewFile.Click += new System.EventHandler(this.btnViewFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbContentEF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEF);
            this.groupBox1.Controls.Add(this.cmbTypeEF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCatIDEF);
            this.groupBox1.Controls.Add(this.btnDelFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnInsertFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnViewFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnUpdFile);
            this.groupBox1.Controls.Add(this.txtSizeEF);
            this.groupBox1.Controls.Add(this.txtKeyEF);
            this.groupBox1.Controls.Add(this.txtFilenameEF);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 508);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // rtbContentEF
            // 
            this.rtbContentEF.Location = new System.Drawing.Point(12, 251);
            this.rtbContentEF.Name = "rtbContentEF";
            this.rtbContentEF.Size = new System.Drawing.Size(367, 139);
            this.rtbContentEF.TabIndex = 26;
            this.rtbContentEF.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Содержимое";
            // 
            // dtpEF
            // 
            this.dtpEF.CustomFormat = "dd.MM.yyyy";
            this.dtpEF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEF.Location = new System.Drawing.Point(155, 154);
            this.dtpEF.Name = "dtpEF";
            this.dtpEF.Size = new System.Drawing.Size(128, 22);
            this.dtpEF.TabIndex = 23;
            // 
            // cmbTypeEF
            // 
            this.cmbTypeEF.FormattingEnabled = true;
            this.cmbTypeEF.Items.AddRange(new object[] {
            "doc",
            "docx",
            "txt",
            "rtf"});
            this.cmbTypeEF.Location = new System.Drawing.Point(155, 86);
            this.cmbTypeEF.Name = "cmbTypeEF";
            this.cmbTypeEF.Size = new System.Drawing.Size(89, 24);
            this.cmbTypeEF.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ключевые слова";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название";
            // 
            // txtCatIDEF
            // 
            this.txtCatIDEF.Location = new System.Drawing.Point(86, 193);
            this.txtCatIDEF.Name = "txtCatIDEF";
            this.txtCatIDEF.Size = new System.Drawing.Size(45, 22);
            this.txtCatIDEF.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "CatalogID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Формат";
            // 
            // txtSizeEF
            // 
            this.txtSizeEF.Location = new System.Drawing.Point(155, 116);
            this.txtSizeEF.Name = "txtSizeEF";
            this.txtSizeEF.Size = new System.Drawing.Size(87, 22);
            this.txtSizeEF.TabIndex = 14;
            // 
            // txtKeyEF
            // 
            this.txtKeyEF.Location = new System.Drawing.Point(155, 53);
            this.txtKeyEF.Name = "txtKeyEF";
            this.txtKeyEF.Size = new System.Drawing.Size(224, 22);
            this.txtKeyEF.TabIndex = 19;
            // 
            // txtFilenameEF
            // 
            this.txtFilenameEF.Location = new System.Drawing.Point(86, 21);
            this.txtFilenameEF.Name = "txtFilenameEF";
            this.txtFilenameEF.Size = new System.Drawing.Size(293, 22);
            this.txtFilenameEF.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 17);
            this.label.TabIndex = 15;
            this.label.Text = "Размер, кБ";
            // 
            // EditTFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTFileEF);
            this.Name = "EditTFileForm";
            this.Text = "EditTFileForm";
            this.Load += new System.EventHandler(this.EditTFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFileEF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewFile;
        private System.Windows.Forms.Button btnDelFile;
        private System.Windows.Forms.Button btnUpdFile;
        private System.Windows.Forms.Button btnInsertFile;
        private System.Windows.Forms.DataGridView dgvTFileEF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtKeyEF;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox txtFilenameEF;
        public System.Windows.Forms.TextBox txtSizeEF;
        public System.Windows.Forms.TextBox txtCatIDEF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEF;
        private System.Windows.Forms.ComboBox cmbTypeEF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContentEF;
        private System.Windows.Forms.Label label2;
    }
}