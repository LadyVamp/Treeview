﻿namespace Treeview
{
    partial class SearchForm
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
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB2TFileWithoutId = new WindowsFormsApplication370.RepositoryDB2TFileWithoutId();
            this.tFileTableAdapter = new WindowsFormsApplication370.RepositoryDB2TFileWithoutIdTableAdapters.TFileTableAdapter();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCatalogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.rbDocx = new System.Windows.Forms.RadioButton();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.rbRtf = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB2TFileWithoutId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tFileBindingSource
            // 
            this.tFileBindingSource.DataMember = "TFile";
            this.tFileBindingSource.DataSource = this.repositoryDB2TFileWithoutId;
            // 
            // repositoryDB2TFileWithoutId
            // 
            this.repositoryDB2TFileWithoutId.DataSetName = "RepositoryDB2TFileWithoutId";
            this.repositoryDB2TFileWithoutId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tFileTableAdapter
            // 
            this.tFileTableAdapter.ClearBeforeFill = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(331, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск по ключевым словам";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.fileContentDataGridViewTextBoxColumn,
            this.subCatalogIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tFileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 262);
            this.dataGridView1.TabIndex = 4;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            // 
            // fileContentDataGridViewTextBoxColumn
            // 
            this.fileContentDataGridViewTextBoxColumn.DataPropertyName = "FileContent";
            this.fileContentDataGridViewTextBoxColumn.HeaderText = "FileContent";
            this.fileContentDataGridViewTextBoxColumn.Name = "fileContentDataGridViewTextBoxColumn";
            // 
            // subCatalogIdDataGridViewTextBoxColumn
            // 
            this.subCatalogIdDataGridViewTextBoxColumn.DataPropertyName = "SubCatalogId";
            this.subCatalogIdDataGridViewTextBoxColumn.HeaderText = "SubCatalogId";
            this.subCatalogIdDataGridViewTextBoxColumn.Name = "subCatalogIdDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRtf);
            this.groupBox1.Controls.Add(this.rbTxt);
            this.groupBox1.Controls.Add(this.rbDocx);
            this.groupBox1.Controls.Add(this.rbDoc);
            this.groupBox1.Location = new System.Drawing.Point(27, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат";
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Location = new System.Drawing.Point(19, 22);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(52, 21);
            this.rbDoc.TabIndex = 0;
            this.rbDoc.TabStop = true;
            this.rbDoc.Text = "doc";
            this.rbDoc.UseVisualStyleBackColor = true;
            // 
            // rbDocx
            // 
            this.rbDocx.AutoSize = true;
            this.rbDocx.Location = new System.Drawing.Point(19, 50);
            this.rbDocx.Name = "rbDocx";
            this.rbDocx.Size = new System.Drawing.Size(58, 21);
            this.rbDocx.TabIndex = 1;
            this.rbDocx.TabStop = true;
            this.rbDocx.Text = "docx";
            this.rbDocx.UseVisualStyleBackColor = true;
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Location = new System.Drawing.Point(106, 23);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(43, 21);
            this.rbTxt.TabIndex = 2;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = "txt";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // rbRtf
            // 
            this.rbRtf.AutoSize = true;
            this.rbRtf.Location = new System.Drawing.Point(106, 50);
            this.rbRtf.Name = "rbRtf";
            this.rbRtf.Size = new System.Drawing.Size(42, 21);
            this.rbRtf.TabIndex = 3;
            this.rbRtf.TabStop = true;
            this.rbRtf.Text = "rtf";
            this.rbRtf.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB2TFileWithoutId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsApplication370.RepositoryDB2TFileWithoutId repositoryDB2TFileWithoutId;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private WindowsFormsApplication370.RepositoryDB2TFileWithoutIdTableAdapters.TFileTableAdapter tFileTableAdapter;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCatalogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRtf;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.RadioButton rbDocx;
        private System.Windows.Forms.RadioButton rbDoc;
    }
}