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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTFileForm));
            this.dgvTFileEF = new System.Windows.Forms.DataGridView();
            this.btnInsertFile = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnUpdFile = new System.Windows.Forms.Button();
            this.btnViewFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearEF = new System.Windows.Forms.Button();
            this.lbl10 = new System.Windows.Forms.Label();
            this.txtAuthorEF = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.rtbAnnotationEF = new System.Windows.Forms.RichTextBox();
            this.dtpDateChangeEF = new System.Windows.Forms.DateTimePicker();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtSizeEF = new System.Windows.Forms.TextBox();
            this.cmbTypeEF = new System.Windows.Forms.ComboBox();
            this.cmbCatIDEF = new System.Windows.Forms.ComboBox();
            this.tCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3DataSetTCatalog = new WindowsFormsApplication370.RepositoryDB3DataSetTCatalog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rtbContentEF = new System.Windows.Forms.RichTextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.dtpDateCreateEF = new System.Windows.Forms.DateTimePicker();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtKeyEF = new System.Windows.Forms.TextBox();
            this.txtTitleEF = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tCatalogTableAdapter = new WindowsFormsApplication370.RepositoryDB3DataSetTCatalogTableAdapters.TCatalogTableAdapter();
            this.fKTCatalogTCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3DataSetTFile = new WindowsFormsApplication370.RepositoryDB3DataSetTFile();
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFileEF)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTCatalogTCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTFileEF
            // 
            this.dgvTFileEF.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvTFileEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTFileEF.Location = new System.Drawing.Point(492, 12);
            this.dgvTFileEF.Name = "dgvTFileEF";
            this.dgvTFileEF.RowTemplate.Height = 24;
            this.dgvTFileEF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTFileEF.Size = new System.Drawing.Size(853, 655);
            this.dgvTFileEF.TabIndex = 5;
            this.dgvTFileEF.CurrentCellChanged += new System.EventHandler(this.dgvTFileEF_CurrentCellChanged);
            // 
            // btnInsertFile
            // 
            this.btnInsertFile.Image = global::WindowsFormsApplication370.Properties.Resources.insert_plus_26;
            this.btnInsertFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFile.Location = new System.Drawing.Point(9, 551);
            this.btnInsertFile.Name = "btnInsertFile";
            this.btnInsertFile.Size = new System.Drawing.Size(92, 42);
            this.btnInsertFile.TabIndex = 4;
            this.btnInsertFile.Text = "Insert";
            this.btnInsertFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertFile.UseVisualStyleBackColor = true;
            this.btnInsertFile.Click += new System.EventHandler(this.btnInsertFile_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Image = global::WindowsFormsApplication370.Properties.Resources.delete_Trash_26;
            this.btnDelFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelFile.Location = new System.Drawing.Point(375, 609);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(93, 40);
            this.btnDelFile.TabIndex = 3;
            this.btnDelFile.Text = "Delete";
            this.btnDelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // btnUpdFile
            // 
            this.btnUpdFile.Image = global::WindowsFormsApplication370.Properties.Resources.update_Data_Backup_26;
            this.btnUpdFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdFile.Location = new System.Drawing.Point(155, 551);
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
            this.btnViewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewFile.Image = global::WindowsFormsApplication370.Properties.Resources.view_Eye_26;
            this.btnViewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFile.Location = new System.Drawing.Point(375, 551);
            this.btnViewFile.Name = "btnViewFile";
            this.btnViewFile.Size = new System.Drawing.Size(93, 42);
            this.btnViewFile.TabIndex = 0;
            this.btnViewFile.Text = "View";
            this.btnViewFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFile.UseVisualStyleBackColor = true;
            this.btnViewFile.Click += new System.EventHandler(this.btnViewFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearEF);
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.txtAuthorEF);
            this.groupBox1.Controls.Add(this.lbl9);
            this.groupBox1.Controls.Add(this.rtbAnnotationEF);
            this.groupBox1.Controls.Add(this.dtpDateChangeEF);
            this.groupBox1.Controls.Add(this.lbl6);
            this.groupBox1.Controls.Add(this.txtSizeEF);
            this.groupBox1.Controls.Add(this.cmbTypeEF);
            this.groupBox1.Controls.Add(this.cmbCatIDEF);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rtbContentEF);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.dtpDateCreateEF);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.btnDelFile);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.btnInsertFile);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.btnViewFile);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.btnUpdFile);
            this.groupBox1.Controls.Add(this.txtKeyEF);
            this.groupBox1.Controls.Add(this.txtTitleEF);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 655);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnClearEF
            // 
            this.btnClearEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearEF.Image = ((System.Drawing.Image)(resources.GetObject("btnClearEF.Image")));
            this.btnClearEF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEF.Location = new System.Drawing.Point(11, 609);
            this.btnClearEF.Name = "btnClearEF";
            this.btnClearEF.Size = new System.Drawing.Size(160, 35);
            this.btnClearEF.TabIndex = 37;
            this.btnClearEF.Text = "Очистить форму";
            this.btnClearEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearEF.UseVisualStyleBackColor = true;
            this.btnClearEF.Click += new System.EventHandler(this.btnClearEF_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(8, 259);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(47, 17);
            this.lbl10.TabIndex = 36;
            this.lbl10.Text = "Автор";
            // 
            // txtAuthorEF
            // 
            this.txtAuthorEF.Location = new System.Drawing.Point(155, 259);
            this.txtAuthorEF.Name = "txtAuthorEF";
            this.txtAuthorEF.Size = new System.Drawing.Size(225, 22);
            this.txtAuthorEF.TabIndex = 35;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(6, 300);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(80, 17);
            this.lbl9.TabIndex = 34;
            this.lbl9.Text = "Аннотация";
            // 
            // rtbAnnotationEF
            // 
            this.rtbAnnotationEF.Location = new System.Drawing.Point(9, 320);
            this.rtbAnnotationEF.Name = "rtbAnnotationEF";
            this.rtbAnnotationEF.Size = new System.Drawing.Size(455, 62);
            this.rtbAnnotationEF.TabIndex = 33;
            this.rtbAnnotationEF.Text = "";
            // 
            // dtpDateChangeEF
            // 
            this.dtpDateChangeEF.CustomFormat = "dd.MM.yyyy";
            this.dtpDateChangeEF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateChangeEF.Location = new System.Drawing.Point(155, 182);
            this.dtpDateChangeEF.Name = "dtpDateChangeEF";
            this.dtpDateChangeEF.Size = new System.Drawing.Size(128, 22);
            this.dtpDateChangeEF.TabIndex = 32;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(8, 187);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(118, 17);
            this.lbl6.TabIndex = 31;
            this.lbl6.Text = "Дата изменения";
            // 
            // txtSizeEF
            // 
            this.txtSizeEF.Location = new System.Drawing.Point(155, 119);
            this.txtSizeEF.Name = "txtSizeEF";
            this.txtSizeEF.Size = new System.Drawing.Size(100, 22);
            this.txtSizeEF.TabIndex = 30;
            this.txtSizeEF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSizeEF_KeyPress);
            // 
            // cmbTypeEF
            // 
            this.cmbTypeEF.FormattingEnabled = true;
            this.cmbTypeEF.Items.AddRange(new object[] {
            "doc",
            "docx",
            "txt",
            "rtf"});
            this.cmbTypeEF.Location = new System.Drawing.Point(155, 83);
            this.cmbTypeEF.Name = "cmbTypeEF";
            this.cmbTypeEF.Size = new System.Drawing.Size(55, 24);
            this.cmbTypeEF.TabIndex = 29;
            // 
            // cmbCatIDEF
            // 
            this.cmbCatIDEF.DataSource = this.tCatalogBindingSource;
            this.cmbCatIDEF.DisplayMember = "ID";
            this.cmbCatIDEF.FormattingEnabled = true;
            this.cmbCatIDEF.Location = new System.Drawing.Point(94, 226);
            this.cmbCatIDEF.Name = "cmbCatIDEF";
            this.cmbCatIDEF.Size = new System.Drawing.Size(55, 24);
            this.cmbCatIDEF.TabIndex = 28;
            this.cmbCatIDEF.ValueMember = "ID";
            // 
            // tCatalogBindingSource
            // 
            this.tCatalogBindingSource.DataMember = "TCatalog";
            this.tCatalogBindingSource.DataSource = this.repositoryDB3DataSetTCatalog;
            // 
            // repositoryDB3DataSetTCatalog
            // 
            this.repositoryDB3DataSetTCatalog.DataSetName = "RepositoryDB3DataSetTCatalog";
            this.repositoryDB3DataSetTCatalog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tCatalogBindingSource;
            this.comboBox1.DisplayMember = "Catalog";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "Catalog";
            // 
            // rtbContentEF
            // 
            this.rtbContentEF.Location = new System.Drawing.Point(9, 405);
            this.rtbContentEF.Name = "rtbContentEF";
            this.rtbContentEF.Size = new System.Drawing.Size(456, 140);
            this.rtbContentEF.TabIndex = 26;
            this.rtbContentEF.Text = "";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(8, 385);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(91, 17);
            this.lbl8.TabIndex = 25;
            this.lbl8.Text = "Содержимое";
            // 
            // dtpDateCreateEF
            // 
            this.dtpDateCreateEF.CustomFormat = "dd.MM.yyyy";
            this.dtpDateCreateEF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreateEF.Location = new System.Drawing.Point(155, 154);
            this.dtpDateCreateEF.Name = "dtpDateCreateEF";
            this.dtpDateCreateEF.Size = new System.Drawing.Size(128, 22);
            this.dtpDateCreateEF.TabIndex = 23;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 17);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "Ключевые слова";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 17);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Название";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(8, 159);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(108, 17);
            this.lbl5.TabIndex = 17;
            this.lbl5.Text = "Дата создания";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(8, 229);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(69, 17);
            this.lbl7.TabIndex = 16;
            this.lbl7.Text = "CatalogID";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 86);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(61, 17);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Формат";
            // 
            // txtKeyEF
            // 
            this.txtKeyEF.Location = new System.Drawing.Point(155, 53);
            this.txtKeyEF.Name = "txtKeyEF";
            this.txtKeyEF.Size = new System.Drawing.Size(224, 22);
            this.txtKeyEF.TabIndex = 19;
            // 
            // txtTitleEF
            // 
            this.txtTitleEF.Location = new System.Drawing.Point(86, 21);
            this.txtTitleEF.Name = "txtTitleEF";
            this.txtTitleEF.Size = new System.Drawing.Size(293, 22);
            this.txtTitleEF.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(8, 124);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(81, 17);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Размер, кБ";
            // 
            // tCatalogTableAdapter
            // 
            this.tCatalogTableAdapter.ClearBeforeFill = true;
            // 
            // fKTCatalogTCatalogBindingSource
            // 
            this.fKTCatalogTCatalogBindingSource.DataMember = "FK_TCatalog_TCatalog";
            this.fKTCatalogTCatalogBindingSource.DataSource = this.tCatalogBindingSource;
            // 
            // repositoryDB3DataSetTFile
            // 
            this.repositoryDB3DataSetTFile.DataSetName = "RepositoryDB3DataSetTFile";
            this.repositoryDB3DataSetTFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataMember = "TFile";
            this.tFileBindingSource.DataSource = this.repositoryDB3DataSetTFile;
            // 
            // EditTFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1357, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTFileEF);
            this.Name = "EditTFileForm";
            this.Text = "EditTFileForm";
            this.Load += new System.EventHandler(this.EditTFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFileEF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTCatalogTCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewFile;
        private System.Windows.Forms.Button btnDelFile;
        private System.Windows.Forms.Button btnUpdFile;
        private System.Windows.Forms.Button btnInsertFile;
        private System.Windows.Forms.DataGridView dgvTFileEF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.TextBox txtKeyEF;
        private System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.TextBox txtTitleEF;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.DateTimePicker dtpDateCreateEF;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RichTextBox rtbContentEF;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.ComboBox comboBox1;
        private WindowsFormsApplication370.RepositoryDB3DataSetTCatalog repositoryDB3DataSetTCatalog;
        private System.Windows.Forms.BindingSource tCatalogBindingSource;
        private WindowsFormsApplication370.RepositoryDB3DataSetTCatalogTableAdapters.TCatalogTableAdapter tCatalogTableAdapter;
        private System.Windows.Forms.BindingSource fKTCatalogTCatalogBindingSource;
        private System.Windows.Forms.ComboBox cmbCatIDEF;
        private WindowsFormsApplication370.RepositoryDB3DataSetTFile repositoryDB3DataSetTFile;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        //private WindowsFormsApplication370.RepositoryDB3DataSetTFileTableAdapters.TFileTableAdapter tFileTableAdapter;
        private System.Windows.Forms.ComboBox cmbTypeEF;
        private System.Windows.Forms.BindingSource tTypeBindingSource;
        private System.Windows.Forms.TextBox txtSizeEF;
        private System.Windows.Forms.DateTimePicker dtpDateChangeEF;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl10;
        public System.Windows.Forms.TextBox txtAuthorEF;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.RichTextBox rtbAnnotationEF;
        private System.Windows.Forms.Button btnClearEF;
    }
}