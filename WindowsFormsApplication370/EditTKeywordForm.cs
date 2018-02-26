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
    public partial class EditTKeywordForm : Form
    {
        public EditTKeywordForm()
        {
            InitializeComponent();
        }

        private void EditTKeywordForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TKeywordForEditTKeywordForm.TKeyword". При необходимости она может быть перемещена или удалена.
            this.tKeywordTableAdapter.Fill(this.repositoryDB3TKeywordForEditTKeywordForm.TKeyword);
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

        //заполнить dgvTKeyword
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TKeyword", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "keywords");
            dgvTKeywordEF.DataSource = ds.Tables[0];
            dgvTKeywordEF.Columns[0].Width = 20;
            dgvTKeywordEF.Columns[1].Width = 200;
            dgvTKeywordEF.Columns[2].Width = 40;
            dgvTKeywordEF.Columns[3].Width = 80;
        }

        // --- CRUD for TKeyword ---
        //  Create
        private void InsertKeyword(string keyword, string parentKeyId, string fileId)
        {
            string sql = "INSERT INTO TKeyword(keyword, parentKeyId, fileId) VALUES(@keyword,@parentKeyId,@fileId)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@keyword", keyword);
            cmd.Parameters.AddWithValue("@parentKeyId", parentKeyId);
            cmd.Parameters.AddWithValue("@fileId", fileId);
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

        //  Update
        private void UpdateKeyword(int id, string keyword, string parentKeyId,string fileId)
        {
            string sql = "UPDATE TKeyword SET keyword='" + keyword + "',parentKeyId='" + parentKeyId +"',fileId='" + fileId + "' WHERE ID=" + id + "";
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
        private void DeleteKeyword(int id)
        {
            string sql = "DELETE FROM TKeyword WHERE ID=" + id + "";
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

        private void clearTxts()
        {
            txtKeyword.Text = "";
            cmbParentKeyId.Text = "";
            cmbFileId.Text = "";
        }

        private void btnClearEF_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        private void btnInsertKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "" || cmbParentKeyId.Text == "" || cmbFileId.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertKeyword(txtKeyword.Text, cmbParentKeyId.Text, cmbFileId.Text);
            }
        }

        private void btnUpdKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "" || cmbParentKeyId.Text == "" || cmbFileId.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTKeywordEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateKeyword(id, txtKeyword.Text, cmbParentKeyId.Text, cmbFileId.Text);
            }
        }

        private void btnViewKeyword_Click(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void btnDelKeyword_Click(object sender, EventArgs e)
        {
            String selected = dgvTKeywordEF.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteKeyword(id);
        }

        // При выделении строки из dgv подставить значения в текстбоксы 
        private void dgvTKeywordEF_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvTKeywordEF.CurrentCell != null && dgvTKeywordEF.CurrentCell.RowIndex >= 0)
            {
                txtKeyword.Text = dgvTKeywordEF.Rows[dgvTKeywordEF.CurrentCell.RowIndex].Cells["keyword"].Value.ToString();
                cmbParentKeyId.Text = dgvTKeywordEF.Rows[dgvTKeywordEF.CurrentCell.RowIndex].Cells["parentKeyId"].Value.ToString();
                cmbFileId.Text = dgvTKeywordEF.Rows[dgvTKeywordEF.CurrentCell.RowIndex].Cells["fileId"].Value.ToString();
            }
        }
    }
}
