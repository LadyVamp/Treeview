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
            da.Fill(ds, "catalogs");
            dgvTCatalogEF.DataSource = ds.Tables[0];
            dgvTCatalogEF.Columns[0].Width = 20;
            dgvTCatalogEF.Columns[1].Width = 200;
            dgvTCatalogEF.Columns[2].Width = 40;
            dgvTCatalogEF.Columns[3].Width = 80;
            dgvTCatalogEF.Columns[4].Width = 60;
        }

        // --- CRUD for TCatalog ---
        //  Create
        private void InsertCatalog(string catalog, string rootId, string subCatalogId, string accessId)
        {
            string sql = "INSERT INTO TCatalog(catalog, rootId, subCatalogId, accessId) VALUES(@catalog,@rootId,@subCatalogId,@accessId)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@catalog", catalog);
            cmd.Parameters.AddWithValue("@rootId", rootId);
            cmd.Parameters.AddWithValue("@subCatalogId", subCatalogId);
            cmd.Parameters.AddWithValue("@accessId", accessId);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Запись добавлена");
                }
                con.Close();
                FillDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void clearTxts()
        {
            txtCatalog.Text = "";
            cmbRootId.Text = "";
            comboBox1.Text = "";
            cmbSubCatalogId.Text = "";
            comboBox3.Text = "";
            cmbAccessId.Text = "";
            comboBox5.Text = "";
        }

        //  Update
        private void UpdateCatalog(int id, string catalog, string rootId, string subCatalogId, string accessId)
        {
            string sql = "UPDATE TCatalog SET catalog='" + catalog + "',rootId='" + rootId + "',subCatalogId='" + subCatalogId + "',accessId='" + accessId + "' WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show("Запись обновлена");
                }
                con.Close();
                FillDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //  Delete
        private void DeleteCatalog(int id)
        {
            string sql = "DELETE FROM TCatalog WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                MessageBox.Show(con.State.ToString());
                adapter = new SqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Вы уверены?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        clearTxts();
                        MessageBox.Show("Запись удалена");
                    }
                }
                con.Close();
                FillDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnInsertCatalog_Click(object sender, EventArgs e)
        {
            if (txtCatalog.Text == "" || cmbRootId.Text == "" || comboBox1.Text == "" || cmbAccessId.Text == "" || comboBox3.Text == "" || cmbSubCatalogId.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertCatalog(txtCatalog.Text, cmbRootId.Text, cmbSubCatalogId.Text, cmbAccessId.Text);
            }
        }

        private void btnUpdCatalog_Click(object sender, EventArgs e)
        {
            if (txtCatalog.Text == "" || cmbRootId.Text == "" || cmbAccessId.Text == "" || cmbSubCatalogId.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTCatalogEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateCatalog(id, txtCatalog.Text, cmbRootId.Text, cmbSubCatalogId.Text, cmbAccessId.Text);
            }

        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void btnClearEF_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void btnDelCatalog_Click(object sender, EventArgs e)
        {
            String selected = dgvTCatalogEF.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteCatalog(id);
        }

        // При выделении строки из dgv подставить значения в текстбоксы 
        private void dgvTCatalogEF_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvTCatalogEF.CurrentCell != null && dgvTCatalogEF.CurrentCell.RowIndex >= 0)
            {
                txtCatalog.Text = dgvTCatalogEF.Rows[dgvTCatalogEF.CurrentCell.RowIndex].Cells["catalog"].Value.ToString();
                cmbRootId.Text = dgvTCatalogEF.Rows[dgvTCatalogEF.CurrentCell.RowIndex].Cells["rootId"].Value.ToString();
                cmbSubCatalogId.Text = dgvTCatalogEF.Rows[dgvTCatalogEF.CurrentCell.RowIndex].Cells["subCatalogId"].Value.ToString();
                cmbAccessId.Text = dgvTCatalogEF.Rows[dgvTCatalogEF.CurrentCell.RowIndex].Cells["accessId"].Value.ToString();
            }
        }


    }
}
