namespace Treeview
{
    partial class EditTKeywordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTKeywordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cmbParentKeyId = new System.Windows.Forms.ComboBox();
            this.tKeywordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TKeywordForEditTKeywordForm = new WindowsFormsApplication370.RepositoryDB3TKeywordForEditTKeywordForm();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertKeyword = new System.Windows.Forms.Button();
            this.btnUpdKeyword = new System.Windows.Forms.Button();
            this.btnViewKeyword = new System.Windows.Forms.Button();
            this.btnDelKeyword = new System.Windows.Forms.Button();
            this.btnClearEF = new System.Windows.Forms.Button();
            this.dgvTKeywordEF = new System.Windows.Forms.DataGridView();
            this.tKeywordTableAdapter = new WindowsFormsApplication370.RepositoryDB3TKeywordForEditTKeywordFormTableAdapters.TKeywordTableAdapter();
            this.repositoryDB3TFile = new WindowsFormsApplication370.RepositoryDB3TFile();
            this.repositoryDB3TFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFileTableAdapter = new WindowsFormsApplication370.RepositoryDB3TFileTableAdapters.TFileTableAdapter();
            this.repositoryDB3DataSetTFile = new WindowsFormsApplication370.RepositoryDB3DataSetTFile();
            this.repositoryDB3DataSetTFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbFileId = new System.Windows.Forms.ComboBox();
            this.tFileBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tKeywordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TKeywordForEditTKeywordForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKeywordEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключевое слово";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(151, 34);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(275, 22);
            this.txtKeyword.TabIndex = 1;
            // 
            // cmbParentKeyId
            // 
            this.cmbParentKeyId.DataSource = this.tKeywordBindingSource;
            this.cmbParentKeyId.DisplayMember = "ParentKeyId";
            this.cmbParentKeyId.FormattingEnabled = true;
            this.cmbParentKeyId.Location = new System.Drawing.Point(151, 79);
            this.cmbParentKeyId.Name = "cmbParentKeyId";
            this.cmbParentKeyId.Size = new System.Drawing.Size(64, 24);
            this.cmbParentKeyId.TabIndex = 2;
            this.cmbParentKeyId.ValueMember = "ParentKeyId";
            // 
            // tKeywordBindingSource
            // 
            this.tKeywordBindingSource.DataMember = "TKeyword";
            this.tKeywordBindingSource.DataSource = this.repositoryDB3TKeywordForEditTKeywordForm;
            // 
            // repositoryDB3TKeywordForEditTKeywordForm
            // 
            this.repositoryDB3TKeywordForEditTKeywordForm.DataSetName = "RepositoryDB3TKeywordForEditTKeywordForm";
            this.repositoryDB3TKeywordForEditTKeywordForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ParentKeyId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "FileId";
            // 
            // btnInsertKeyword
            // 
            this.btnInsertKeyword.Image = global::WindowsFormsApplication370.Properties.Resources.insert_plus_26;
            this.btnInsertKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertKeyword.Location = new System.Drawing.Point(32, 190);
            this.btnInsertKeyword.Name = "btnInsertKeyword";
            this.btnInsertKeyword.Size = new System.Drawing.Size(98, 42);
            this.btnInsertKeyword.TabIndex = 6;
            this.btnInsertKeyword.Text = "   Insert";
            this.btnInsertKeyword.UseVisualStyleBackColor = true;
            this.btnInsertKeyword.Click += new System.EventHandler(this.btnInsertKeyword_Click);
            // 
            // btnUpdKeyword
            // 
            this.btnUpdKeyword.Image = global::WindowsFormsApplication370.Properties.Resources.update_Data_Backup_26;
            this.btnUpdKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdKeyword.Location = new System.Drawing.Point(151, 190);
            this.btnUpdKeyword.Name = "btnUpdKeyword";
            this.btnUpdKeyword.Size = new System.Drawing.Size(98, 42);
            this.btnUpdKeyword.TabIndex = 7;
            this.btnUpdKeyword.Text = "   Update";
            this.btnUpdKeyword.UseVisualStyleBackColor = true;
            this.btnUpdKeyword.Click += new System.EventHandler(this.btnUpdKeyword_Click);
            // 
            // btnViewKeyword
            // 
            this.btnViewKeyword.Image = global::WindowsFormsApplication370.Properties.Resources.view_Eye_26;
            this.btnViewKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewKeyword.Location = new System.Drawing.Point(328, 190);
            this.btnViewKeyword.Name = "btnViewKeyword";
            this.btnViewKeyword.Size = new System.Drawing.Size(98, 42);
            this.btnViewKeyword.TabIndex = 8;
            this.btnViewKeyword.Text = "   View";
            this.btnViewKeyword.UseVisualStyleBackColor = true;
            this.btnViewKeyword.Click += new System.EventHandler(this.btnViewKeyword_Click);
            // 
            // btnDelKeyword
            // 
            this.btnDelKeyword.Image = global::WindowsFormsApplication370.Properties.Resources.delete_Trash_26;
            this.btnDelKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelKeyword.Location = new System.Drawing.Point(328, 270);
            this.btnDelKeyword.Name = "btnDelKeyword";
            this.btnDelKeyword.Size = new System.Drawing.Size(98, 42);
            this.btnDelKeyword.TabIndex = 9;
            this.btnDelKeyword.Text = "   Delete";
            this.btnDelKeyword.UseVisualStyleBackColor = true;
            this.btnDelKeyword.Click += new System.EventHandler(this.btnDelKeyword_Click);
            // 
            // btnClearEF
            // 
            this.btnClearEF.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_broom_26;
            this.btnClearEF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEF.Location = new System.Drawing.Point(32, 285);
            this.btnClearEF.Name = "btnClearEF";
            this.btnClearEF.Size = new System.Drawing.Size(183, 27);
            this.btnClearEF.TabIndex = 10;
            this.btnClearEF.Text = "Очистить форму";
            this.btnClearEF.UseVisualStyleBackColor = true;
            this.btnClearEF.Click += new System.EventHandler(this.btnClearEF_Click);
            // 
            // dgvTKeywordEF
            // 
            this.dgvTKeywordEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKeywordEF.Location = new System.Drawing.Point(450, 34);
            this.dgvTKeywordEF.Name = "dgvTKeywordEF";
            this.dgvTKeywordEF.RowTemplate.Height = 24;
            this.dgvTKeywordEF.Size = new System.Drawing.Size(525, 278);
            this.dgvTKeywordEF.TabIndex = 11;
            // 
            // tKeywordTableAdapter
            // 
            this.tKeywordTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryDB3TFile
            // 
            this.repositoryDB3TFile.DataSetName = "RepositoryDB3TFile";
            this.repositoryDB3TFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryDB3TFileBindingSource
            // 
            this.repositoryDB3TFileBindingSource.DataSource = this.repositoryDB3TFile;
            this.repositoryDB3TFileBindingSource.Position = 0;
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataMember = "TFile";
            this.tFileBindingSource.DataSource = this.repositoryDB3TFileBindingSource;
            // 
            // tFileTableAdapter
            // 
            this.tFileTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryDB3DataSetTFile
            // 
            this.repositoryDB3DataSetTFile.DataSetName = "repositoryDB3DataSetTFile";
            this.repositoryDB3DataSetTFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryDB3DataSetTFileBindingSource
            // 
            this.repositoryDB3DataSetTFileBindingSource.DataSource = this.repositoryDB3DataSetTFile;
            this.repositoryDB3DataSetTFileBindingSource.Position = 0;
            // 
            // tFileBindingSource1
            // 
            this.tFileBindingSource1.DataMember = "TFile";
            this.tFileBindingSource1.DataSource = this.repositoryDB3DataSetTFileBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tKeywordBindingSource;
            this.comboBox1.DisplayMember = "Keyword";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Keyword";
            // 
            // cmbFileId
            // 
            this.cmbFileId.DataSource = this.tKeywordBindingSource;
            this.cmbFileId.DisplayMember = "FileId";
            this.cmbFileId.FormattingEnabled = true;
            this.cmbFileId.Location = new System.Drawing.Point(151, 121);
            this.cmbFileId.Name = "cmbFileId";
            this.cmbFileId.Size = new System.Drawing.Size(64, 24);
            this.cmbFileId.TabIndex = 14;
            this.cmbFileId.ValueMember = "FileId";
            // 
            // tFileBindingSource2
            // 
            this.tFileBindingSource2.DataMember = "TFile";
            this.tFileBindingSource2.DataSource = this.repositoryDB3DataSetTFile;
            // 
            // EditTKeywordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 327);
            this.Controls.Add(this.cmbFileId);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvTKeywordEF);
            this.Controls.Add(this.btnClearEF);
            this.Controls.Add(this.btnDelKeyword);
            this.Controls.Add(this.btnViewKeyword);
            this.Controls.Add(this.btnUpdKeyword);
            this.Controls.Add(this.btnInsertKeyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbParentKeyId);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTKeywordForm";
            this.Text = "EditTKeywordForm";
            this.Load += new System.EventHandler(this.EditTKeywordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tKeywordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TKeywordForEditTKeywordForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKeywordEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cmbParentKeyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertKeyword;
        private System.Windows.Forms.Button btnUpdKeyword;
        private System.Windows.Forms.Button btnViewKeyword;
        private System.Windows.Forms.Button btnDelKeyword;
        private System.Windows.Forms.Button btnClearEF;
        private System.Windows.Forms.DataGridView dgvTKeywordEF;
        private WindowsFormsApplication370.RepositoryDB3TKeywordForEditTKeywordForm repositoryDB3TKeywordForEditTKeywordForm;
        private System.Windows.Forms.BindingSource tKeywordBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TKeywordForEditTKeywordFormTableAdapters.TKeywordTableAdapter tKeywordTableAdapter;
        private System.Windows.Forms.BindingSource repositoryDB3TFileBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TFile repositoryDB3TFile;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TFileTableAdapters.TFileTableAdapter tFileTableAdapter;
        private System.Windows.Forms.BindingSource tFileBindingSource1;
        private System.Windows.Forms.BindingSource repositoryDB3DataSetTFileBindingSource;
        private WindowsFormsApplication370.RepositoryDB3DataSetTFile repositoryDB3DataSetTFile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbFileId;
        private System.Windows.Forms.BindingSource tFileBindingSource2;
    }
}