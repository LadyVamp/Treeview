using System;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
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
