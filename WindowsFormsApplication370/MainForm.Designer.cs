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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ftMain = new FastTreeNS.FastTree();
            this.SuspendLayout();
            // 
            // ftMain
            // 
            this.ftMain.AutoScroll = true;
            this.ftMain.AutoScrollMinSize = new System.Drawing.Size(0, 59);
            this.ftMain.BackColor = System.Drawing.SystemColors.Window;
            this.ftMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.ftMain.ImageCheckBoxOff = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageCheckBoxOff")));
            this.ftMain.ImageCheckBoxOn = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageCheckBoxOn")));
            this.ftMain.ImageCollapse = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageCollapse")));
            this.ftMain.ImageDefaultIcon = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageDefaultIcon")));
            this.ftMain.ImageEmptyExpand = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageEmptyExpand")));
            this.ftMain.ImageExpand = ((System.Drawing.Image)(resources.GetObject("ftMain.ImageExpand")));
            this.ftMain.IsEditMode = false;
            this.ftMain.Location = new System.Drawing.Point(0, 0);
            this.ftMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ftMain.Name = "ftMain";
            this.ftMain.Readonly = true;
            this.ftMain.ShowExpandBoxes = true;
            this.ftMain.Size = new System.Drawing.Size(264, 476);
            this.ftMain.TabIndex = 1;
            this.ftMain.DoubleClick += new System.EventHandler(this.ftMain_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 476);
            this.Controls.Add(this.ftMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private FastTreeNS.FastTree ftMain;
    }
}

