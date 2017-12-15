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
            con.Open(); //подключение открывается только при запуске формы
            FillDgv();
        }

        //TODO
        //CRUD-кнопки (из crud v3 - sp)

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
                //con.Open();
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

        ////  Read  
        //private void ViewFile()
        //{
        //    //dgvTFileEF.Rows.Clear();
        //    string sql = "SELECT * FROM TFile";
        //    cmd = new SqlCommand(sql, con);
        //    try
        //    {
        //        //con.Open();
        //        adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(dt);
        //        //foreach (DataRow row in dt.Rows)
        //        //{
        //        //    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
        //        //}
        //        FillDgv();
        //        //con.Close();
        //        dt.Rows.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        con.Close();
        //    }
        //}

        //private void populate(String id, string filename, string type, DateTime date, string size, string keywords, string filecontent, string catalogId)
        //{
        //    dgvTFile.Rows.Add(id, filename, type, date, size, keywords, filecontent, catalogId);
        //}

        private void clearTxts()
        {
            txtFilenameEF.Text = "";
            txtKeyEF.Text = "";
            cmbTypeEF.Text = "";
            txtSizeEF.Text = "";
            dtpEF.Text = "";
            txtCatIDEF.Text = "";
            rtbContentEF.Text = "";
        }

        //  Update
        private void UpdateFile(int id, string filename, string type, string date, string size, string keywords, string filecontent, string catalogId)
        {
            string sql = "UPDATE TFile SET filename='" + filename + "',type='" + type + "',date='" + date + "',size='" + size + "',keywords='" + keywords + "',filecontent='" + filecontent + "',catalogId='" + catalogId + "' WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                //con.Open();
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
                //con.Close();
            }
        }

        //  Delete
        private void DeleteFile(int id)
        {
            string sql = "DELETE FROM TFile WHERE ID=" + id + "";
            cmd = new SqlCommand(sql, con);
            try
            {
                //con.Open();
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
                //con.Close();
            }
        }


        private void btnInsertFile_Click(object sender, EventArgs e)
        {
            if (txtFilenameEF.Text == "" || cmbTypeEF.Text == "" || dtpEF.Value.ToString() == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || txtCatIDEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                InsertFile(txtFilenameEF.Text, cmbTypeEF.Text, dtpEF.Value.ToString(), txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, txtCatIDEF.Text);
            }
        }
        //cmd.Parameters.AddWithValue("@date", dtpEF.Value.ToString("dd/MM/yyyy"));

        private void btnUpdFile_Click(object sender, EventArgs e)
        {
            if (txtFilenameEF.Text == "" || cmbTypeEF.Text == "" || dtpEF.Text == "" || txtSizeEF.Text == "" || txtKeyEF.Text == "" || rtbContentEF.Text == "" || txtCatIDEF.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                String selected = dgvTFileEF.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                UpdateFile(id, txtFilenameEF.Text, cmbTypeEF.Text, dtpEF.Text, txtSizeEF.Text, txtKeyEF.Text, rtbContentEF.Text, txtCatIDEF.Text);
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
        // --- end CRUD for TFile ---

    }
}
