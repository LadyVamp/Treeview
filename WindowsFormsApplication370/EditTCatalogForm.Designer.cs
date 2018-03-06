namespace Treeview
{
    partial class EditTCatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTCatalogForm));
            this.cmbRootId = new System.Windows.Forms.ComboBox();
            this.tRootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TRoot = new WindowsFormsApplication370.RepositoryDB3TRoot();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.cmbAccessId = new System.Windows.Forms.ComboBox();
            this.tTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TTypeForEditTCatalogForm = new WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogForm();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tCatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TCatalogForEditTCatalogForm = new WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogForm();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubCatalogId = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tRootTableAdapter = new WindowsFormsApplication370.RepositoryDB3TRootTableAdapters.TRootTableAdapter();
            this.repositoryDB3DataSetTCatalog = new WindowsFormsApplication370.RepositoryDB3DataSetTCatalog();
            this.repositoryDB3DataSetTCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TCatalog = new WindowsFormsApplication370.RepositoryDB3TCatalog();
            this.repositoryDB3TCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogTableAdapter = new WindowsFormsApplication370.RepositoryDB3TCatalogTableAdapters.TCatalogTableAdapter();
            this.repositoryDB3DataSetTCatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogTableAdapter1 = new WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogFormTableAdapters.TCatalogTableAdapter();
            this.tTypeTableAdapter = new WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogFormTableAdapters.TTypeTableAdapter();
            this.btnClearEF = new System.Windows.Forms.Button();
            this.dgvTCatalogEF = new System.Windows.Forms.DataGridView();
            this.btnInsertCatalog = new System.Windows.Forms.Button();
            this.btnUpdCatalog = new System.Windows.Forms.Button();
            this.btnViewCatalog = new System.Windows.Forms.Button();
            this.btnDelCatalog = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.tRootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TTypeForEditTCatalogForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogForEditTCatalogForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCatalogEF)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRootId
            // 
            this.cmbRootId.DataSource = this.tRootBindingSource;
            this.cmbRootId.DisplayMember = "ID";
            this.cmbRootId.FormattingEnabled = true;
            this.cmbRootId.Location = new System.Drawing.Point(171, 68);
            this.cmbRootId.Name = "cmbRootId";
            this.cmbRootId.Size = new System.Drawing.Size(55, 24);
            this.cmbRootId.TabIndex = 33;
            this.cmbRootId.ValueMember = "ID";
            // 
            // tRootBindingSource
            // 
            this.tRootBindingSource.DataMember = "TRoot";
            this.tRootBindingSource.DataSource = this.repositoryDB3TRoot;
            // 
            // repositoryDB3TRoot
            // 
            this.repositoryDB3TRoot.DataSetName = "RepositoryDB3TRoot";
            this.repositoryDB3TRoot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tRootBindingSource;
            this.comboBox1.DisplayMember = "Root";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "Root";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 28);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(135, 17);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "Название каталога";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(24, 68);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(127, 17);
            this.lbl7.TabIndex = 29;
            this.lbl7.Text = "Корневой каталог";
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(171, 26);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(224, 22);
            this.txtCatalog.TabIndex = 30;
            // 
            // cmbAccessId
            // 
            this.cmbAccessId.DataSource = this.tTypeBindingSource;
            this.cmbAccessId.DisplayMember = "ID";
            this.cmbAccessId.FormattingEnabled = true;
            this.cmbAccessId.Location = new System.Drawing.Point(171, 152);
            this.cmbAccessId.Name = "cmbAccessId";
            this.cmbAccessId.Size = new System.Drawing.Size(55, 24);
            this.cmbAccessId.TabIndex = 36;
            this.cmbAccessId.ValueMember = "ID";
            // 
            // tTypeBindingSource
            // 
            this.tTypeBindingSource.DataMember = "TType";
            this.tTypeBindingSource.DataSource = this.repositoryDB3TTypeForEditTCatalogForm;
            // 
            // repositoryDB3TTypeForEditTCatalogForm
            // 
            this.repositoryDB3TTypeForEditTCatalogForm.DataSetName = "RepositoryDB3TTypeForEditTCatalogForm";
            this.repositoryDB3TTypeForEditTCatalogForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tCatalogBindingSource1;
            this.comboBox3.DisplayMember = "Catalog";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(232, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 24);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.ValueMember = "Catalog";
            // 
            // tCatalogBindingSource1
            // 
            this.tCatalogBindingSource1.DataMember = "TCatalog";
            this.tCatalogBindingSource1.DataSource = this.repositoryDB3TCatalogForEditTCatalogForm;
            // 
            // repositoryDB3TCatalogForEditTCatalogForm
            // 
            this.repositoryDB3TCatalogForEditTCatalogForm.DataSetName = "RepositoryDB3TCatalogForEditTCatalogForm";
            this.repositoryDB3TCatalogForEditTCatalogForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Доступ";
            // 
            // cmbSubCatalogId
            // 
            this.cmbSubCatalogId.DataSource = this.tCatalogBindingSource1;
            this.cmbSubCatalogId.DisplayMember = "ID";
            this.cmbSubCatalogId.FormattingEnabled = true;
            this.cmbSubCatalogId.Location = new System.Drawing.Point(171, 108);
            this.cmbSubCatalogId.Name = "cmbSubCatalogId";
            this.cmbSubCatalogId.Size = new System.Drawing.Size(55, 24);
            this.cmbSubCatalogId.TabIndex = 39;
            this.cmbSubCatalogId.ValueMember = "ID";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.tTypeBindingSource;
            this.comboBox5.DisplayMember = "Type";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(232, 152);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(224, 24);
            this.comboBox5.TabIndex = 38;
            this.comboBox5.ValueMember = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Подкаталог";
            // 
            // tRootTableAdapter
            // 
            this.tRootTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryDB3DataSetTCatalog
            // 
            this.repositoryDB3DataSetTCatalog.DataSetName = "RepositoryDB3DataSetTCatalog";
            this.repositoryDB3DataSetTCatalog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryDB3DataSetTCatalogBindingSource
            // 
            this.repositoryDB3DataSetTCatalogBindingSource.DataSource = this.repositoryDB3DataSetTCatalog;
            this.repositoryDB3DataSetTCatalogBindingSource.Position = 0;
            // 
            // repositoryDB3TCatalog
            // 
            this.repositoryDB3TCatalog.DataSetName = "RepositoryDB3TCatalog";
            this.repositoryDB3TCatalog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryDB3TCatalogBindingSource
            // 
            this.repositoryDB3TCatalogBindingSource.DataSource = this.repositoryDB3TCatalog;
            this.repositoryDB3TCatalogBindingSource.Position = 0;
            // 
            // tCatalogBindingSource
            // 
            this.tCatalogBindingSource.DataMember = "TCatalog";
            this.tCatalogBindingSource.DataSource = this.repositoryDB3TCatalogBindingSource;
            // 
            // tCatalogTableAdapter
            // 
            this.tCatalogTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryDB3DataSetTCatalogBindingSource1
            // 
            this.repositoryDB3DataSetTCatalogBindingSource1.DataSource = this.repositoryDB3DataSetTCatalog;
            this.repositoryDB3DataSetTCatalogBindingSource1.Position = 0;
            // 
            // tCatalogTableAdapter1
            // 
            this.tCatalogTableAdapter1.ClearBeforeFill = true;
            // 
            // tTypeTableAdapter
            // 
            this.tTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnClearEF
            // 
            this.btnClearEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearEF.Image = ((System.Drawing.Image)(resources.GetObject("btnClearEF.Image")));
            this.btnClearEF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEF.Location = new System.Drawing.Point(27, 273);
            this.btnClearEF.Name = "btnClearEF";
            this.btnClearEF.Size = new System.Drawing.Size(160, 35);
            this.btnClearEF.TabIndex = 44;
            this.btnClearEF.Text = "Очистить форму";
            this.btnClearEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearEF.UseVisualStyleBackColor = true;
            this.btnClearEF.Click += new System.EventHandler(this.btnClearEF_Click);
            // 
            // dgvTCatalogEF
            // 
            this.dgvTCatalogEF.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvTCatalogEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTCatalogEF.Location = new System.Drawing.Point(491, 26);
            this.dgvTCatalogEF.Name = "dgvTCatalogEF";
            this.dgvTCatalogEF.RowTemplate.Height = 24;
            this.dgvTCatalogEF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTCatalogEF.Size = new System.Drawing.Size(630, 502);
            this.dgvTCatalogEF.TabIndex = 45;
            // 
            // btnInsertCatalog
            // 
            this.btnInsertCatalog.Image = global::WindowsFormsApplication370.Properties.Resources.insert_plus_26;
            this.btnInsertCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCatalog.Location = new System.Drawing.Point(27, 215);
            this.btnInsertCatalog.Name = "btnInsertCatalog";
            this.btnInsertCatalog.Size = new System.Drawing.Size(98, 42);
            this.btnInsertCatalog.TabIndex = 46;
            this.btnInsertCatalog.Text = "    Insert";
            this.btnInsertCatalog.UseVisualStyleBackColor = true;
            this.btnInsertCatalog.Click += new System.EventHandler(this.btnInsertCatalog_Click);
            // 
            // btnUpdCatalog
            // 
            this.btnUpdCatalog.Image = global::WindowsFormsApplication370.Properties.Resources.update_Data_Backup_26;
            this.btnUpdCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdCatalog.Location = new System.Drawing.Point(171, 215);
            this.btnUpdCatalog.Name = "btnUpdCatalog";
            this.btnUpdCatalog.Size = new System.Drawing.Size(105, 42);
            this.btnUpdCatalog.TabIndex = 47;
            this.btnUpdCatalog.Text = "    Update";
            this.btnUpdCatalog.UseVisualStyleBackColor = true;
            this.btnUpdCatalog.Click += new System.EventHandler(this.btnUpdCatalog_Click);
            // 
            // btnViewCatalog
            // 
            this.btnViewCatalog.Image = global::WindowsFormsApplication370.Properties.Resources.view_Eye_26;
            this.btnViewCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCatalog.Location = new System.Drawing.Point(352, 215);
            this.btnViewCatalog.Name = "btnViewCatalog";
            this.btnViewCatalog.Size = new System.Drawing.Size(101, 42);
            this.btnViewCatalog.TabIndex = 48;
            this.btnViewCatalog.Text = "    View";
            this.btnViewCatalog.UseVisualStyleBackColor = true;
            this.btnViewCatalog.Click += new System.EventHandler(this.btnViewCatalog_Click);
            // 
            // btnDelCatalog
            // 
            this.btnDelCatalog.Image = global::WindowsFormsApplication370.Properties.Resources.delete_Trash_26;
            this.btnDelCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCatalog.Location = new System.Drawing.Point(352, 273);
            this.btnDelCatalog.Name = "btnDelCatalog";
            this.btnDelCatalog.Size = new System.Drawing.Size(101, 40);
            this.btnDelCatalog.TabIndex = 49;
            this.btnDelCatalog.Text = "    Delete";
            this.btnDelCatalog.UseVisualStyleBackColor = true;
            this.btnDelCatalog.Click += new System.EventHandler(this.btnDelCatalog_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 332);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(426, 196);
            this.treeView1.TabIndex = 50;
            // 
            // EditTCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 540);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnDelCatalog);
            this.Controls.Add(this.btnViewCatalog);
            this.Controls.Add(this.btnUpdCatalog);
            this.Controls.Add(this.btnInsertCatalog);
            this.Controls.Add(this.dgvTCatalogEF);
            this.Controls.Add(this.btnClearEF);
            this.Controls.Add(this.cmbSubCatalogId);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAccessId);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRootId);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.txtCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTCatalogForm";
            this.Text = "EditTCatalogForm";
            this.Load += new System.EventHandler(this.EditTCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TTypeForEditTCatalogForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogForEditTCatalogForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCatalogEF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRootId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl7;
        public System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.ComboBox cmbAccessId;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubCatalogId;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApplication370.RepositoryDB3TRoot repositoryDB3TRoot;
        private System.Windows.Forms.BindingSource tRootBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TRootTableAdapters.TRootTableAdapter tRootTableAdapter;
        private System.Windows.Forms.BindingSource repositoryDB3TCatalogBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TCatalog repositoryDB3TCatalog;
        private WindowsFormsApplication370.RepositoryDB3DataSetTCatalog repositoryDB3DataSetTCatalog;
        private System.Windows.Forms.BindingSource repositoryDB3DataSetTCatalogBindingSource;
        private System.Windows.Forms.BindingSource tCatalogBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TCatalogTableAdapters.TCatalogTableAdapter tCatalogTableAdapter;
        private System.Windows.Forms.BindingSource repositoryDB3DataSetTCatalogBindingSource1;
        private WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogForm repositoryDB3TCatalogForEditTCatalogForm;
        private System.Windows.Forms.BindingSource tCatalogBindingSource1;
        private WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogFormTableAdapters.TCatalogTableAdapter tCatalogTableAdapter1;
        private WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogForm repositoryDB3TTypeForEditTCatalogForm;
        private System.Windows.Forms.BindingSource tTypeBindingSource;
        private WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogFormTableAdapters.TTypeTableAdapter tTypeTableAdapter;
        private System.Windows.Forms.Button btnClearEF;
        private System.Windows.Forms.DataGridView dgvTCatalogEF;
        private System.Windows.Forms.Button btnInsertCatalog;
        private System.Windows.Forms.Button btnUpdCatalog;
        private System.Windows.Forms.Button btnViewCatalog;
        private System.Windows.Forms.Button btnDelCatalog;
        private System.Windows.Forms.TreeView treeView1;
    }
}