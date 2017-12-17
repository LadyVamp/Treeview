namespace Treeview
{
    partial class MainForm
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
            this.btnOpenSearchForm = new System.Windows.Forms.Button();
            this.btnCallLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSearchForm
            // 
            this.btnOpenSearchForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenSearchForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenSearchForm.Location = new System.Drawing.Point(261, 12);
            this.btnOpenSearchForm.Name = "btnOpenSearchForm";
            this.btnOpenSearchForm.Size = new System.Drawing.Size(202, 32);
            this.btnOpenSearchForm.TabIndex = 3;
            this.btnOpenSearchForm.Text = "Открыть форму поиска";
            this.btnOpenSearchForm.UseVisualStyleBackColor = false;
            this.btnOpenSearchForm.Click += new System.EventHandler(this.btnOpenSearchForm_Click);
            // 
            // btnCallLogin
            // 
            this.btnCallLogin.Location = new System.Drawing.Point(261, 65);
            this.btnCallLogin.Name = "btnCallLogin";
            this.btnCallLogin.Size = new System.Drawing.Size(202, 27);
            this.btnCallLogin.TabIndex = 20;
            this.btnCallLogin.Text = "Вход для администратора";
            this.btnCallLogin.UseVisualStyleBackColor = true;
            this.btnCallLogin.Click += new System.EventHandler(this.btnCallLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 541);
            this.Controls.Add(this.btnCallLogin);
            this.Controls.Add(this.btnOpenSearchForm);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenSearchForm;
        private System.Windows.Forms.Button btnCallLogin;
    }
}

