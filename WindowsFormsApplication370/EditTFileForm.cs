using System;
using System.Data;
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
            dgvTFileEF.Columns[3].HeaderText = "Дата создания";
            dgvTFileEF.Columns[4].HeaderText = "Размер, КБ";
            dgvTFileEF.Columns[5].HeaderText = "Ключевые слова";
            dgvTFileEF.Columns[6].HeaderText = "Содержание";
            dgvTFileEF.Columns[7].HeaderText = "IdCatalog";
            dgvTFileEF.Columns[8].HeaderText = "Дата изменения";
            dgvTFileEF.Columns[9].HeaderText = "Аннотация";
            dgvTFileEF.Columns[10].HeaderText = "Автор";
            dgvTFileEF.Columns[0].Width = 20;
            dgvTFileEF.Columns[1].Width = 280;
            dgvTFileEF.Columns[2].Width = 40;
            dgvTFileEF.Columns[3].Width = 80;
            dgvTFileEF.Columns[4].Width = 30;
            dgvTFileEF.Columns[5].Width = 150;
            dgvTFileEF.Columns[6].Width = 300;
            dgvTFileEF.Columns[7].Width = 30;
            dgvTFileEF.Columns[8].Width = 70;
            dgvTFileEF.Columns[9].Width = 70;
            dgvTFileEF.Columns[10].Width = 70;
        }

        private void EditTFileForm_Load(object sender, EventArgs e)
        {
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
        private void InsertFile(string title, string type, string datecreate, string size, string keywords, string filecontent, string catalogId, string datechange, string annotation, string author)
        {
            string sql = "INSERT INTO TFile(title, type, datecreate, size, keywords, filecontent, catalogId, datechange, annotation, author) VALUES(@title,@type,@datecreate,@size,@keywords,@filecontent,@catalogId,@datechange,@annotation,@author)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@datecreate", datecreate);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@keywords", keywords);
            cmd.Parameters.AddWithValue("@filecontent", filecontent);
            cmd.Parameters.AddWithValue("@catalogId", catalogId);
            cmd.Parameters.AddWithValue("@datechange", datechange);
            cmd.Parameters.AddWithValue("@annotation", annotation);
            cmd.Parameters.AddWithValue("@author", author);
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
            txtTitleEF.Text = "";
            txtKeyEF.Text = "";
            cmbTypeEF.Text = "";
            txtSizeEF.Text = "";
            dtpDateCreateEF.Text = "";
            cmbCatIDEF.Text = "";
            rtbContentEF.Text = "";
            dtpDateChangeEF.Text = "";
            rtbAnnotationEF.Text = "";
            txtAuthorEF.Text = "";
        }

        //  Update
        private void UpdateFile(int id, string title, string type, string datecreate, string size, string keywords, string filecontent, string catalogId, string datechange, string annotation, string author)
        {
            string sql = "UPDATE TFile SET title='" + title + "',type='" + type + "',datecreate='" + datecreate + "',size='" + size + "',keywords='" + keywords + "',filecontent='" + filecontent + "',catalogId='" + catalogId + "',datechange='" + datechange + "',annotation='" + annotation + "',author='" + author + "' WHERE ID=" + id + "";
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
            if (txtTitleEF.Text == "" || cmbTypeEF.Text == "" || dtpDateCreateEF.Value.ToString() == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || cmbCatIDEF.Text == "" || dtpDateChangeEF.Text == "" || rtbAnnotationEF.Text == "" || txtAuthorEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertFile(txtTitleEF.Text, cmbTypeEF.Text, dtpDateCreateEF.Value.ToString(), txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, cmbCatIDEF.Text, dtpDateChangeEF.Text, rtbAnnotationEF.Text, txtAuthorEF.Text);
            }
        }

        private void btnUpdFile_Click(object sender, EventArgs e)
        {
            if (txtTitleEF.Text == "" || cmbTypeEF.Text == "" || dtpDateCreateEF.Text == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || cmbCatIDEF.Text == "" || dtpDateChangeEF.Text == "" || rtbAnnotationEF.Text == "" || txtAuthorEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTFileEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateFile(id, txtTitleEF.Text, cmbTypeEF.Text, dtpDateCreateEF.Text, txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, cmbCatIDEF.Text, dtpDateChangeEF.Text, rtbAnnotationEF.Text, txtAuthorEF.Text);
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
                txtTitleEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["title"].Value.ToString();
                cmbTypeEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["type"].Value.ToString();
                dtpDateCreateEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["datecreate"].Value.ToString();
                txtSizeEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["size"].Value.ToString();
                txtKeyEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["keywords"].Value.ToString();
                rtbContentEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["filecontent"].Value.ToString();
                cmbCatIDEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["catalogId"].Value.ToString();
                dtpDateChangeEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["datechange"].Value.ToString();
                rtbAnnotationEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["annotation"].Value.ToString();
                txtAuthorEF.Text = dgvTFileEF.Rows[dgvTFileEF.CurrentCell.RowIndex].Cells["author"].Value.ToString();
            }
        }

        private void btnClearEF_Click(object sender, EventArgs e)
        {
            clearTxts();
        }
    }
}
