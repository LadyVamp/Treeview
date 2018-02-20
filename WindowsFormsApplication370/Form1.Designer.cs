namespace Treeview
{
    partial class Form1
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
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnCallFileinfoForm = new System.Windows.Forms.Button();
            this.btnCallLogin = new System.Windows.Forms.Button();
            this.btnOpenSearchForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(29, 291);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(319, 142);
            this.treeView2.TabIndex = 20;
            // 
            // btnCallFileinfoForm
            // 
            this.btnCallFileinfoForm.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCallFileinfoForm.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_database_administrator_26;
            this.btnCallFileinfoForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallFileinfoForm.Location = new System.Drawing.Point(29, 208);
            this.btnCallFileinfoForm.Name = "btnCallFileinfoForm";
            this.btnCallFileinfoForm.Size = new System.Drawing.Size(319, 46);
            this.btnCallFileinfoForm.TabIndex = 21;
            this.btnCallFileinfoForm.Text = "     Загрузить файл";
            this.btnCallFileinfoForm.UseVisualStyleBackColor = true;
            this.btnCallFileinfoForm.Click += new System.EventHandler(this.btnCallFileinfoForm_Click);
            // 
            // btnCallLogin
            // 
            this.btnCallLogin.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCallLogin.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_microsoft_admin_filled_26;
            this.btnCallLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallLogin.Location = new System.Drawing.Point(29, 138);
            this.btnCallLogin.Name = "btnCallLogin";
            this.btnCallLogin.Size = new System.Drawing.Size(319, 46);
            this.btnCallLogin.TabIndex = 1;
            this.btnCallLogin.Text = "     Вход для администратора";
            this.btnCallLogin.UseVisualStyleBackColor = true;
            this.btnCallLogin.Click += new System.EventHandler(this.btnCallLogin_Click);
            // 
            // btnOpenSearchForm
            // 
            this.btnOpenSearchForm.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenSearchForm.Image = global::WindowsFormsApplication370.Properties.Resources.icons8_search_filled_30;
            this.btnOpenSearchForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSearchForm.Location = new System.Drawing.Point(29, 52);
            this.btnOpenSearchForm.Name = "btnOpenSearchForm";
            this.btnOpenSearchForm.Size = new System.Drawing.Size(319, 51);
            this.btnOpenSearchForm.TabIndex = 0;
            this.btnOpenSearchForm.Text = "Открыть форму поиска";
            this.btnOpenSearchForm.UseVisualStyleBackColor = true;
            this.btnOpenSearchForm.Click += new System.EventHandler(this.btnOpenSearchForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 456);
            this.Controls.Add(this.btnCallFileinfoForm);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.btnCallLogin);
            this.Controls.Add(this.btnOpenSearchForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSearchForm;
        private System.Windows.Forms.Button btnCallLogin;
        public System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btnCallFileinfoForm;
    }
}