using System;
using System.Windows.Forms;

namespace Treeview
{
    public partial class MainForm : Form
    //public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenSearchForm_Click(object sender, EventArgs e)
        {
           SearchForm f2 = new SearchForm();
            f2.Show();
        }

        private void btnCallLogin_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
        }
    }
}
