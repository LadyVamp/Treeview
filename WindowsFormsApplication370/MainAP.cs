using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //TODO
        // Редактирование остальных таблиц: TCatalog, TUser, TKeyword
        // как в EditTFileForm


    }
}
