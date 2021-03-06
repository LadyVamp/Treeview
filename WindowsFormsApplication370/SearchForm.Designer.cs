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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.tFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB2TFileWithoutId = new WindowsFormsApplication370.RepositoryDB2TFileWithoutId();
            this.tFileTableAdapter = new WindowsFormsApplication370.RepositoryDB2TFileWithoutIdTableAdapters.TFileTableAdapter();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tFileBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryDB3TFile = new WindowsFormsApplication370.RepositoryDB3TFile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSizeFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinSize = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.cbDate2 = new System.Windows.Forms.CheckBox();
            this.cbDate1 = new System.Windows.Forms.CheckBox();
            this.tFileTableAdapter1 = new WindowsFormsApplication370.RepositoryDB3TFileTableAdapters.TFileTableAdapter();
            this.cbDoc = new System.Windows.Forms.CheckBox();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.cbRtf = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnType = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTFile = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnSearchKeywords = new System.Windows.Forms.Button();
            this.btnAllSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB2TFileWithoutId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFile)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFile)).BeginInit();
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // tFileBindingSource1
            // 
            this.tFileBindingSource1.DataMember = "TFile";
            this.tFileBindingSource1.DataSource = this.repositoryDB3TFile;
            // 
            // repositoryDB3TFile
            // 
            this.repositoryDB3TFile.DataSetName = "RepositoryDB3TFile";
            this.repositoryDB3TFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSizeFilter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaxSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMinSize);
            this.groupBox2.Location = new System.Drawing.Point(112, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер";
            // 
            // btnSizeFilter
            // 
            this.btnSizeFilter.Location = new System.Drawing.Point(130, 19);
            this.btnSizeFilter.Name = "btnSizeFilter";
            this.btnSizeFilter.Size = new System.Drawing.Size(105, 30);
            this.btnSizeFilter.TabIndex = 6;
            this.btnSizeFilter.Text = "Применить";
            this.btnSizeFilter.UseVisualStyleBackColor = true;
            this.btnSizeFilter.Click += new System.EventHandler(this.btnSizeFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "кБ";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(37, 51);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(57, 22);
            this.txtMaxSize.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "кБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "От";
            // 
            // txtMinSize
            // 
            this.txtMinSize.Location = new System.Drawing.Point(39, 21);
            this.txtMinSize.Name = "txtMinSize";
            this.txtMinSize.Size = new System.Drawing.Size(55, 22);
            this.txtMinSize.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(29, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDateFilter);
            this.groupBox3.Controls.Add(this.cbDate2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.cbDate1);
            this.groupBox3.Location = new System.Drawing.Point(118, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата";
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(120, 74);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(105, 29);
            this.btnDateFilter.TabIndex = 13;
            this.btnDateFilter.Text = "Применить";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            // 
            // cbDate2
            // 
            this.cbDate2.AutoSize = true;
            this.cbDate2.Location = new System.Drawing.Point(6, 52);
            this.cbDate2.Name = "cbDate2";
            this.cbDate2.Size = new System.Drawing.Size(18, 17);
            this.cbDate2.TabIndex = 12;
            this.cbDate2.UseVisualStyleBackColor = true;
            // 
            // cbDate1
            // 
            this.cbDate1.AutoSize = true;
            this.cbDate1.Location = new System.Drawing.Point(6, 25);
            this.cbDate1.Name = "cbDate1";
            this.cbDate1.Size = new System.Drawing.Size(18, 17);
            this.cbDate1.TabIndex = 11;
            this.cbDate1.UseVisualStyleBackColor = true;
            // 
            // tFileTableAdapter1
            // 
            this.tFileTableAdapter1.ClearBeforeFill = true;
            // 
            // cbDoc
            // 
            this.cbDoc.AutoSize = true;
            this.cbDoc.Location = new System.Drawing.Point(6, 30);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(57, 21);
            this.cbDoc.TabIndex = 12;
            this.cbDoc.Tag = "doc";
            this.cbDoc.Text = ".doc";
            this.cbDoc.UseVisualStyleBackColor = true;
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Location = new System.Drawing.Point(79, 30);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(60, 21);
            this.cbHtml.TabIndex = 14;
            this.cbHtml.Tag = "html";
            this.cbHtml.Text = ".html";
            this.cbHtml.UseVisualStyleBackColor = true;
            // 
            // cbRtf
            // 
            this.cbRtf.AutoSize = true;
            this.cbRtf.Location = new System.Drawing.Point(6, 57);
            this.cbRtf.Name = "cbRtf";
            this.cbRtf.Size = new System.Drawing.Size(47, 21);
            this.cbRtf.TabIndex = 15;
            this.cbRtf.Tag = "rtf";
            this.cbRtf.Text = ".rtf";
            this.cbRtf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnType);
            this.groupBox1.Controls.Add(this.cbDoc);
            this.groupBox1.Controls.Add(this.cbRtf);
            this.groupBox1.Controls.Add(this.cbHtml);
            this.groupBox1.Location = new System.Drawing.Point(109, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формат";
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(138, 30);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(97, 30);
            this.btnType.TabIndex = 16;
            this.btnType.Text = "Применить";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 323);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_search_filled_26;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(38, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 40);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "   Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTFile
            // 
            this.dgvTFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTFile.Location = new System.Drawing.Point(366, 12);
            this.dgvTFile.Name = "dgvTFile";
            this.dgvTFile.RowTemplate.Height = 24;
            this.dgvTFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTFile.Size = new System.Drawing.Size(905, 536);
            this.dgvTFile.TabIndex = 18;
            this.dgvTFile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTFile_CellDoubleClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 352);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 168);
            this.treeView1.TabIndex = 19;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(12, 526);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(245, 22);
            this.txtKeywords.TabIndex = 20;
            // 
            // btnSearchKeywords
            // 
            this.btnSearchKeywords.Location = new System.Drawing.Point(263, 481);
            this.btnSearchKeywords.Name = "btnSearchKeywords";
            this.btnSearchKeywords.Size = new System.Drawing.Size(90, 67);
            this.btnSearchKeywords.TabIndex = 21;
            this.btnSearchKeywords.Text = "Поиск по ключевым словам";
            this.btnSearchKeywords.UseVisualStyleBackColor = true;
            this.btnSearchKeywords.Click += new System.EventHandler(this.btnSearchKeywords_Click);
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Location = new System.Drawing.Point(12, 257);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(87, 60);
            this.btnAllSearch.TabIndex = 22;
            this.btnAllSearch.Text = "Все фильтры";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.btnAllSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 554);
            this.Controls.Add(this.btnAllSearch);
            this.Controls.Add(this.btnSearchKeywords);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgvTFile);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB2TFileWithoutId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFileBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDB3TFile)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsApplication370.RepositoryDB2TFileWithoutId repositoryDB2TFileWithoutId;
        private System.Windows.Forms.BindingSource tFileBindingSource;
        private WindowsFormsApplication370.RepositoryDB2TFileWithoutIdTableAdapters.TFileTableAdapter tFileTableAdapter;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinSize;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private WindowsFormsApplication370.RepositoryDB3TFile repositoryDB3TFile;
        private System.Windows.Forms.BindingSource tFileBindingSource1;
        private WindowsFormsApplication370.RepositoryDB3TFileTableAdapters.TFileTableAdapter tFileTableAdapter1;
        private System.Windows.Forms.CheckBox cbDoc;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.CheckBox cbRtf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnSizeFilter;
        private System.Windows.Forms.CheckBox cbDate2;
        private System.Windows.Forms.CheckBox cbDate1;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTFile;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Button btnSearchKeywords;
        private System.Windows.Forms.Button btnAllSearch;
    }
}