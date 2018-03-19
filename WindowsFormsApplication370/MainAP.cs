using System;
using System.Windows.Forms;

namespace Treeview
{
    public partial class MainAP : Form
    {
        public MainAP()
        {
            InitializeComponent();
        }

        private void btnEditTFile_Click(object sender, EventArgs e)
        {
            EditTFileForm f = new EditTFileForm();
            f.Show();
        }

        private void btnEditTCatalog_Click(object sender, EventArgs e)
        {
            EditTCatalogForm f = new EditTCatalogForm();
            f.Show();
        }

        private void btnEditTKeyword_Click(object sender, EventArgs e)
        {
            EditTKeywordForm f = new EditTKeywordForm();
            f.Show();
        }

        private void btnEditTRole_Click(object sender, EventArgs e)
        {
            EditTRoleForm f = new EditTRoleForm();
            f.Show();
        }

        private void btnEditTType_Click(object sender, EventArgs e)
        {
            EditTTypeForm f = new EditTTypeForm();
            f.Show();
        }

        //TODO
        // Редактирование остальных таблиц: TCatalog, TUser, TKeyword
        // как в EditTFileForm


    }
}
