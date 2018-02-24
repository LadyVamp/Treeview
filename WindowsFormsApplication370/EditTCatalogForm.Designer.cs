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
            this.cmbCatIDEF = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtCatalogName = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repositoryDB3TRoot = new WindowsFormsApplication370.RepositoryDB3TRoot();
            this.tRootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRootTableAdapter = new WindowsFormsApplication370.RepositoryDB3TRootTableAdapters.TRootTableAdapter();
            this.repositoryDB3DataSetTCatalog = new WindowsFormsApplication370.RepositoryDB3DataSetTCatalog();
            this.repositoryDB3DataSetTCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TCatalog = new WindowsFormsApplication370.RepositoryDB3TCatalog();
            this.repositoryDB3TCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogTableAdapter = new WindowsFormsApplication370.RepositoryDB3TCatalogTableAdapters.TCatalogTableAdapter();
            this.repositoryDB3DataSetTCatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TCatalogForEditTCatalogForm = new WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogForm();
            this.tCatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tCatalogTableAdapter1 = new WindowsFormsApplication370.RepositoryDB3TCatalogForEditTCatalogFormTableAdapters.TCatalogTableAdapter();
            this.repositoryDB3TTypeForEditTCatalogForm = new WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogForm();
            this.tTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTypeTableAdapter = new WindowsFormsApplication370.RepositoryDB3TTypeForEditTCatalogFormTableAdapters.TTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogForEditTCatalogForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TTypeForEditTCatalogForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCatIDEF
            // 
            this.cmbCatIDEF.DataSource = this.tRootBindingSource;
            this.cmbCatIDEF.DisplayMember = "ID";
            this.cmbCatIDEF.FormattingEnabled = true;
            this.cmbCatIDEF.Location = new System.Drawing.Point(174, 95);
            this.cmbCatIDEF.Name = "cmbCatIDEF";
            this.cmbCatIDEF.Size = new System.Drawing.Size(55, 24);
            this.cmbCatIDEF.TabIndex = 33;
            this.cmbCatIDEF.ValueMember = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tRootBindingSource;
            this.comboBox1.DisplayMember = "Root";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "Root";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(25, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(135, 17);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "Название каталога";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(27, 95);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(127, 17);
            this.lbl7.TabIndex = 29;
            this.lbl7.Text = "Корневой каталог";
            // 
            // txtCatalogName
            // 
            this.txtCatalogName.Location = new System.Drawing.Point(174, 53);
            this.txtCatalogName.Name = "txtCatalogName";
            this.txtCatalogName.Size = new System.Drawing.Size(224, 22);
            this.txtCatalogName.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tTypeBindingSource;
            this.comboBox2.DisplayMember = "ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 24);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "ID";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tCatalogBindingSource1;
            this.comboBox3.DisplayMember = "Catalog";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(235, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(224, 24);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.ValueMember = "Catalog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Доступ";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.tCatalogBindingSource1;
            this.comboBox4.DisplayMember = "SubCatalogId";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(174, 135);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(55, 24);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.ValueMember = "SubCatalogId";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.tTypeBindingSource;
            this.comboBox5.DisplayMember = "Type";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(235, 179);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(224, 24);
            this.comboBox5.TabIndex = 38;
            this.comboBox5.ValueMember = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Подкаталог";
            // 
            // repositoryDB3TRoot
            // 
            this.repositoryDB3TRoot.DataSetName = "RepositoryDB3TRoot";
            this.repositoryDB3TRoot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRootBindingSource
            // 
            this.tRootBindingSource.DataMember = "TRoot";
            this.tRootBindingSource.DataSource = this.repositoryDB3TRoot;
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
            // repositoryDB3TCatalogForEditTCatalogForm
            // 
            this.repositoryDB3TCatalogForEditTCatalogForm.DataSetName = "RepositoryDB3TCatalogForEditTCatalogForm";
            this.repositoryDB3TCatalogForEditTCatalogForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCatalogBindingSource1
            // 
            this.tCatalogBindingSource1.DataMember = "TCatalog";
            this.tCatalogBindingSource1.DataSource = this.repositoryDB3TCatalogForEditTCatalogForm;
            // 
            // tCatalogTableAdapter1
            // 
            this.tCatalogTableAdapter1.ClearBeforeFill = true;
            // 
            // repositoryDB3TTypeForEditTCatalogForm
            // 
            this.repositoryDB3TTypeForEditTCatalogForm.DataSetName = "RepositoryDB3TTypeForEditTCatalogForm";
            this.repositoryDB3TTypeForEditTCatalogForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTypeBindingSource
            // 
            this.tTypeBindingSource.DataMember = "TType";
            this.tTypeBindingSource.DataSource = this.repositoryDB3TTypeForEditTCatalogForm;
            // 
            // tTypeTableAdapter
            // 
            this.tTypeTableAdapter.ClearBeforeFill = true;
            // 
            // EditTCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 366);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCatIDEF);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.txtCatalogName);
            this.Name = "EditTCatalogForm";
            this.Text = "EditTCatalogForm";
            this.Load += new System.EventHandler(this.EditTCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3DataSetTCatalogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TCatalogForEditTCatalogForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCatalogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TTypeForEditTCatalogForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCatIDEF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl7;
        public System.Windows.Forms.TextBox txtCatalogName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
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
    }
}