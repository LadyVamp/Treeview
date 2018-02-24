using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            con.Open(); //подключение открывается только при запуске формы
            FillDgv();
            con.Close();
        }

        private const string CONNECTION_STRING =
"Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //заполнить dgvTCatalog
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TCatalog", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "files");
            dgvTCatalogEF.DataSource = ds.Tables[0];
            dgvTCatalogEF.Columns[0].Width = 20;
            dgvTCatalogEF.Columns[1].Width = 150;
            dgvTCatalogEF.Columns[2].Width = 40;
            dgvTCatalogEF.Columns[3].Width = 80;
            dgvTCatalogEF.Columns[4].Width = 60;
        }



        private void btnInsertCatalog_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdCatalog_Click(object sender, EventArgs e)
        {

        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {

        }

        private void btnClearEF_Click(object sender, EventArgs e)
        {

        }

        private void btnDelCatalog_Click(object sender, EventArgs e)
        {

        }

    }
}
