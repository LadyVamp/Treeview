using System;
using System.Windows.Forms;
using ExmapleNS;
using System.Data.SqlClient;

namespace WindowsFormsApplication370
{
    public partial class MainForm : Form
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
    }
}
