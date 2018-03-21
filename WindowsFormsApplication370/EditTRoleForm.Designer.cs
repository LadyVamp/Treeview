namespace Treeview
{
    partial class EditTRoleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRolename = new System.Windows.Forms.TextBox();
            this.txtRoleDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTypeId = new System.Windows.Forms.ComboBox();
            this.dgvTRoleEF = new System.Windows.Forms.DataGridView();
            this.btnInsertRole = new System.Windows.Forms.Button();
            this.btnUpdRole = new System.Windows.Forms.Button();
            this.btnViewRole = new System.Windows.Forms.Button();
            this.btnDelRole = new System.Windows.Forms.Button();
            this.btnClearEF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTRoleEF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название роли";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пояснение";
            // 
            // txtRolename
            // 
            this.txtRolename.Location = new System.Drawing.Point(165, 37);
            this.txtRolename.Name = "txtRolename";
            this.txtRolename.Size = new System.Drawing.Size(166, 22);
            this.txtRolename.TabIndex = 7;
            // 
            // txtRoleDescription
            // 
            this.txtRoleDescription.Location = new System.Drawing.Point(165, 113);
            this.txtRoleDescription.Name = "txtRoleDescription";
            this.txtRoleDescription.Size = new System.Drawing.Size(166, 22);
            this.txtRoleDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TypeId";
            // 
            // cmbTypeId
            // 
            this.cmbTypeId.FormattingEnabled = true;
            this.cmbTypeId.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbTypeId.Location = new System.Drawing.Point(165, 68);
            this.cmbTypeId.Name = "cmbTypeId";
            this.cmbTypeId.Size = new System.Drawing.Size(166, 24);
            this.cmbTypeId.TabIndex = 10;
            // 
            // dgvTRoleEF
            // 
            this.dgvTRoleEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTRoleEF.Location = new System.Drawing.Point(377, 26);
            this.dgvTRoleEF.Name = "dgvTRoleEF";
            this.dgvTRoleEF.RowTemplate.Height = 24;
            this.dgvTRoleEF.Size = new System.Drawing.Size(444, 285);
            this.dgvTRoleEF.TabIndex = 11;
            // 
            // btnInsertRole
            // 
            this.btnInsertRole.Image = global::WindowsFormsApplication370.Properties.Resources.insert_plus_26;
            this.btnInsertRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertRole.Location = new System.Drawing.Point(30, 185);
            this.btnInsertRole.Name = "btnInsertRole";
            this.btnInsertRole.Size = new System.Drawing.Size(98, 42);
            this.btnInsertRole.TabIndex = 12;
            this.btnInsertRole.Text = "     Insert";
            this.btnInsertRole.UseVisualStyleBackColor = true;
            this.btnInsertRole.Click += new System.EventHandler(this.btnInsertRole_Click);
            // 
            // btnUpdRole
            // 
            this.btnUpdRole.Image = global::WindowsFormsApplication370.Properties.Resources.update_Data_Backup_26;
            this.btnUpdRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdRole.Location = new System.Drawing.Point(144, 185);
            this.btnUpdRole.Name = "btnUpdRole";
            this.btnUpdRole.Size = new System.Drawing.Size(98, 42);
            this.btnUpdRole.TabIndex = 13;
            this.btnUpdRole.Text = "     Update";
            this.btnUpdRole.UseVisualStyleBackColor = true;
            this.btnUpdRole.Click += new System.EventHandler(this.btnUpdRole_Click);
            // 
            // btnViewRole
            // 
            this.btnViewRole.Image = global::WindowsFormsApplication370.Properties.Resources.view_Eye_26;
            this.btnViewRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewRole.Location = new System.Drawing.Point(273, 185);
            this.btnViewRole.Name = "btnViewRole";
            this.btnViewRole.Size = new System.Drawing.Size(98, 42);
            this.btnViewRole.TabIndex = 14;
            this.btnViewRole.Text = "     View";
            this.btnViewRole.UseVisualStyleBackColor = true;
            this.btnViewRole.Click += new System.EventHandler(this.btnViewRole_Click);
            // 
            // btnDelRole
            // 
            this.btnDelRole.Image = global::WindowsFormsApplication370.Properties.Resources.delete_Trash_26;
            this.btnDelRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelRole.Location = new System.Drawing.Point(273, 249);
            this.btnDelRole.Name = "btnDelRole";
            this.btnDelRole.Size = new System.Drawing.Size(98, 42);
            this.btnDelRole.TabIndex = 15;
            this.btnDelRole.Text = "     Delete";
            this.btnDelRole.UseVisualStyleBackColor = true;
            this.btnDelRole.Click += new System.EventHandler(this.btnDelRole_Click);
            // 
            // btnClearEF
            // 
            this.btnClearEF.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_broom_26;
            this.btnClearEF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearEF.Location = new System.Drawing.Point(30, 261);
            this.btnClearEF.Name = "btnClearEF";
            this.btnClearEF.Size = new System.Drawing.Size(165, 30);
            this.btnClearEF.TabIndex = 16;
            this.btnClearEF.Text = "     Очистить форму";
            this.btnClearEF.UseVisualStyleBackColor = true;
            this.btnClearEF.Click += new System.EventHandler(this.btnClearEF_Click);
            // 
            // EditTRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 323);
            this.Controls.Add(this.btnClearEF);
            this.Controls.Add(this.btnDelRole);
            this.Controls.Add(this.btnViewRole);
            this.Controls.Add(this.btnUpdRole);
            this.Controls.Add(this.btnInsertRole);
            this.Controls.Add(this.dgvTRoleEF);
            this.Controls.Add(this.cmbTypeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoleDescription);
            this.Controls.Add(this.txtRolename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTRoleForm";
            this.Text = "EditTRoleForm";
            this.Load += new System.EventHandler(this.EditTRoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTRoleEF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRolename;
        private System.Windows.Forms.TextBox txtRoleDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTypeId;
        private System.Windows.Forms.DataGridView dgvTRoleEF;
        private System.Windows.Forms.Button btnInsertRole;
        private System.Windows.Forms.Button btnUpdRole;
        private System.Windows.Forms.Button btnViewRole;
        private System.Windows.Forms.Button btnDelRole;
        private System.Windows.Forms.Button btnClearEF;
    }
}