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
        //SqlCommand cmd;
        //SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //заполнить datagridview1 
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "files");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Формат";
            dataGridView1.Columns[3].HeaderText = "Дата изменения";
            dataGridView1.Columns[4].HeaderText = "Размер, КБ";
            dataGridView1.Columns[5].HeaderText = "Ключевые слова";
            dataGridView1.Columns[6].HeaderText = "Содержание";
            dataGridView1.Columns[7].HeaderText = "IdCatalog";
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 280;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 300;
            dataGridView1.Columns[7].Width = 50;
        }

        private void EditTFileForm_Load(object sender, EventArgs e)
        {
            con.Open(); //подключение открывается только при запуске формы
            FillDgv();
        }

        //TODO
        //CRUD-кнопки (из crud v3 - sp)


    }
}
