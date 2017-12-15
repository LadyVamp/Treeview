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
    public partial class EditTFileForm : Form
    //public partial class EditTFileForm : MetroFramework.Forms.MetroForm
    {

        public EditTFileForm()
        {
            InitializeComponent();
        }

        private const string CONNECTION_STRING =
"Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //заполнить dgvTFile
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "files");
            dgvTFileEF.DataSource = ds.Tables[0];
            dgvTFileEF.Columns[0].HeaderText = "ID";
            dgvTFileEF.Columns[1].HeaderText = "Название";
            dgvTFileEF.Columns[2].HeaderText = "Формат";
            dgvTFileEF.Columns[3].HeaderText = "Дата изменения";
            dgvTFileEF.Columns[4].HeaderText = "Размер, КБ";
            dgvTFileEF.Columns[5].HeaderText = "Ключевые слова";
            dgvTFileEF.Columns[6].HeaderText = "Содержание";
            dgvTFileEF.Columns[7].HeaderText = "IdCatalog";
            dgvTFileEF.Columns[0].Width = 20;
            dgvTFileEF.Columns[1].Width = 280;
            dgvTFileEF.Columns[2].Width = 40;
            dgvTFileEF.Columns[3].Width = 80;
            dgvTFileEF.Columns[4].Width = 60;
            dgvTFileEF.Columns[5].Width = 100;
            dgvTFileEF.Columns[6].Width = 300;
            dgvTFileEF.Columns[7].Width = 50;
        }

        private void EditTFileForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3DataSetTFile.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.repositoryDB3DataSetTFile.TFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3DataSetTCatalog.TCatalog". При необходимости она может быть перемещена или удалена.
            this.tCatalogTableAdapter.Fill(this.repositoryDB3DataSetTCatalog.TCatalog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB3DataSetTCatalog.TCatalog". При необходимости она может быть перемещена или удалена.
            this.tCatalogTableAdapter.Fill(this.repositoryDB3DataSetTCatalog.TCatalog);
            con.Open(); //подключение открывается только при запуске формы
            FillDgv();
            con.Close();
        }

        // --- CRUD for TFile ---
        //  Create
        private void InsertFile(string filename, string type, string date, string size, string keywords, string filecontent, string catalogId)
        {
            string sql = "INSERT INTO TFile(filename, type, date, size, keywords, filecontent, catalogId) VALUES(@filename,@type,@date,@size,@keywords,@filecontent,@catalogId)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@filename", filename);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@keywords", keywords);
            cmd.Parameters.AddWithValue("@filecontent", filecontent);
            cmd.Parameters.AddWithValue("@catalogId", catalogId);
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
            txtFilenameEF.Text = "";
            txtKeyEF.Text = "";
            cmbTypeEF.Text = "";
            txtSizeEF.Text = "";
            dtpEF.Text = "";
            cmbCatIDEF.Text = "";
            rtbContentEF.Text = "";
        }

        //  Update
        private void UpdateFile(int id, string filename, string type, string date, string size, string keywords, string filecontent, string catalogId)
        {
            string sql = "UPDATE TFile SET filename='" + filename + "',type='" + type + "',date='" + date + "',size='" + size + "',keywords='" + keywords + "',filecontent='" + filecontent + "',catalogId='" + catalogId + "' WHERE ID=" + id + "";
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
        private void DeleteFile(int id)
        {
            string sql = "DELETE FROM TFile WHERE ID=" + id + "";
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


        private void btnInsertFile_Click(object sender, EventArgs e)
        {
            if (txtFilenameEF.Text == "" || cmbTypeEF.Text == "" || dtpEF.Value.ToString() == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || cmbCatIDEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertFile(txtFilenameEF.Text, cmbTypeEF.Text, dtpEF.Value.ToString(), txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, cmbCatIDEF.Text);
            }
        }

        private void btnUpdFile_Click(object sender, EventArgs e)
        {
            if (txtFilenameEF.Text == "" || cmbTypeEF.Text == "" || dtpEF.Text == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || cmbCatIDEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTFileEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateFile(id, txtFilenameEF.Text, cmbTypeEF.Text, dtpEF.Text, txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, cmbCatIDEF.Text);
            }
        }

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void btnDelFile_Click(object sender, EventArgs e)
        {
            String selected = dgvTFileEF.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            DeleteFile(id);
        }

        //ввод только цифр, точек, запятых и backspace в текстбокс
        private void txtSizeEF_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '.' || c == ',' || c == '\b');
        }

        // --- end CRUD for TFile ---


        // При выделении строки из dgv подставить значения в текстбоксы 
        private void dgvTFileEF_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvTFileEF.CurrentCell != null && dgvTFileEF.CurrentCell.RowIndex >= 0)
            {
                txtFilenameEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["filename"].Value.ToString();
                cmbTypeEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["type"].Value.ToString();
                dtpEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["date"].Value.ToString();
                txtSizeEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["size"].Value.ToString();
                txtKeyEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["keywords"].Value.ToString();
                rtbContentEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["filecontent"].Value.ToString();
                cmbCatIDEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["catalogId"].Value.ToString();
            }
        }




    }
}
