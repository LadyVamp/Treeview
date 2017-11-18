using System;
using System.Windows.Forms;
using ExmapleNS;
using System.Data.SqlClient;

namespace Treeview
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB2TFileWithoutId.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.repositoryDB2TFileWithoutId.TFile);
            metroGrid1.Columns[0].Width = 200; //name
            metroGrid1.Columns[1].Width = 50; //type
            metroGrid1.Columns[2].Width = 60; //date
            metroGrid1.Columns[3].Width = 50; //size
            metroGrid1.Columns[4].Width = 100; //keywords
            metroGrid1.Columns[5].Width = 200; //fileContent
            metroGrid1.Columns[6].Width = 60; //subcatalog

        }
    }
}
