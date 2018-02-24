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
    public partial class EditTCatalogForm : Form
    {
        public EditTCatalogForm()
        {
            InitializeComponent();
        }

        private void EditTCatalogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TTypeForEditTCatalogForm.TType". При необходимости она может быть перемещена или удалена.
            this.tTypeTableAdapter.Fill(this.repositoryDB3TTypeForEditTCatalogForm.TType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TCatalogForEditTCatalogForm.TCatalog". При необходимости она может быть перемещена или удалена.
            this.tCatalogTableAdapter1.Fill(this.repositoryDB3TCatalogForEditTCatalogForm.TCatalog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TCatalog.TCatalog". При необходимости она может быть перемещена или удалена.
            this.tCatalogTableAdapter.Fill(this.repositoryDB3TCatalog.TCatalog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TRoot.TRoot". При необходимости она может быть перемещена или удалена.
            this.tRootTableAdapter.Fill(this.repositoryDB3TRoot.TRoot);

        }
    }
}
