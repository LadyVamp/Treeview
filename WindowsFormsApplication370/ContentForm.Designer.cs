namespace Treeview
{
    partial class ContentForm
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
            this.rtbFilecontent = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbFilecontent
            // 
            this.rtbFilecontent.Location = new System.Drawing.Point(28, 116);
            this.rtbFilecontent.Name = "rtbFilecontent";
            this.rtbFilecontent.Size = new System.Drawing.Size(792, 333);
            this.rtbFilecontent.TabIndex = 0;
            this.rtbFilecontent.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(225, 8);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(69, 22);
            this.txtType.TabIndex = 5;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(96, 44);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(594, 22);
            this.txtFilename.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "CatalogID";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(319, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 17);
            this.label.TabIndex = 15;
            this.label.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(360, 8);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(87, 22);
            this.txtSize.TabIndex = 14;
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(775, 10);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(45, 22);
            this.txtCatID.TabIndex = 13;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(515, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(144, 22);
            this.txtDate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Keywords";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(96, 77);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(272, 22);
            this.txtKeywords.TabIndex = 19;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rtbFilecontent);
            this.Name = "ContentForm";
            this.Text = "ContentForm";
            this.Load += new System.EventHandler(this.ContentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox txtFilename;
        public System.Windows.Forms.TextBox txtSize;
        public System.Windows.Forms.TextBox txtCatID;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtKeywords;
        public System.Windows.Forms.RichTextBox rtbFilecontent;
    }
}