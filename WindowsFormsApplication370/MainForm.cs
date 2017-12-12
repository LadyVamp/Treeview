using System;
using System.Windows.Forms;
using ExmapleNS;
using System.Data.SqlClient;

namespace Treeview
{
    public partial class MainForm : Form
        //public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            //load db
            Repository.LoadDataSet();

            //build tree
            ftMain.Build(new TreeNode());
        }


        private void ftMain_DoubleClick(object sender, EventArgs e)
        {
            var node = ftMain.SelectedNode as TreeNode;
            if (node != null)
            {
                //create edit form
                var form = new InputForm() {MdiParent = this};
                //after form closed - rebuild myself
                form.FormClosed += (o, O) =>
                {
                    if (form.DialogResult == DialogResult.OK)
                        Build();
                };
                //build edit form
                form.Build(node.Row);
                //show edit form
                form.Show();
            }
        }

        private void Build()
        {
            ftMain.Rebuild();
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
