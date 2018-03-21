using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Treeview
{
    public partial class EditTRoleForm : Form
    {
        public EditTRoleForm()
        {
            InitializeComponent();
        }

        private void EditTRoleForm_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TTypeForEditTRoleForm.TType". При необходимости она может быть перемещена или удалена.
            //this.tTypeTableAdapter.Fill(this.repositoryDB3TTypeForEditTRoleForm.TType);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TRoleForEditTRoleForm.TRole". При необходимости она может быть перемещена или удалена.
            //this.tRoleTableAdapter1.Fill(this.repositoryDB3TRoleForEditTRoleForm.TRole);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TRole.TRole". При необходимости она может быть перемещена или удалена.
            //this.tRoleTableAdapter.Fill(this.repositoryDB3TRole.TRole);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3TRoot.TRoot". При необходимости она может быть перемещена или удалена.
            //this.tRootTableAdapter.Fill(this.repositoryDB3TRoot.TRoot);
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

        //заполнить dgvTRole
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TRole", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "roles");
            dgvTRoleEF.DataSource = ds.Tables[0];
            dgvTRoleEF.Columns[0].Width = 20;
            dgvTRoleEF.Columns[1].Width = 100;
            dgvTRoleEF.Columns[2].Width = 40;
            dgvTRoleEF.Columns[3].Width = 160;
        }

        // --- CRUD for TRole ---
        //  Create
        private void InsertRole(string role, string typeId, string description)
        {
            string sql = "INSERT INTO TRole(role, typeId, description) VALUES(@role,@typeId,@description)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@typeId", typeId);
            cmd.Parameters.AddWithValue("@description", description);
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
            txtRolename.Text = "";
            cmbTypeId.Text = "";
            txtRoleDescription.Text = "";
        }

        //  Update
        private void UpdateRole(int id, string role, string typeId, string description)
        {
            string sql = "UPDATE TRole SET role='" + role + "',typeId='" + typeId + "',description='" + description  + "' WHERE ID=" + id + "";
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
        private void DeleteRole(int id)
        {
            string sql = "DELETE FROM TRole WHERE ID=" + id + "";
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

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            if (txtRolename.Text == "" || cmbTypeId.Text == "" || txtRoleDescription.Text == "" )
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertRole(txtRolename.Text, cmbTypeId.Text, txtRoleDescription.Text);
            }
        }

        private void btnUpdRole_Click(object sender, EventArgs e)
        {
            if (txtRolename.Text == "" || cmbTypeId.Text == "" || txtRoleDescription.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTRoleEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateRole(id, txtRolename.Text, cmbTypeId.Text, txtRoleDescription.Text);
            }
        }

        private void btnViewRole_Click(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void btnDelRole_Click(object sender, EventArgs e)
        {
            String selected = dgvTRoleEF.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteRole(id);
        }

        private void btnClearEF_Click(object sender, EventArgs e)
        {
            clearTxts();
        }

        // При выделении строки из dgv подставить значения в текстбоксы 
        private void dgvTRoleEF_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvTRoleEF.CurrentCell != null && dgvTRoleEF.CurrentCell.RowIndex >= 0)
            {
                txtRolename.Text = dgvTRoleEF.Rows[dgvTRoleEF.CurrentCell.RowIndex].Cells["catalog"].Value.ToString();
                cmbTypeId.Text = dgvTRoleEF.Rows[dgvTRoleEF.CurrentCell.RowIndex].Cells["typeId"].Value.ToString();
                txtRoleDescription.Text = dgvTRoleEF.Rows[dgvTRoleEF.CurrentCell.RowIndex].Cells["description"].Value.ToString();
            }
        }
    }
}
