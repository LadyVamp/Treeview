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
    public partial class SearchForm : Form
        //public partial class SearchForm : MetroFramework.Forms.MetroForm
    {
        //public SearchForm()
        //{
        //    InitializeComponent();
        //}

        public SearchForm()
        {
            InitializeComponent();
            //FileGrid.ColumnCount = 8;
            //FileGrid.Columns[0].Name = "ID";
            //FileGrid.Columns[1].Name = "filename";
            //FileGrid.Columns[2].Name = "type";
            //FileGrid.Columns[3].Name = "date";
            //FileGrid.Columns[4].Name = "size";
            //FileGrid.Columns[5].Name = "keywords";
            //FileGrid.Columns[6].Name = "filecontent";
            //FileGrid.Columns[7].Name = "catalogid";
            //FileGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //FileGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //FileGrid.MultiSelect = false;
        }

        //private void SearchForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB2TFileWithoutId.TFile". При необходимости она может быть перемещена или удалена.
        //    this.tFileTableAdapter.Fill(this.repositoryDB2TFileWithoutId.TFile);
        //    dataGridView1.Columns[0].Width = 240;
        //    dataGridView1.Columns[1].Width = 60;
        //    dataGridView1.Columns[2].Width = 80;
        //    dataGridView1.Columns[3].Width = 30;
        //    dataGridView1.Columns[4].Width = 150;
        //    dataGridView1.Columns[5].Width = 50;
        //    dataGridView1.Columns[6].Width = 30;
        //}


        private const string CONNECTION_STRING =
  "Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";

        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        private void SearchForm_Load(object sender, EventArgs e)
        {
            ViewTFile();

            //заполнить dataGridView при запуске формы
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            dataAdapter.Fill(ds, "TFile");
            FileGrid.DataSource = ds.Tables["TFile"];
            FileGrid.Columns[0].HeaderText = "ID";
            FileGrid.Columns[1].HeaderText = "Название";
            FileGrid.Columns[2].HeaderText = "Формат";
            FileGrid.Columns[3].HeaderText = "Дата изменения";
            FileGrid.Columns[4].HeaderText = "Размер, КБ";
            FileGrid.Columns[5].HeaderText = "Ключевые слова";
            FileGrid.Columns[6].HeaderText = "Содержание";
            FileGrid.Columns[7].HeaderText = "IdCatalog";
            FileGrid.Columns[0].Width = 30;
            FileGrid.Columns[1].Width = 80;
            FileGrid.Columns[2].Width = 80;
            FileGrid.Columns[3].Width = 60;
            FileGrid.Columns[4].Width = 60;
            FileGrid.Columns[5].Width = 100;
            FileGrid.Columns[6].Width = 60;
            FileGrid.Columns[7].Width = 100;
        }

        private void populate(String id, String filename, string type, string date, string size, string keywords, string filecontent, string catalogid)
        {
            FileGrid.Rows.Add(id, filename, type, date, size, keywords, filecontent, catalogid);
        }


        //  Read 
        private void ViewTFile()
        {
            FileGrid.Rows.Clear();
            string sql = "SELECT * FROM TFile";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }




        //Типа живой поиск (не работает)
        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
        //    //    String.Format("Name like '{0}%'", txtSearch.Text);
        //    this.tFileBindingSource.Filter = "(Name LIKE '" + txtSearch.Text + "*')";
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (FileGrid.DataSource == tFileBindingSource)
            {
                tFileBindingSource.Filter = "name LIKE'" + txtSearch.Text + "%'";
                //где Исполнитель - название столбца в DatagridView
            }
        }
        //Поиск по ключевым словам (не работает)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            try
            {
                foreach (DataGridViewRow row in FileGrid.Rows)
                {
                    row.Selected = false;
                    this.tFileBindingSource.Filter = "(keywords LIKE '" + txtSearch.Text + "*')";
                }
            }

            catch
            {
                MessageBox.Show("Такого названия нет");
            }
        }


        //Радиокнопки по формату (не работает)
        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'doc')";
        }

        private void rbDocx_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'docx')";
        }

        private void rbTxt_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'txt')";
        }

        private void rbRtf_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'rtf')";
        }

        private void rbPdf_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'rtf')";
        }

        //Фильтр по размеру файла
        private void btnSizeFilter_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            try
            {
                if (txtMinSize.Text != "" && txtMaxSize.Text != "") //оба заполнены
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                    this.tFileBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
                else if (txtMinSize.Text == "" && txtMaxSize.Text == "") //оба пустые 
                {
                    MessageBox.Show("Поля min и max размер не заполнены");
                }
                else if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                }
                else if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Фильтр по дате
        private void btnDate_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = string.Format("Date >= #{0:MM.dd.yyyy} 00:00:00# AND Date <= #{1:MM.dd.yyyy} 23:59:59#"
, dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
